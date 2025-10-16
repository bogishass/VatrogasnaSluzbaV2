using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using VatrogasnaSluzba.Entiteti;
using static System.Collections.Specialized.BitVector32;

namespace VatrogasnaSluzba.DTO
{
   
    public class LiceDTO
    {
        public string MaticniBroj { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Pol { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Adresa { get; set; }
        public string Email { get; set; }
        public DateTime? DatPocetkaAngaz { get; set; }
        public string Pozicija { get; set; }
        public virtual StanicaSimpleDTO Stanica { get; set; }

        public List<string> Telefoni { get; set; } = new();
        

        
        public LiceDTO() { }

      
        public LiceDTO(Lice l)
        {
            MaticniBroj = l.MaticniBroj;
            Ime = l.Ime;
            Prezime = l.Prezime;
            Pol = l.Pol;
            DatumRodjenja = l.DatumRodjenja;
            Adresa = l.Adresa;
            Email = l.Email;
            DatPocetkaAngaz = l.DatPocetkaAngaz;
            Pozicija = l.Pozicija;
            Stanica = new StanicaSimpleDTO(l.Stanica);
            Telefoni = l.Telefoni.ToList();
        }
    }

    public class LiceListDTO
    {
        [DisplayName("Matični broj")] 
        public string MaticniBroj { get; set; }

        [DisplayName("Ime")]
        public string Ime { get; set; }

        [DisplayName("Prezime")]
        public string Prezime { get; set; }

        [DisplayName("Pol")]
        public string Pol { get; set; }

        [DisplayName("Datum angažovanja")]
        public DateTime? DatPocetkaAngaz { get; set; }

        public string Pozicija { get; set; } 

       
        public LiceListDTO(Lice l)
        {
            MaticniBroj = l.MaticniBroj;
            Ime = l.Ime;
            Prezime = l.Prezime;
            Pol = l.Pol;
            DatPocetkaAngaz = l.DatPocetkaAngaz;
            Pozicija = l.Pozicija;
        }
    }

    
    public class VatrogasacDTO : LiceDTO
    {
        public string NivoObucenosti { get; set; }  
        public string FizickaSprema { get; set; }
        public int? BrojSertifikata { get; set; }

        public VatrogasacDTO() { }
        public VatrogasacDTO(Vatrogasac v) : base(v)
        {
            NivoObucenosti = v.NivoObucenosti;
            FizickaSprema = v.FizickaSprema;
            BrojSertifikata = v.BrojSertifikata;
        }
    }

    
    public class TehnicarDTO : LiceDTO
    {
        public string Specijalizacija { get; set; }
        public List<string> Alati { get; set; } = new();

        public TehnicarDTO() { }
        public TehnicarDTO(Tehnicar t) : base(t)
        {
            Specijalizacija = t.Specijalizacija;
            Alati = new List<string>(t.Alati);
        }
    }

   
    public class DispecerDTO : LiceDTO
    {
        public string TipKomunikacioneOpreme { get; set; }
        public int? BrojSmenaMesecno { get; set; }

        public DispecerDTO() { }
        public DispecerDTO(Dispecer d) : base(d)
        {
            TipKomunikacioneOpreme = d.TipKomunikacioneOpreme;
            BrojSmenaMesecno = d.BrojSmenaMesecno;
        }
    }

    
    public class VolonterDTO : LiceDTO
    {
        public List<VoziloVolonteraSimpleDTO> Vozila { get; set; } = new();
       

        public VolonterDTO() { }
        public VolonterDTO(Volonter v) : base(v)
        {
            Vozila = v.Vozila.Select(x => new VoziloVolonteraSimpleDTO(x)).ToList();
        }
    }

    
    public static class LiceDTOManager
    {
       
        public static LiceDTO Create(Lice l)
        {
            switch (l)
            {
                case Vatrogasac v:
                    return new VatrogasacDTO(v);
                case Tehnicar t:
                    return new TehnicarDTO(t);
                case Dispecer d:
                    return new DispecerDTO(d);
                case Volonter v:
                    return new VolonterDTO(v);
                default:
                    return new LiceDTO(l);
            }
        }
        public static bool AddLice(LiceDTO liceDto)
        {
            try
            {
                using ISession s = DataLayer.GetSession();
                using ITransaction tx = s.BeginTransaction();

               
                bool exists = s.Query<Lice>()
                                .Count(x => x.MaticniBroj == liceDto.MaticniBroj) > 0;
                if (exists)
                {
                    MessageBox.Show("Lice sa tim JMBG već postoji.");
                    return false;
                }

               
                Lice newEntity;

                switch (liceDto)
                {
                    case VatrogasacDTO v:
                        newEntity = new Vatrogasac
                        {
                            NivoObucenosti = v.NivoObucenosti,
                            FizickaSprema = v.FizickaSprema,
                            BrojSertifikata = v.BrojSertifikata
                        };
                        break;

                    case TehnicarDTO t:
                        newEntity = new Tehnicar
                        {
                            Specijalizacija = t.Specijalizacija,
                            Alati = t.Alati != null ? new List<string>(t.Alati) : new List<string>()
                        };
                        break;

                    case DispecerDTO d:
                        newEntity = new Dispecer
                        {
                            TipKomunikacioneOpreme = d.TipKomunikacioneOpreme,
                            BrojSmenaMesecno = d.BrojSmenaMesecno
                        };
                        break;

                    case VolonterDTO vol:
                        newEntity = new Volonter
                        {
                            Vozila = new List<VoziloVolontera>()
                        };
                        break;

                    default:
                       
                        newEntity = new Lice();
                        break;
                }

              
                newEntity.MaticniBroj = liceDto.MaticniBroj;
                newEntity.Ime = liceDto.Ime;
                newEntity.Prezime = liceDto.Prezime;
                newEntity.Pol = liceDto.Pol;
                newEntity.Adresa = liceDto.Adresa;
                newEntity.Email = liceDto.Email;
                newEntity.DatumRodjenja = liceDto.DatumRodjenja;
                newEntity.DatPocetkaAngaz = liceDto.DatPocetkaAngaz;
                newEntity.Pozicija = liceDto.Pozicija;

                if (liceDto.Stanica != null)
                {
                    newEntity.Stanica = s.Get<VatrogasnaStanica>(liceDto.Stanica.IdStanice);
                }

               
                if (liceDto.Telefoni != null && liceDto.Telefoni.Count > 0)
                {
                    newEntity.Telefoni = new List<string>(liceDto.Telefoni);
                }

               
                s.Save(newEntity);
                tx.Commit();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("AddLice: " + ex.Message);
                return false;
            }
        }

        public static bool DeleteLice(string maticniBroj)
        {
            try
            {
                SessionHelper.WithSession(session =>
                {
                    var lice = session.Query<Lice>().FirstOrDefault(l => l.MaticniBroj == maticniBroj);
                    if (lice == null)
                    {
                        throw new Exception("Lice nije pronađeno.");
                    }

                    session.Delete(lice);
                });

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("DeleteLice: " + ex.Message);
                return false;
            }
        }
        public static bool UpdateLice(LiceDTO liceDto)
        {
            try
            {
                using ISession s = DataLayer.GetSession();
                using ITransaction tx = s.BeginTransaction();

                var lice = s.Get<Lice>(liceDto.MaticniBroj);
                if (lice == null)
                {
                    MessageBox.Show("Lice nije pronađeno u bazi.");
                    return false;
                }

                
                lice.Ime = liceDto.Ime;
                lice.Prezime = liceDto.Prezime;
                lice.Pol = liceDto.Pol;
                lice.Adresa = liceDto.Adresa;
                lice.Email = liceDto.Email;
                lice.DatumRodjenja = liceDto.DatumRodjenja;
                lice.DatPocetkaAngaz = liceDto.DatPocetkaAngaz;
                lice.Pozicija = liceDto.Pozicija;

                if (liceDto.Stanica != null)
                    lice.Stanica = s.Get<VatrogasnaStanica>(liceDto.Stanica.IdStanice);

              
                lice.Telefoni.Clear();
                if (liceDto.Telefoni != null)
                {
                    foreach (var broj in liceDto.Telefoni)
                    {
                        lice.Telefoni.Add(broj);
                    }
                }

                
                switch (lice)
                {
                    case Vatrogasac v when liceDto is VatrogasacDTO vd:
                        v.NivoObucenosti = vd.NivoObucenosti;
                        v.FizickaSprema = vd.FizickaSprema;
                        v.BrojSertifikata = vd.BrojSertifikata;
                        break;

                    case Tehnicar t when liceDto is TehnicarDTO td:
                        t.Specijalizacija = td.Specijalizacija;

                        t.Alati.Clear();
                        if (td.Alati != null)
                        {
                            foreach (string alat in td.Alati)
                            {
                                t.Alati.Add(alat);
                               
                            }
                           ;
                        }
                        
                        break;

                    case Dispecer d when liceDto is DispecerDTO dd:
                        d.TipKomunikacioneOpreme = dd.TipKomunikacioneOpreme;
                        d.BrojSmenaMesecno = dd.BrojSmenaMesecno;
                        break;

                    case Volonter vol when liceDto is VolonterDTO voldto:
                        var existing = vol.Vozila.ToDictionary(v => v.RegBroj);

                        vol.Vozila.Clear();

                        foreach (var dto in voldto.Vozila)
                        {
                            if (existing.TryGetValue(dto.RegBroj, out var found))
                            {
                                found.Tip = dto.Tip;
                                found.Proizvodjac = dto.Proizvodjac;
                                vol.Vozila.Add(found);
                            }
                            else
                            {
                                vol.Vozila.Add(new VoziloVolontera
                                {
                                    RegBroj = dto.RegBroj,
                                    Tip = dto.Tip,
                                    Proizvodjac = dto.Proizvodjac,
                                    Vlasnik = vol
                                });
                            }
                           
                        }
                        break;
                }

                s.Update(lice);
                tx.Commit();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("UpdateLice: " + ex.Message);
                return false;
            }
        }

        public static List<LiceDTO> GetSvaLica()
        {
            try
            {
                using ISession session = DataLayer.GetSession();
                var svaLica = session.Query<Lice>();
                return svaLica.Select(LiceDTOManager.Create).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("GetSvaLica: " + ex.Message);
            }

            return new List<LiceDTO>();
        }

        public static List<LiceListDTO> GetSvaLicaList()
        {
            try
            {
                using ISession session = DataLayer.GetSession();
                var svaLica = session.Query<Lice>(); 
                return svaLica.Select(l => new LiceListDTO(l)).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("GetSvaLicaList: " + ex.Message);
            }

            return new List<LiceListDTO>();
        }

        public static LiceDTO GetLice(string jmbg)
        {
            using (ISession s = DataLayer.GetSession())
            {
                var l = s.Get<Lice>(jmbg);
                if (l == null) return null;

                return LiceDTOManager.Create(l);
            }
        }
    }
}
