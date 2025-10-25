using System;
using System.Collections.Generic;
using System.Linq;
using NHibernate;
using VatrogasnaSluzba.Entiteti;

namespace VatrogasnaSluzba.DTO
{
    public class VoziloDTO
    {
        public string RegBroj { get; set; }
        public string Tip { get; set; }                
        public string Podtip { get; set; }            
        public string Proizvodjac { get; set; }
        public int? GodProizvodnje { get; set; }
        public string Status { get; set; }             
        public int? Kapacitet { get; set; }
        public DateTime? DatIstekaReg { get; set; }
        public List<string> Sertifikati { get; set; } = new();

        public VoziloDTO() { }
        public VoziloDTO(Vozilo v)
        {
            RegBroj = v.RegBroj;
            Tip = v.Tip;
            Podtip = v.Podtip;
            Proizvodjac = v.Proizvodjac;
            GodProizvodnje = v.GodProizvodnje;
            Status = v.Status;
            Kapacitet = v.Kapacitet;
            DatIstekaReg = v.DatIstekaReg;
            Sertifikati = v.Sertifikati?.ToList() ?? new List<string>();
        }
    }

    public static class VoziloDTOManager
    {
        public static VoziloDTO Create(Vozilo v) => new(v);

        public static List<VoziloDTO> GetSvaVozila()
        {
            try
            {
                using ISession s = DataLayer.GetSession();
                return s.Query<Vozilo>().ToList().Select(Create).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("GetSvaVozila: " + ex.Message);
                return new List<VoziloDTO>();
            }
        }

        public static VoziloDTO GetVozilo(string reg)
        {
            try
            {
                using ISession s = DataLayer.GetSession();
                var v = s.Get<Vozilo>(reg);
                return v == null ? null : new VoziloDTO(v);
            }
            catch (Exception ex)
            {
                MessageBox.Show("GetVozilo: " + ex.Message);
                return null;
            }
        }

        public static bool AddVozilo(VoziloDTO dto)
        {
            try
            {
                using ISession s = DataLayer.GetSession();
                using var tx = s.BeginTransaction();

                if (string.IsNullOrWhiteSpace(dto.RegBroj))
                {
                    MessageBox.Show("Registarski broj je obavezan.");
                    return false;
                }

                if (s.Get<Vozilo>(dto.RegBroj) != null)
                {
                    MessageBox.Show("Vozilo sa tim registarskim brojem već postoji.");
                    return false;
                }

                var v = new Vozilo
                {
                    RegBroj = dto.RegBroj.Trim(),
                    Tip = dto.Tip?.Trim(),
                    Podtip = dto.Podtip?.Trim(),
                    Proizvodjac = dto.Proizvodjac?.Trim(),
                    GodProizvodnje = dto.GodProizvodnje,
                    Status = string.IsNullOrWhiteSpace(dto.Status) ? "Operativno" : dto.Status.Trim(),
                    Kapacitet = dto.Kapacitet,
                    DatIstekaReg = dto.DatIstekaReg,
                    Sertifikati = dto.Sertifikati?.ToList() ?? new List<string>()
                };

                s.Save(v);
                tx.Commit();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("AddVozilo: " + ex.Message);
                return false;
            }
        }

        public static bool UpdateVozilo(VoziloDTO dto)
        {
            try
            {
                using ISession s = DataLayer.GetSession();
                using var tx = s.BeginTransaction();

                var v = s.Get<Vozilo>(dto.RegBroj);
                if (v == null)
                {
                    MessageBox.Show("Vozilo nije pronađeno.");
                    return false;
                }

                v.Tip = dto.Tip?.Trim();
                v.Podtip = dto.Podtip?.Trim();
                v.Proizvodjac = dto.Proizvodjac?.Trim();
                v.GodProizvodnje = dto.GodProizvodnje;
                v.Status = string.IsNullOrWhiteSpace(dto.Status) ? "Operativno" : dto.Status.Trim();
                v.Kapacitet = dto.Kapacitet;
                v.DatIstekaReg = dto.DatIstekaReg;

                v.Sertifikati.Clear();
                foreach (string sert in dto.Sertifikati)
                {
                    if (!string.IsNullOrWhiteSpace(sert))
                    {
                        v.Sertifikati.Add(sert.Trim());
                    }
                }

                s.Update(v);
                tx.Commit();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("UpdateVozilo: " + ex.Message);
                return false;
            }
        }

        public static bool DeleteVozilo(string reg)
        {
            try
            {
                using ISession s = DataLayer.GetSession();
                using var tx = s.BeginTransaction();

                var v = s.Get<Vozilo>(reg);
                if (v == null)
                {
                    MessageBox.Show("Vozilo nije pronađeno.");
                    return false;
                }

                s.Delete(v);
                tx.Commit();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("DeleteVozilo: " + ex.Message);
                return false;
            }
        }
    }
}
