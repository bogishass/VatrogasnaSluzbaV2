using FluentNHibernate.Mapping;
using VatrogasnaSluzba.Entiteti;

namespace VatrogasnaSluzba.Mapiranja
{
    // subclass umesto class map valjda
    public class VatrogasacMap : SubclassMap<Vatrogasac>
    {
        public VatrogasacMap()
        {

            Table("VATROGASAC");
            //Id(x => x.MaticniBroj).Column("Maticni_broj").GeneratedBy.Assigned();
            //HasOne(x => x.Lice).Constrained();

            KeyColumn("MATICNI_BROJ");

            Map(x => x.NivoObucenosti).Column("NIVO_OBUCENOSTI");
            Map(x => x.FizickaSprema).Column("FIZICKA_SPREMA");
            Map(x => x.BrojSertifikata).Column("BROJ_SERTIFIKATA");
        }
    }
}
