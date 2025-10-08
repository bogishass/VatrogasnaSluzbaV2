using System.Collections.Generic;

namespace VatrogasnaSluzba.Entiteti
{
    public class Tehnicar : Lice
    {
        // Tehnicar nasledjuje Lice, ne trebaju nam properties Lice i MaticniBroj
        public virtual string Specijalizacija { get; set; } // mehanička/elektronska/zaštitna...
        public virtual IList<string> Alati { get; set; } = new List<string>();
    }
}
