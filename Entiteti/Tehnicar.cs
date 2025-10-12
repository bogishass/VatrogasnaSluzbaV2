using System.Collections.Generic;

namespace VatrogasnaSluzba.Entiteti
{
    public class Tehnicar : Lice
    {
        // Tehnicar nasledjuje Zaposlenog, ne trebaju nam properties Zaposleni i MaticniBroj
        public virtual string Specijalizacija { get; set; } // mehanička/elektronska/zaštitna...
        public virtual IList<string> Alati { get; set; } = new List<string>();
        public virtual IList<Servis> Servisi { get; set; } = new List<Servis>();
    }
}
