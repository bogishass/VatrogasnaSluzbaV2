// File: DTO/OpremaDTO.cs
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using NHibernate;
using VatrogasnaSluzba.Entiteti;

namespace VatrogasnaSluzba.DTO
{
    public class OpremaDTO
    {
        public int InventarskiBroj { get; set; }
        public string Naziv { get; set; }
        public string Tip { get; set; }
        public string Podtip { get; set; }
        public string LokacijaOpreme { get; set; }
        public string Status { get; set; }
        public DateTime? DatumNabavke { get; set; }
        public List<int> IntervencijeIds { get; set; } = new();

        public OpremaDTO() { }
        public OpremaDTO(Oprema e)
        {
            InventarskiBroj = e.InventarskiBroj;
            Naziv = e.Naziv;
            Tip = e.Tip;
            Podtip = e.Podtip;
            LokacijaOpreme = e.LokacijaOpreme;
            Status = e.Status;
            DatumNabavke = e.DatumNabavke;
            IntervencijeIds = e.Intervencije?.Select(i => i.IdIntervencije).ToList() ?? new List<int>();
        }
    }

    public class OpremaListDTO
    {
        [DisplayName("Inventarski broj")] public int InventarskiBroj { get; set; }
        [DisplayName("Naziv")] public string Naziv { get; set; }
        [DisplayName("Tip")] public string Tip { get; set; }
        [DisplayName("PodTip")] public string Podtip { get; set; }
        [DisplayName("LokacijaOpreme")] public string LokacijaOpreme { get; set; }
        [DisplayName("Status")] public string Status { get; set; }
        [DisplayName("Datum nabavke")] public DateTime? DatumNabavke { get; set; }
        [DisplayName("Intervencija")] public int BrojIntervencija { get; set; }

        public OpremaListDTO(Oprema e)
        {
            InventarskiBroj = e.InventarskiBroj;
            Naziv = e.Naziv;
            Tip = e.Tip;
            Podtip = e.Podtip;
            LokacijaOpreme = e.LokacijaOpreme;
            Status = e.Status;
            DatumNabavke = e.DatumNabavke;
            BrojIntervencija = e.Intervencije?.Count ?? 0;
        }
    }

    public static class OpremaDTOManager
    {
        public static OpremaDTO Create(Oprema e) => new(e);

        public static bool AddOprema(OpremaDTO dto)
        {
            try
            {
                using ISession s = DataLayer.GetSession();
                using ITransaction tx = s.BeginTransaction();

                if (s.Query<Oprema>().Any(x => x.InventarskiBroj == dto.InventarskiBroj))
                {
                    System.Windows.Forms.MessageBox.Show("Oprema sa tim inventarskim brojem već postoji.");
                    return false;
                }

                var e = new Oprema
                {
                    InventarskiBroj = dto.InventarskiBroj,
                    Naziv = dto.Naziv,
                    Tip = dto.Tip,
                    Podtip = dto.Podtip,
                    LokacijaOpreme = dto.LokacijaOpreme,
                    Status = dto.Status,
                    DatumNabavke = dto.DatumNabavke,
                    Intervencije = new List<Intervencija>()
                };

                // po potrebi kreiraj veze (nije obavezno za tvoj UI)
                if (dto.IntervencijeIds?.Count > 0)
                    foreach (var id in dto.IntervencijeIds.Distinct())
                        e.Intervencije.Add(s.Load<Intervencija>(id));

                s.Save(e);
                tx.Commit();
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("AddOprema: " + ex.Message);
                return false;
            }
        }

        public static bool UpdateOprema(OpremaDTO dto)
        {
            try
            {
                using ISession s = DataLayer.GetSession();
                using ITransaction tx = s.BeginTransaction();

                var e = s.Get<Oprema>(dto.InventarskiBroj);
                if (e == null)
                {
                    System.Windows.Forms.MessageBox.Show("Oprema nije pronađena u bazi.");
                    return false;
                }

                e.Naziv = dto.Naziv;
                e.Tip = dto.Tip;
                e.Podtip = dto.Podtip;
                e.LokacijaOpreme = dto.LokacijaOpreme;
                e.Status = dto.Status;
                e.DatumNabavke = dto.DatumNabavke;

                // NE diraj many-to-many u update-u osim ako UI menja veze
                // e.Intervencije.Clear();  // ← uklonjeno

                s.Update(e);
                tx.Commit();
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("UpdateOprema: " + ex.Message);
                return false;
            }
        }

        public static bool DeleteOprema(int inventarskiBroj)
        {
            try
            {
                using ISession s = DataLayer.GetSession();
                using ITransaction tx = s.BeginTransaction();

                var e = s.Get<Oprema>(inventarskiBroj);
                if (e == null) throw new Exception("Oprema nije pronađena.");

                s.Delete(e);   // linkovi iz OPREMA_U_INTERVENCIJI će se obrisati FK-om
                tx.Commit();
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("DeleteOprema: " + ex.Message);
                return false;
            }
        }

        public static List<OpremaDTO> GetSvaOprema()
        {
            try
            {
                using ISession s = DataLayer.GetSession();
                return s.Query<Oprema>().ToList().Select(Create).ToList();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("GetSvaOprema: " + ex.Message);
                return new List<OpremaDTO>();
            }
        }

        public static List<OpremaListDTO> GetSvaOpremaList()
        {
            try
            {
                using ISession s = DataLayer.GetSession();
                return s.Query<Oprema>().ToList().Select(o => new OpremaListDTO(o)).ToList();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("GetSvaOpremaList: " + ex.Message);
                return new List<OpremaListDTO>();
            }
        }

        public static OpremaDTO GetOprema(int inventarskiBroj)
        {
            try
            {
                using ISession s = DataLayer.GetSession();
                var e = s.Get<Oprema>(inventarskiBroj);
                return e == null ? null : new OpremaDTO(e);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("GetOprema: " + ex.Message);
                return null;
            }
        }
    }
}
