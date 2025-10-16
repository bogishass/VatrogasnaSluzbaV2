namespace VatrogasnaSluzba.Entiteti
{
    public class Vatrogasac : Lice
    {
        public virtual string NivoObucenosti { get; set; } 
        public virtual string FizickaSprema { get; set; }
        public virtual int? BrojSertifikata { get; set; }
    }
}
