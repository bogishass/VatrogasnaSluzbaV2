using FluentNHibernate.Mapping;
using VatrogasnaSluzba.Entiteti;

namespace VatrogasnaSluzba.Mapiranja
{
    public class VatrogasacMap : ClassMap<Vatrogasac>
    {
        public VatrogasacMap()
        {
            Table("VATROGASAC");
            Id(x => x.MaticniBroj).Column("Maticni_broj").GeneratedBy.Assigned();
            HasOne(x => x.Lice).Constrained();

            Map(x => x.NivoObucenosti).Column("Nivo_obucenosti");
            Map(x => x.FizickaSprema).Column("Fizicka_sprema");
            Map(x => x.BrojSertifikata).Column("Broj_sertifikata");
        }
    }
}
