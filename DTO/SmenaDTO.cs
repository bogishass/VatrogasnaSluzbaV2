using NHibernate;
using NHibernate.Linq;      
using NHibernate.Transform;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq;          
using VatrogasnaSluzba.Entiteti;

namespace VatrogasnaSluzba.DTO
{
    public class SmenaDTO
    {
        [DisplayName("ID smene")]
        public int IdSmene { get; set; }
        [DisplayName("Datum smene")]
        public DateTime Datum { get; set; }
        [DisplayName("Početak")]
        public DateTime VremePocetka { get; set; }
        [DisplayName("Kraj")]
        public DateTime? VremeKraja { get; set; }
        [DisplayName("Br. intervencija")]
        public int? BrojIntervencija { get; set; }
        [DisplayName("Br. vatrogasaca")]
        public int? BrVatrogasaca { get; set; }
        [DisplayName("Br. dispečera")]
        public int? BrDispecera { get; set; }
        public StanicaSimpleDTO Stanica { get; set; }

        public SmenaDTO() { }

        public SmenaDTO(Smena s)
        {
            IdSmene = s.IdSmene;
            Datum = s.Datum;
            VremePocetka = s.VremePocetka;
            VremeKraja = s.VremeKraja;
            BrojIntervencija = s.BrojIntervencija;

            BrVatrogasaca = s.Lica?.Count(l => l.Pozicija == "Vatrogasac") ?? 0;
            BrDispecera = s.Lica?.Count(l => l.Pozicija == "Dispecer") ?? 0;

            Stanica = s.Stanica != null ? new StanicaSimpleDTO(s.Stanica) : null;
        }
    }

    public static class SmenaDTOManager
    {
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
               
            };
        }

        private static int CountByPozicija(ISession s, int idSmene, string pozicija)
        {
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

       
        public static List<SmenaDTO> GetByFilter(int? idStanice, DateTime od, DateTime @do)
        {
            using var s = DataLayer.GetSession();

            var start = od.Date;
            var end = @do.Date.AddDays(1).AddTicks(-1);

            IQueryable<Smena> q = s.Query<Smena>()
                                   .Where(x => x.Datum >= start && x.Datum <= end);

            if (idStanice.HasValue)
                q = q.Where(x => x.Stanica.IdStanice == idStanice.Value);

            var smene = q.Fetch(x => x.Stanica)
                         .ToList();

            var dtos = smene.Select(x => ToDto(x)).ToList();

            foreach (var dto in dtos)
            {
                dto.BrVatrogasaca = CountByPozicija(s, dto.IdSmene, "Vatrogasac");
                dto.BrDispecera = CountByPozicija(s, dto.IdSmene, "Dispecer");
                dto.BrojIntervencija = CountIntervencije(s, dto.IdSmene);
            }

            return dtos;
        }


        
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

            MessageBox.Show(dto.BrojIntervencija.ToString());
            MessageBox.Show(e.BrojIntervencija.ToString());

            s.Save(e);
            tx.Commit();
            return e.IdSmene;
        }

       
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

            MessageBox.Show(dto.BrojIntervencija.ToString());
            MessageBox.Show(e.BrojIntervencija.ToString());

            if (dto.Stanica != null)
                e.Stanica = s.Get<VatrogasnaStanica>(dto.Stanica.IdStanice);

            s.Update(e);
            tx.Commit();
        }

      
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

