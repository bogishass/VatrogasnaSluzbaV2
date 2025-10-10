using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VatrogasnaSluzba
{
    public class VoziloBasic
    {
        public string RegBroj { get; set; }
        public string Tip { get; set; }
        public string Podtip { get; set; }
        public string Proizvodjac { get; set; }
        public int? GodProizvodnje { get; set; }
        public string Status { get; set; }
        public int? Kapacitet { get; set; }
        public DateTime? DatIstekaReg { get; set; }
        public VoziloBasic(string regBroj, string tip, string podtip, string proizvodjac, int godProizvodnje, string status, int kapacitet, DateTime datIstekaReg) 
        {
            RegBroj = regBroj;
            Tip = tip;
            Podtip = podtip;
            Proizvodjac = proizvodjac;
            GodProizvodnje = godProizvodnje;
            Status = status;
            Kapacitet = kapacitet;
            DatIstekaReg = datIstekaReg;
        }
    }

    public class VoziloVolonteraBasic
    {
        public string RegBroj { get; set; }
        public string Tip { get; set; }
        public string Marka { get; set; }

        public VoziloVolonteraBasic(string regBroj, string tip, string marka)
        {
            RegBroj = regBroj;
            Tip = tip;
            Marka = marka;
        }
    }

    public class LiceBasic
    {
        public string MaticniBroj { get; set; }
        public string Ime { get; set; }
        public  string Prezime { get; set; }
        public  string Pol { get; set; }
        public  DateTime DatumRodjenja { get; set; }
        public  string Adresa { get; set; }
        public  string Email { get; set; }
        public  IList<string> Telefoni { get; set; } = new List<string>(); // valjda treba?

        public LiceBasic(string maticniBroj, string ime, string prezime, string pol, DateTime datumRodjenja, string adresa, string email, IList<string> telefoni)
        {
            MaticniBroj = maticniBroj;
            Ime = ime;
            Prezime = prezime;
            Pol = pol;
            DatumRodjenja = datumRodjenja;
            Adresa = adresa;
            Email = email;
            Telefoni = telefoni;
        }
        
    }
}


namespace VatrogasnaSluzba
{
    // Opciono: baza (slobodno obriši ako ti ne treba)
    //public abstract class BaseDTO { }

    public class LiceDTO// : BaseDTO
    {
        public string MaticniBroj { get; set; } = string.Empty;   // CHAR(13)
        public string Ime { get; set; } = string.Empty;
        public string Prezime { get; set; } = string.Empty;
        public string Pol { get; set; } = string.Empty;           // 'M' | 'Z'
        public DateTime DatumRodjenja { get; set; }
        public string Adresa { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime? DatPocetkaAngaz { get; set; }
        public string Pozicija { get; set; } = string.Empty;      // 'Tehnicar' | 'Dispecer' | 'Vatrogasac'
        // Izostavljeno: Stanica, Telefoni, Intervencije (veze/kolekcije)
    }

    public class TehnicarDTO// : LiceDTO
    {
        public string Specijalizacija { get; set; } = string.Empty;
        // Izostavljeno: Alati (kolekcija)
    }

    public class VatrogasacDTO// : LiceDTO
    {
        public string NivoObucenosti { get; set; } = string.Empty; // Osnovni/Srednji/Specijalni
        public string FizickaSprema { get; set; } = string.Empty;
        public int? BrojSertifikata { get; set; }
    }

    public class DispecerDTO// : LiceDTO
    {
        public string TipKomunikacioneOpreme { get; set; } = string.Empty;
        public int? BrojSmenaMesecno { get; set; }
    }

    public class VolonterDTO : LiceDTO
    {
        // Nema dodatnih scalar svojstava
        // Izostavljeno: Vozila (kolekcija)
    }

    public class VoziloDTO// : BaseDTO
    {
        public string RegBroj { get; set; } = string.Empty;
        public string Tip { get; set; } = string.Empty;
        public string Podtip { get; set; } = string.Empty;
        public string Proizvodjac { get; set; } = string.Empty;
        public int? GodProizvodnje { get; set; }
        public string Status { get; set; } = string.Empty;
        public int? Kapacitet { get; set; }
        public DateTime? DatIstekaReg { get; set; }
        // Izostavljeno: Intervencije, Sertifikati (kolekcije)
    }

    public class VoziloVolonteraDTO// : BaseDTO
    {
        public string RegBroj { get; set; } = string.Empty;
        public string Tip { get; set; } = string.Empty;
        public string Marka { get; set; } = string.Empty;
        // Izostavljeno: Vlasnik (Volonter), Intervencije
    }

    // =========================
    // SERVIS
    // =========================
    public class ServisDTO// : BaseDTO
    {
        public int IdServisa { get; set; }
        public DateTime? DatumServisa { get; set; }
        public string TipServisa { get; set; } = string.Empty;
        // Izostavljeno: Tehnicar, Vozilo (navigacione veze)
        // (Ako bude trebalo: npr. public string? MbrTehnicara { get; set; }, public string? RegBrojVozila { get; set; })
    }

    public class OpremaDTO// : BaseDTO
    {
        public int InventarskiBroj { get; set; }
        public string Naziv { get; set; } = string.Empty;
        public string Tip { get; set; } = string.Empty;
        public string Podtip { get; set; } = string.Empty;
        public string LokacijaOpreme { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public DateTime? DatumNabavke { get; set; }
        // Izostavljeno: Intervencije (kolekcija)
    }

    public class VatrogasnaStanicaDTO// : BaseDTO
    {
        public int IdStanice { get; set; }
        public string Naziv { get; set; } = string.Empty;
        public string Adresa { get; set; } = string.Empty;
        public int? BrojZaposlenih { get; set; }
        public int? BrojVozila { get; set; }
        public string DostupnaInfrastruktura { get; set; } = string.Empty;
        public double? PovrsinaObjekta { get; set; }
        // Izostavljeno: Komandir (veza na Lice), Smene (kolekcija), Infrastruktura (lista)
    }

    public class IntervencijaDTO// : BaseDTO
    {
        public int IdIntervencije { get; set; }
        public string VrstaIntervencije { get; set; } = string.Empty;
        public string AdresaIntervencije { get; set; } = string.Empty;
        public DateTime? DatumPocetka { get; set; }
        public DateTime? DatumKraja { get; set; }
        public string OpisSituacije { get; set; } = string.Empty;
        public int? BrojVatrogasaca { get; set; }
        public DateTime? VremeDolaska { get; set; }
        public DateTime? DatumPromene { get; set; }
        public string Status { get; set; } = string.Empty;
        // Izostavljeno: Smene, Lica, Vozila, Oprema, Volonteri, VozilaVolontera (kolekcije/veze)
    }

    public class SmenaDTO// : BaseDTO
    {
        public int IdSmene { get; set; }
        public DateTime Datum { get; set; }            // nije nullable
        public DateTime VremePocetka { get; set; }     // nije nullable
        public DateTime? VremeKraja { get; set; }
        public int? BrojIntervencija { get; set; }
        // Izostavljeno: Stanica, Lice, Intervencije (veze/kolekcije)
    }
}

