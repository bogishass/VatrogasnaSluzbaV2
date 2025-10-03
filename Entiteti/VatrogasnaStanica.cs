using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VatrogasnaSluzba.Entiteti
{
    public class VatrogasnaStanica
    {
        public virtual int IdStanice { get; set; }
        public virtual string Naziv { get; set; }
        public virtual string Adresa { get; set; }
        public virtual int? BrojZaposlenih { get; set; }
        public virtual int? BrojVozila { get; set; }
        public virtual string DostupnaInfrastruktura { get; set; }
        public virtual double? PovrsinaObjekta { get; set; }

        public virtual Lice Komandir { get; set; }

        public virtual IList<Smena> Smene { get; set; } = new List<Smena>();
        public virtual IList<string> Infrastruktura { get; set; } = new List<string>();
    }
}