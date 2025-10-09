using System;
using System.Collections.Generic;

namespace VatrogasnaSluzba.Entiteti
{
    public class Volonter : Lice
    {
        public virtual IList<VoziloVolontera> Vozila { get; set; } = new List<VoziloVolontera>();
    }
}
