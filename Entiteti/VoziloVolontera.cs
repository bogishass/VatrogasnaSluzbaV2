using System.Collections.Generic;

namespace VatrogasnaSluzba.Entiteti
{
    public class VoziloVolontera
    {
        public virtual string RegBroj { get; set; }
        public virtual string Tip { get; set; }
        public virtual string Marka { get; set; }

        public virtual Volonter Vlasnik { get; set; }
        public virtual IList<Intervencija> Intervencije { get; set; } = new List<Intervencija>();
    }
}
