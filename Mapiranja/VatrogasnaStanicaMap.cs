using FluentNHibernate.Mapping;
using VatrogasnaSluzba.Entiteti;

namespace VatrogasnaSluzba.Mapiranja
{
    public class VatrogasnaStanicaMap : ClassMap<VatrogasnaStanica>
    {
        public VatrogasnaStanicaMap()
        {
            Table("VATROGASNA_STANICA");
            Id(x => x.IdStanice).Column("ID_stanice").GeneratedBy.Increment(); // bilo GeneratedBy.Assigned()

            Map(x => x.Naziv).Column("Naziv").Not.Nullable();
            Map(x => x.Adresa).Column("Adresa").Not.Nullable();
            Map(x => x.BrojZaposlenih).Column("Broj_zaposlenih");
            Map(x => x.BrojVozila).Column("Broj_vozila");
            Map(x => x.PovrsinaObjekta).Column("Povrsina_objekta");

            References(x => x.Komandir).Column("Mbr_komandira").Nullable();

            HasMany(x => x.Smene)
                .KeyColumn("ID_stanice")
                .Inverse()
                .Cascade.All();

            HasMany(x => x.Infrastruktura)
                .Table("VATROGASNA_INFRASTRUKTURA")
                .KeyColumn("ID_stanice")
                .Element("Infrastruktura")
                .Cascade.AllDeleteOrphan();
        }
    }
}
