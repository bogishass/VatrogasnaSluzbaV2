using System;
using System.Collections.Generic;

namespace VatrogasnaSluzba.Entiteti
{
    public class Vozilo
    {
        public virtual string RegBroj { get; set; }
        public virtual string Tip { get; set; }
        public virtual string Podtip { get; set; }
        public virtual string Proizvodjac { get; set; }
        public virtual int? GodProizvodnje { get; set; }
        public virtual string Status { get; set; }
        public virtual int? Kapacitet { get; set; }
        public virtual DateTime? DatIstekaReg { get; set; }

        public virtual IList<Intervencija> Intervencije { get; set; } = new List<Intervencija>();
        public virtual IList<string> Sertifikati { get; set; } = new List<string>();
    }
}
