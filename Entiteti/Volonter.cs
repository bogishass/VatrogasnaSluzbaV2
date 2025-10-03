using System;
using System.Collections.Generic;

namespace VatrogasnaSluzba.Entiteti
{
    public class Volonter
    {
        public virtual string MaticniBroj { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual string Pol { get; set; }
        public virtual DateTime DatumRodjenja { get; set; }
        public virtual string Adresa { get; set; }
        public virtual string Email { get; set; }

        public virtual IList<string> Telefoni { get; set; } = new List<string>();
        public virtual IList<VoziloVolontera> Vozila { get; set; } = new List<VoziloVolontera>();
        public virtual IList<Intervencija> Intervencije { get; set; } = new List<Intervencija>();
    }
}
