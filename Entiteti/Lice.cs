using System;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VatrogasnaSluzba.Entiteti
{
    public class Lice
    {
        public virtual string MaticniBroj { get; set; } // CHAR(13)
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual string Pol { get; set; } // 'M' | 'Z'
        public virtual DateTime DatumRodjenja { get; set; }
        public virtual string Adresa { get; set; }
        public virtual string Email { get; set; }
        public virtual DateTime DatPocetkaAngaz { get; set; }
        public virtual string Pozicija { get; set; } // 'Tehnicar' | 'Dispecer' | 'Vatrogasac'

        public virtual Smena Smena { get; set; }

        public virtual Tehnicar Tehnicar { get; set; }
        public virtual Dispecer Dispecer { get; set; }
        public virtual Vatrogasac Vatrogasac { get; set; }

        public virtual IList<string> Telefoni { get; set; } = new List<string>();
        public virtual IList<Intervencija> Intervencije { get; set; } = new List<Intervencija>();
    }
}
