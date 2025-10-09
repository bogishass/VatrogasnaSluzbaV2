using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VatrogasnaSluzba.Entiteti
{
    public class Servis
    {
        public virtual int IdServisa {  get; set; }
        public virtual DateTime? DatumServisa { get; set; }
        public virtual string TipServisa { get; set; }
        public virtual Tehnicar Tehnicar { get; set; }
        public virtual Vozilo Vozilo { get; set; }
    }
}
