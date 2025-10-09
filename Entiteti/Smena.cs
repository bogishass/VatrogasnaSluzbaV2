using System;
using System.Collections.Generic;

namespace VatrogasnaSluzba.Entiteti
{
    public class Smena
    {
        public virtual int IdSmene { get; set; }
        public virtual DateTime Datum { get; set; }
        public virtual DateTime VremePocetka { get; set; }
        public virtual DateTime? VremeKraja { get; set; }
        public virtual int? BrojIntervencija { get; set; }

        public virtual VatrogasnaStanica Stanica { get; set; }
        public virtual IList<Lice> Lice { get; set; } = new List<Lice>();
        public virtual IList<Intervencija> Intervencije { get; set; } = new List<Intervencija>();
    }
}
