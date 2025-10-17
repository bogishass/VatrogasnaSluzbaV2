using System;
using System.Collections.Generic;

namespace VatrogasnaSluzba.Entiteti
{
    public class Intervencija
    {
        public virtual int IdIntervencije { get; set; }
        public virtual string VrstaIntervencije { get; set; }
        public virtual string AdresaIntervencije { get; set; }
        public virtual DateTime? DatumPocetka { get; set; }
        public virtual DateTime? DatumKraja { get; set; }
        public virtual string OpisSituacije { get; set; }
        public virtual int? BrojVatrogasaca { get; set; }
        public virtual DateTime? VremeDolaska { get; set; }
        public virtual DateTime? DatumPromene { get; set; }
        public virtual string Status { get; set; }
        public virtual IList<Smena> Smene { get; set; } = new List<Smena>();
        public virtual IList<Lice> Lica { get; set; } = new List<Lice>();
        public virtual IList<Vozilo> Vozila { get; set; } = new List<Vozilo>();
        public virtual IList<Oprema> Oprema { get; set; } = new List<Oprema>();
        public virtual IList<VoziloVolontera> VozilaVolontera { get; set; } = new List<VoziloVolontera>();
    }
}
