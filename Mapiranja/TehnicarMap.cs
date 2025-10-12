using FluentNHibernate.Mapping;
using VatrogasnaSluzba.Entiteti;

namespace VatrogasnaSluzba.Mapiranja
{
    public class TehnicarMap : SubclassMap<Tehnicar>
    {
        public TehnicarMap()
        {
            Table("TEHNICAR");
            KeyColumn("MATICNI_BROJ");

            Map(x => x.Specijalizacija).Column("SPECIJALIZACIJA").Nullable();

            HasMany(x => x.Alati)
                .Table("TEHNICAR_ALAT")
                .KeyColumn("MBR_TEHNICARA")
                .Element("ALAT")
                .Cascade.AllDeleteOrphan();

            HasMany<Servis>(x => x.Servisi)
                .KeyColumn("MBR_TEHNICARA")
                .Cascade.AllDeleteOrphan();
        }
    }
}
