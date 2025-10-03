using System;
using System.Collections.Generic;

namespace VatrogasnaSluzba.Entiteti
{
    public class Oprema
    {
        public virtual int InventarskiBroj { get; set; }
        public virtual string Naziv { get; set; }
        public virtual string Tip { get; set; }
        public virtual string Podtip { get; set; }
        public virtual string LokacijaOpreme { get; set; }
        public virtual string Status { get; set; }
        public virtual DateTime? DatumNabavke { get; set; }

        public virtual IList<Intervencija> Intervencije { get; set; } = new List<Intervencija>();
    }
}
