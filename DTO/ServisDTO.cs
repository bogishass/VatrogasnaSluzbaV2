using System;
using System.Collections.Generic;
using System.Linq;
using NHibernate;
using VatrogasnaSluzba.Entiteti;

namespace VatrogasnaSluzba.DTO
{
    
    public class ServisListDTO
    {
        public int IdServisa { get; set; }
        public DateTime? Datum { get; set; }
        public string Tip { get; set; }
        public string TehnicarMbr { get; set; } 
    }

    
    public class ServisDTO
    {
        public int IdServisa { get; set; }
        public string RegBrojVozila { get; set; }
        public DateTime? Datum { get; set; }
        public string Tip { get; set; }
        public string TehnicarMbr { get; set; }  

        public ServisDTO() { }

        public ServisDTO(Servis s)
        {
            IdServisa = s.IdServisa;
            RegBrojVozila = s.Vozilo?.RegBroj;
            Datum = s.DatumServisa ?? null;
            Tip = s.TipServisa;
            TehnicarMbr = s.Tehnicar?.MaticniBroj;
        }
    }

    public static class ServisDTOManager
    {
        private static ServisDTO CreateDTO(Servis s) => new(s);

        private static ServisListDTO CreateListDTO(Servis s) => new ServisListDTO
        {
            IdServisa = s.IdServisa,
            Datum = s.DatumServisa ?? null,
            Tip = s.TipServisa,
            TehnicarMbr = s.Tehnicar?.MaticniBroj
        };

        
        public static List<ServisListDTO> GetServisiZaVozilo(string regBroj)
        {
            try
            {
                using ISession s = DataLayer.GetSession();
                var q = s.Query<Servis>()
                         .Where(x => x.Vozilo.RegBroj == regBroj)
                         .OrderByDescending(x => x.DatumServisa)
                         .ToList();
                return q.Select(CreateListDTO).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("GetServisiZaVozilo: " + ex.Message);
                return new List<ServisListDTO>();
            }
        }



        public static bool AddServis(ServisDTO dto)
        {
            try
            {
                using ISession s = DataLayer.GetSession();
                using var tx = s.BeginTransaction();

                if (string.IsNullOrWhiteSpace(dto.RegBrojVozila))
                {
                    MessageBox.Show("Nedostaje registarski broj vozila.");
                    return false;
                }
                if (string.IsNullOrWhiteSpace(dto.TehnicarMbr))
                {
                    MessageBox.Show("Nedostaje tehničar (MBR).");
                    return false;
                }

                var vozilo = s.Get<Vozilo>(dto.RegBrojVozila);
                var tehnicar = s.Get<Tehnicar>(dto.TehnicarMbr);

                if (vozilo == null)
                {
                    MessageBox.Show("Vozilo nije pronađeno.");
                    return false;
                }
                if (tehnicar == null)
                {
                    MessageBox.Show("Tehničar nije pronađen.");
                    return false;
                }

                var ent = new Servis
                {
                    Vozilo = vozilo,
                    Tehnicar = tehnicar,
                    DatumServisa = dto.Datum,
                    TipServisa = dto.Tip?.Trim()
                };

                s.Save(ent);
                tx.Commit();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("AddServis: " + ex.Message);
                return false;
            }
        }

        
        public static bool UpdateServis(ServisDTO dto)
        {
            try
            {
                using ISession s = DataLayer.GetSession();
                using var tx = s.BeginTransaction();

                var ent = s.Get<Servis>(dto.IdServisa);
                if (ent == null)
                {
                    MessageBox.Show("Servis nije pronađen.");
                    return false;
                }

                // izmena reg broja
                if (!string.IsNullOrWhiteSpace(dto.RegBrojVozila) &&
                    ent.Vozilo?.RegBroj != dto.RegBrojVozila)
                {
                    var novoVozilo = s.Get<Vozilo>(dto.RegBrojVozila);
                    if (novoVozilo == null)
                    {
                        MessageBox.Show("Novo vozilo nije pronađeno.");
                        return false;
                    }
                    ent.Vozilo = novoVozilo;
                }

                // izmena tehnicara
                if (!string.IsNullOrWhiteSpace(dto.TehnicarMbr) &&
                    ent.Tehnicar?.MaticniBroj != dto.TehnicarMbr)
                {
                    var noviTeh = s.Get<Tehnicar>(dto.TehnicarMbr);
                    if (noviTeh == null)
                    {
                        MessageBox.Show("Novi tehničar nije pronađen.");
                        return false;
                    }
                    ent.Tehnicar = noviTeh;
                }

                ent.DatumServisa = dto.Datum;
                ent.TipServisa = dto.Tip?.Trim();

                s.Update(ent);
                tx.Commit();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("UpdateServis: " + ex.Message);
                return false;
            }
        }

        
        public static bool DeleteServis(int idServisa)
        {
            try
            {
                using ISession s = DataLayer.GetSession();
                using var tx = s.BeginTransaction();

                var ent = s.Get<Servis>(idServisa);
                if (ent == null)
                {
                    MessageBox.Show("Servis nije pronađen.");
                    return false;
                }

                s.Delete(ent);
                tx.Commit();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("DeleteServis: " + ex.Message);
                return false;
            }
        }
    }
}
