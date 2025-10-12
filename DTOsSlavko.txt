using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecijiLetnjiProgram
{
    public class DeteOsnovneInfo
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Pol { get; set; }


        public DeteOsnovneInfo(int id, string ime, string prezime, DateTime datumRodjenja, string pol)
        {
            Id = id;
            Ime = ime;
            Prezime = prezime;
            DatumRodjenja = datumRodjenja;
            Pol = pol;
        }
        public override string ToString()
        {
            return Ime + " " + Prezime;
        }
    }

    public class DeteBasic
    {
        public virtual int Id { get; set; }
        public virtual string Ime { get; set; } = string.Empty;
        public virtual string Prezime { get; set; } = string.Empty;
        public virtual DateTime DatumRodjenja { get; set; }
        public virtual string Pol { get; set; } = "M"; // 'M' or 'Ž'
        public virtual string Adresa { get; set; } = string.Empty;
        public virtual string KontaktTelefon { get; set; } = string.Empty;
        public virtual string EmailRoditelja { get; set; } = string.Empty;
        public virtual string BrojTelefona { get; set; }
        public virtual string EmailDeteta { get; set; }

        public DeteBasic() { }

        public DeteBasic(int id, string ime, string prezime, DateTime datumRodjenja, string pol, string adresa, string kontaktTelefon, string emailRoditelja, string brojTelefona, string emailDeteta)
        {
            Id = id;
            Ime = ime;
            Prezime = prezime;
            DatumRodjenja = datumRodjenja;
            Pol = pol;
            Adresa = adresa;
            KontaktTelefon = kontaktTelefon;
            EmailRoditelja = emailRoditelja;
            BrojTelefona = brojTelefona;
            EmailDeteta = emailDeteta;
        }
    }

    public class ZdravstvenoOgranicenjeBasic
    {
        public int Id { get; set; }
        public string Ogranicenje { get; set; }

        public ZdravstvenoOgranicenjeBasic(int id, string ogranicenje)
        {
            Id = id;
            Ogranicenje = ogranicenje;
        }

        public ZdravstvenoOgranicenjeBasic() { }
    }
    // === LOKACIJE ===
    public class LokacijaOsnovneInfo
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public string Tip { get; set; } // "zatvoreni" / "otvoreni"
        public int Kapacitet { get; set; }

        public LokacijaOsnovneInfo() { }
        public LokacijaOsnovneInfo(int id, string naziv, string adresa, string tip, int kapacitet)
        {
            Id = id;
            Naziv = naziv;
            Adresa = adresa;
            Tip = tip;
            Kapacitet = kapacitet;
        }
    }

    public class LokacijaBasic
    {
        public int Id { get; set; }
        public string Naziv { get; set; } = string.Empty;
        public string Adresa { get; set; } = string.Empty;
        public string Tip { get; set; } = "zatvoreni"; // "zatvoreni" / "otvoreni"
        public int Kapacitet { get; set; }
        public string TipOpreme { get; set; } = string.Empty;

        public LokacijaBasic() { }
        public LokacijaBasic(int id, string naziv, string adresa, string tip, int kapacitet, string tipOpreme)
        {
            Id = id;
            Naziv = naziv;
            Adresa = adresa;
            Tip = tip;
            Kapacitet = kapacitet;
            TipOpreme = tipOpreme;
        }
    }

    // === AKTIVNOSTI ===
    public class AktivnostOsnovneInfo
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Tip { get; set; } // radionica/sportski_trening/izlet/kulturni_program
        public DateTime DatumIVreme { get; set; }
        public int LokacijaId { get; set; }
        public string LokacijaNaziv { get; set; }
        public string StarosnaGrupa { get; set; }

        public AktivnostOsnovneInfo() { }
        public AktivnostOsnovneInfo(int id, string naziv, string tip, DateTime datumIVreme, int lokacijaId, string lokacijaNaziv, string starosnaGrupa)
        {
            Id = id;
            Naziv = naziv;
            Tip = tip;
            DatumIVreme = datumIVreme;
            LokacijaId = lokacijaId;
            LokacijaNaziv = lokacijaNaziv;
            StarosnaGrupa = starosnaGrupa;
        }

        public override string ToString()
        {
            return Naziv + " (" + DatumIVreme.ToString("g") + ")" + " - " + StarosnaGrupa;
        }
    }

    public class AktivnostBasic
    {
        public int Id { get; set; }
        public string Naziv { get; set; } = string.Empty;
        public string Tip { get; set; } = "radionica"; // radionica/sportski_trening/izlet/kulturni_program
        public DateTime DatumIVreme { get; set; }
        public string StarosnaGrupa { get; set; } = string.Empty;
        public int MaxBrojUcesnika { get; set; }
        public int LokacijaId { get; set; }

        // Sekcija zavisna od tipa:
        // radionica
        public string TipRadionice { get; set; } = string.Empty; // umetnička/naučna
                                                                 // sportski_trening
        public string Sport { get; set; } = string.Empty;
        public string PosebnaOprema { get; set; } = string.Empty;
        // izlet
        public string PrevoznoSredstvo { get; set; } = string.Empty;
        public string PlanPuta { get; set; } = string.Empty;
        public string Vodic { get; set; } = string.Empty;
        public string PotrebnaOprema { get; set; } = string.Empty;
        // kulturni_program
        public string TipKultProg { get; set; } = string.Empty;

        public AktivnostBasic() { }

        public AktivnostBasic(
            int id,
            string naziv,
            string tip,
            DateTime datumIVreme,
            string starosnaGrupa,
            int maxBrojUcesnika,
            int lokacijaId,
            string tipRadionice,
            string sport,
            string posebnaOprema,
            string prevoznoSredstvo,
            string planPuta,
            string vodic,
            string potrebnaOprema,
            string tipKultProg)
        {
            Id = id;
            Naziv = naziv;
            Tip = tip;
            DatumIVreme = datumIVreme;
            StarosnaGrupa = starosnaGrupa;
            MaxBrojUcesnika = maxBrojUcesnika;
            LokacijaId = lokacijaId;
            TipRadionice = tipRadionice;
            Sport = sport;
            PosebnaOprema = posebnaOprema;
            PrevoznoSredstvo = prevoznoSredstvo;
            PlanPuta = planPuta;
            Vodic = vodic;
            PotrebnaOprema = potrebnaOprema;
            TipKultProg = tipKultProg;
        }
    }

    // === OGRANIČENJA NA NIVOU AKTIVNOSTI ===
    public class AktZdravstvenoOgranicenjeBasic
    {
        public int Id { get; set; }
        public string Ogranicenje { get; set; }

        public AktZdravstvenoOgranicenjeBasic() { }
        public AktZdravstvenoOgranicenjeBasic(int id, string ogranicenje)
        {
            Id = id;
            Ogranicenje = ogranicenje;
        }
    }

    // (korisno za ekrane dodele odgovornih lica)
    public class OdgovornoLiceOsnovneInfo
    {
        public string Jmbg { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string BrojTelefona { get; set; }

        public OdgovornoLiceOsnovneInfo() { }
        public OdgovornoLiceOsnovneInfo(string jmbg, string ime, string prezime, string email, string brojTelefona)
        {
            Jmbg = jmbg;
            Ime = ime;
            Prezime = prezime;
            Email = email;
            BrojTelefona = brojTelefona;
        }
    }
    public class OdgovornoLiceBasic
    {
        public string Jmbg { get; set; } = string.Empty;
        public string Ime { get; set; } = string.Empty;
        public string Prezime { get; set; } = string.Empty;
        public string Pol { get; set; } = string.Empty; // 'M' ili 'Ž'
        public string Adresa { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string BrojTelefona { get; set; } = string.Empty;
        public string StrucnaSprema { get; set; } = string.Empty;

        public OdgovornoLiceBasic() { }

        public OdgovornoLiceBasic(string jmbg, string ime, string prezime, string pol,
                                  string adresa, string email, string brojTelefona, string strucnaSprema)
        {
            Jmbg = jmbg;
            Ime = ime;
            Prezime = prezime;
            Pol = pol;
            Adresa = adresa;
            Email = email;
            BrojTelefona = brojTelefona;
            StrucnaSprema = strucnaSprema;
        }
    }

    // === ULOGE ZA LICE ===
    public class UlogaOdgovornogLicaBasic
    {
        public int Id { get; set; }
        public string Uloga { get; set; } = string.Empty; // nastavnik/animator/trener/zdravstveni_radnik/volonter

        public UlogaOdgovornogLicaBasic() { }
        public UlogaOdgovornogLicaBasic(int id, string uloga)
        {
            Id = id;
            Uloga = uloga;
        }
    }

    public class PrijavaGridInfo
    {
        public int Id { get; set; }
        public string Dete { get; set; } 
        public DateTime Kreirana { get; set; }
        public string Status { get; set; }
        public int BrojAktivnostiUPrijavi { get; set; }

        public PrijavaGridInfo() { }

        public PrijavaGridInfo(int id, string dete, DateTime kreirana, string status, int brojAktivnostiUPrijavi)
        {
            Id = id;
            Dete = dete;
            Kreirana = kreirana;
            Status = status ?? "";
            BrojAktivnostiUPrijavi = brojAktivnostiUPrijavi;
        }
    }

    public class EvidencijaBasic
    {
        public int DeteId { get; set; }
        public string Dete { get; set; }        // Ime Prezime
        public int? PratilacId { get; set; }
        public string Pratilac { get; set; }    // Ime Prezime (može biti "")

        public EvidencijaBasic() { }
        public EvidencijaBasic(int deteId, string dete, int? pratilacId, string pratilac)
        {
            DeteId = deteId;
            Dete = dete;
            PratilacId = pratilacId;
            Pratilac = pratilac ?? "";
        }
    }

    public class PratilacBasic
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Pol { get; set; }
        public string BrojTelefona { get; set; }

        public override string ToString() => $"{Ime} {Prezime}";
    }

}