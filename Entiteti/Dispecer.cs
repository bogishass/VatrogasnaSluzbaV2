namespace VatrogasnaSluzba.Entiteti
{
    public class Dispecer : Lice
    {
        public virtual string MaticniBroj { get; set; }
        public virtual Lice Lice { get; set; }
        public virtual string TipKomunikacioneOpreme { get; set; }
        public virtual int? BrojSmenaMesecno { get; set; }
    }
}
