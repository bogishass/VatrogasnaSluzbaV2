using FluentNHibernate.Mapping;
using VatrogasnaSluzba.Entiteti;

namespace VatrogasnaSluzba.Mapiranja
{
    public class TehnicarMap : ClassMap<Tehnicar>
    {
        public TehnicarMap()
        {
            Table("TEHNICAR");
            Id(x => x.MaticniBroj).Column("Maticni_broj").GeneratedBy.Assigned();

            HasOne(x => x.Lice).Constrained();

            Map(x => x.Specijalizacija).Column("Specijalizacija");

            HasMany(x => x.Alati)
                .Table("TEHNICAR_ALAT")
                .KeyColumn("Mbr_tehnicara")
                .Element("Alat")
                .Cascade.AllDeleteOrphan();
        }
    }
}
