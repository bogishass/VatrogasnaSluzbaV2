using System;
using System.Collections.Generic;
using System.Linq;
using NHibernate;
using NHibernate.Transform;
using VatrogasnaSluzba.Entiteti;
using System.Linq;          
using NHibernate.Linq;      

namespace VatrogasnaSluzba.DTO
{
    // =======================
    // DTO klasa
    // =======================
    public class SmenaDTO
    {
        public int IdSmene { get; set; }
        public DateTime Datum { get; set; }
        public DateTime VremePocetka { get; set; }
        public DateTime? VremeKraja { get; set; }
        public int? BrojIntervencija { get; set; }

        // Informativna polja za grid
        public int BrVatrogasaca { get; set; }
        public int BrDispecera { get; set; }

        // Jednostavan DTO za stanicu (kao u LiceDTO)
        public StanicaSimpleDTO Stanica { get; set; }

        public SmenaDTO() { }

        // Konstruktor iz entiteta (isti pattern kao LiceDTO(Lice l))
        public SmenaDTO(Smena s)
        {
            IdSmene = s.IdSmene;
            Datum = s.Datum;
            VremePocetka = s.VremePocetka;
            VremeKraja = s.VremeKraja;
            BrojIntervencija = s.BrojIntervencija;

            // Ako NHibernate učita kolekciju, brojke će se lepo izračunati;
            // ako je lazy – ostaju 0 (mi ih svakako popunjavamo u Manager-u).
            BrVatrogasaca = s.Lica?.Count(l => l.Pozicija == "Vatrogasac") ?? 0;
            BrDispecera = s.Lica?.Count(l => l.Pozicija == "Dispecer") ?? 0;

            Stanica = s.Stanica != null ? new StanicaSimpleDTO(s.Stanica) : null;
        }
    }

    // =======================
    // DTO MANAGER
    // =======================
    public static class SmenaDTOManager
    {
        // --- mapiranje entitet -> dto (bez brojanja) ---
        private static SmenaDTO ToDto(Smena s)
        {
            return new SmenaDTO
            {
                IdSmene = s.IdSmene,
                Datum = s.Datum,
                VremePocetka = s.VremePocetka,
                VremeKraja = s.VremeKraja,
                BrojIntervencija = s.BrojIntervencija,
                Stanica = s.Stanica != null ? new StanicaSimpleDTO(s.Stanica) : null,
                // BrVatrogasaca/BrDispecera popunjavamo naknadno
            };
        }

        // Ako koristiš Assigned Id u mapi, sledeća vrednost iz sekvence
        private static int NextId(ISession s)
        {
            var raw = s.CreateSQLQuery("select SMENA_SEQ.NEXTVAL from dual").UniqueResult();
            return Convert.ToInt32(raw);
        }

        // --- pomoćni counteri (radimo nad pomoćnim tabelama, bez 'Lice.Smena') ---
        private static int CountByPozicija(ISession s, int idSmene, string pozicija)
        {
            // LICE_U_SMENI (ID_smene, MATICNI_BROJ), LICE (MATICNI_BROJ, POZICIJA)
            return Convert.ToInt32(
                s.CreateSQLQuery(@"
                    select count(*) 
                    from LICE_U_SMENI lus
                    join LICE l on l.MATICNI_BROJ = lus.MATICNI_BROJ
                    where lus.ID_smene = :id and l.POZICIJA = :poz
                ")
                .SetParameter("id", idSmene)
                .SetParameter("poz", pozicija)
                .UniqueResult()
            );
        }

        private static int CountIntervencije(ISession s, int idSmene)
        {
            return Convert.ToInt32(
                s.CreateSQLQuery(@"select count(*) from INTERVENCIJA_SMENA where ID_smene = :id")
                 .SetParameter("id", idSmene)
                 .UniqueResult()
            );
        }

        // -------- READ (filter) --------
        public static List<SmenaDTO> GetByFilter(int? idStanice, DateTime od, DateTime @do)
        {
            using var s = DataLayer.GetSession();

            var start = od.Date;
            var end = @do.Date.AddDays(1).AddTicks(-1);

            // 1) kreneš od IQueryable<Smena> i primeniš SVE Where uslove
            IQueryable<Smena> q = s.Query<Smena>()
                                   .Where(x => x.Datum >= start && x.Datum <= end);

            if (idStanice.HasValue)
                q = q.Where(x => x.Stanica.IdStanice == idStanice.Value);

            // 2) tek onda Fetch (jedan join na stanicu, bez kolekcija)
            var smene = q.Fetch(x => x.Stanica)
                         .ToList();

            // 3) mapiranje -> DTO (lambda da izbegnemo method-group zabunu)
            var dtos = smene.Select(x => ToDto(x)).ToList();

            // 4) dopuni brojčana polja jeftinim COUNT upitima
            foreach (var dto in dtos)
            {
                dto.BrVatrogasaca = CountByPozicija(s, dto.IdSmene, "Vatrogasac");
                dto.BrDispecera = CountByPozicija(s, dto.IdSmene, "Dispecer");
                dto.BrojIntervencija = CountIntervencije(s, dto.IdSmene);
            }

            return dtos;
        }


        // -------- CREATE --------
        public static int Add(SmenaDTO dto)
        {
            using var s = DataLayer.GetSession();
            using var tx = s.BeginTransaction();

            if (dto.Stanica == null)
                throw new Exception("Stanica je obavezna.");

            var e = new Smena
            {
                Datum = dto.Datum.Date,
                VremePocetka = dto.VremePocetka,
                VremeKraja = dto.VremeKraja,
                BrojIntervencija = dto.BrojIntervencija,
                Stanica = s.Get<VatrogasnaStanica>(dto.Stanica.IdStanice)
            };

            // Ako ti je u mapi Assigned(), dodeli iz sekvence
            if (e.IdSmene == 0)
            {
                try { e.IdSmene = NextId(s); } catch { /* NH će dodeliti ako je SequenceIdentity */ }
            }

            s.Save(e);
            tx.Commit();
            return e.IdSmene;
        }

        // -------- UPDATE --------
        public static void Update(SmenaDTO dto)
        {
            if (dto.IdSmene <= 0) throw new Exception("Nedostaje ID smene.");

            using var s = DataLayer.GetSession();
            using var tx = s.BeginTransaction();

            var e = s.Get<Smena>(dto.IdSmene) ?? throw new Exception("Smena nije pronađena.");

            e.Datum = dto.Datum.Date;
            e.VremePocetka = dto.VremePocetka;
            e.VremeKraja = dto.VremeKraja;
            e.BrojIntervencija = dto.BrojIntervencija;

            if (dto.Stanica != null)
                e.Stanica = s.Get<VatrogasnaStanica>(dto.Stanica.IdStanice);

            s.Update(e);
            tx.Commit();
        }

        // -------- DELETE --------
        public static void Delete(int idSmene)
        {
            using var s = DataLayer.GetSession();
            using var tx = s.BeginTransaction();

            var e = s.Get<Smena>(idSmene);
            if (e != null)
            {
                s.Delete(e);
                tx.Commit();
            }
        }
    }
}

