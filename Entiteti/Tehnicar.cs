using System.Collections.Generic;

namespace VatrogasnaSluzba.Entiteti
{
    public class Tehnicar : Lice
    {
        public virtual string MaticniBroj { get; set; } // shared PK
        public virtual Lice Lice { get; set; }
        public virtual string Specijalizacija { get; set; } // mehanička/elektronska/zaštitna...
        public virtual IList<string> Alati { get; set; } = new List<string>();
    }
}
