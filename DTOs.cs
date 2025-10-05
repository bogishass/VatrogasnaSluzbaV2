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
        public VoziloBasic(string regBroj, string tip, string podtip, 
            string proizvodjac, int godProizvodnje, string status,
            int kapacitet, DateTime datIstekaReg) 
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
}
