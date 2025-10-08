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

    public class VolonterBasic
    {
        public string MaticniBroj { get; set; }
        public string Ime { get; set; }
        public  string Prezime { get; set; }
        public  string Pol { get; set; }
        public  DateTime DatumRodjenja { get; set; }
        public  string Adresa { get; set; }
        public  string Email { get; set; }
        public  IList<string> Telefoni { get; set; } = new List<string>();

        public VolonterBasic(string maticniBroj, string ime, string prezime, string pol, DateTime datumRodjenja, string adresa, string email, IList<string> telefoni)
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
