namespace VatrogasnaSluzba.Entiteti
{
    public class Vatrogasac
    {
        public virtual string MaticniBroj { get; set; }
        public virtual Lice Lice { get; set; }
        public virtual string NivoObucenosti { get; set; } // Osnovni/Srednji/Specijalni
        public virtual string FizickaSprema { get; set; }
        public virtual int? BrojSertifikata { get; set; }
    }
}
