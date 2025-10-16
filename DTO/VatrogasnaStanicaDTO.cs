// File: DTO/VatrogasnaStanicaDTO.cs
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using NHibernate;
using VatrogasnaSluzba.Entiteti;

namespace VatrogasnaSluzba.DTO
{
    // ===== DTO za formu (unos/izmena) =====
    public class VatrogasnaStanicaDTO
    {
        public int IdStanice { get; set; }                  
        public string? Naziv { get; set; }                   
        public string? Adresa { get; set; }
        public int? BrojZaposlenih { get; set; }
        public int? BrojVozila { get; set; }
        public double? PovrsinaObjekta { get; set; }
        public string? KomandirMbr { get; set; }             
        public List<string> Infrastruktura { get; set; } = new();
    }

    // ===== DTO za DataGrid =====
    public class VatrogasnaStanicaListDTO
    {
        [DisplayName("ID_Stanice")] public int IdStanice { get; set; }
        [DisplayName("Adresa")] public string? Adresa { get; set; }
        [DisplayName("BrojZaposlenih")] public int? BrojZaposlenih { get; set; }
        [DisplayName("BrojVozila")] public int? BrojVozila { get; set; }
        [DisplayName("DostupnaInfrastruktura")] public string Infrastruktura { get; set; } = string.Empty;
        [DisplayName("PovrsinaObjekta")] public double? PovrsinaObjekta { get; set; }
        [DisplayName("Komandir")] public string? KomandirMbr { get; set; }

        public VatrogasnaStanicaListDTO() { }
        public VatrogasnaStanicaListDTO(VatrogasnaStanica e)
        {
            IdStanice = e.IdStanice;
            Adresa = e.Adresa;
            BrojZaposlenih = e.BrojZaposlenih;
            BrojVozila = e.BrojVozila;
            PovrsinaObjekta = e.PovrsinaObjekta;
            KomandirMbr = e.Komandir?.MaticniBroj;
            Infrastruktura = (e.Infrastruktura != null && e.Infrastruktura.Count > 0)
                ? string.Join(", ", e.Infrastruktura)
                : string.Empty;
        }
    }

    
    public static class VatrogasnaStanicaDTOManager
    {
        public static List<VatrogasnaStanicaListDTO> GetSveStaniceList()
        {
            try
            {
                using ISession s = DataLayer.GetSession();
                var ent = s.Query<VatrogasnaStanica>().ToList();
                return ent.Select(e => new VatrogasnaStanicaListDTO(e)).ToList();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("GetSveStaniceList: " + ex.Message);
                return new List<VatrogasnaStanicaListDTO>();
            }
        }

        public static VatrogasnaStanicaDTO? GetStanica(int id)
        {
            try
            {
                using ISession s = DataLayer.GetSession();
                var e = s.Get<VatrogasnaStanica>(id);
                if (e == null) return null;

                return new VatrogasnaStanicaDTO
                {
                    IdStanice = e.IdStanice,
                    Naziv = e.Naziv,
                    Adresa = e.Adresa,
                    BrojZaposlenih = e.BrojZaposlenih,
                    BrojVozila = e.BrojVozila,
                    PovrsinaObjekta = e.PovrsinaObjekta,
                    KomandirMbr = e.Komandir?.MaticniBroj,
                    Infrastruktura = e.Infrastruktura?.ToList() ?? new List<string>()
                };
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("GetStanica: " + ex.Message);
                return null;
            }
        }

        public static bool AddStanica(VatrogasnaStanicaDTO dto)
        {
            try
            {
                using ISession s = DataLayer.GetSession();
                using ITransaction tx = s.BeginTransaction();

                var e = new VatrogasnaStanica
                {
                    Naziv = string.IsNullOrWhiteSpace(dto.Naziv)
                        ? ("VS " + (dto.Adresa ?? "").Trim())
                        : dto.Naziv!.Trim(),
                    Adresa = dto.Adresa,
                    BrojZaposlenih = dto.BrojZaposlenih,
                    BrojVozila = dto.BrojVozila,
                    PovrsinaObjekta = dto.PovrsinaObjekta,
                    Infrastruktura = new List<string>()
                };

                if (!string.IsNullOrWhiteSpace(dto.KomandirMbr))
                {
                    var komandir = s.Get<Lice>(dto.KomandirMbr);
                    if (komandir == null)
                        throw new Exception("Komandir sa zadatim JMBG ne postoji.");
                    e.Komandir = komandir;
                }

                foreach (var inf in dto.Infrastruktura.Where(x => !string.IsNullOrWhiteSpace(x)))
                    e.Infrastruktura.Add(inf.Trim());

                s.Save(e);
                tx.Commit();
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("AddStanica: " + ex.Message);
                return false;
            }
        }

        public static bool UpdateStanica(VatrogasnaStanicaDTO dto)
        {
            try
            {
                using ISession s = DataLayer.GetSession();
                using ITransaction tx = s.BeginTransaction();

                var e = s.Get<VatrogasnaStanica>(dto.IdStanice)
                        ?? throw new Exception("Stanica nije pronađena.");

                e.Naziv = string.IsNullOrWhiteSpace(dto.Naziv)
                    ? ("VS " + (dto.Adresa ?? "").Trim())
                    : dto.Naziv!.Trim();
                e.Adresa = dto.Adresa;
                e.BrojZaposlenih = dto.BrojZaposlenih;
                e.BrojVozila = dto.BrojVozila;
                e.PovrsinaObjekta = dto.PovrsinaObjekta;

                if (string.IsNullOrWhiteSpace(dto.KomandirMbr))
                    e.Komandir = null;
                else
                {
                    var k = s.Get<Lice>(dto.KomandirMbr)
                            ?? throw new Exception("Komandir sa zadatim JMBG ne postoji.");
                    e.Komandir = k;
                }

                e.Infrastruktura.Clear();
                foreach (var inf in dto.Infrastruktura.Where(x => !string.IsNullOrWhiteSpace(x)))
                    e.Infrastruktura.Add(inf.Trim());

                s.Update(e);
                tx.Commit();
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("UpdateStanica: " + ex.Message);
                return false;
            }
        }

        
        public static bool DeleteStanica(int id)
        {
            try
            {
                using ISession s = DataLayer.GetSession();
                using ITransaction tx = s.BeginTransaction();

               

                s.CreateQuery("delete from VatrogasnaStanica v where v.IdStanice = :id")
                 .SetParameter("id", id)
                 .ExecuteUpdate();

                tx.Commit();
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("DeleteStanica: " + ex.Message);
                return false;
            }
        }
    }
}
