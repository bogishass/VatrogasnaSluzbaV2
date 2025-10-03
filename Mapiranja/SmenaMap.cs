using FluentNHibernate.Mapping;
using VatrogasnaSluzba.Entiteti;

namespace VatrogasnaSluzba.Mapiranja
{
    public class SmenaMap : ClassMap<Smena>
    {
        public SmenaMap()
        {
            Table("SMENA");
            Id(x => x.IdSmene).Column("ID_smene").GeneratedBy.Assigned();

            Map(x => x.Datum).Column("Datum").Not.Nullable();
            Map(x => x.VremePocetka).Column("Vreme_pocetka").Not.Nullable();
            Map(x => x.VremeKraja).Column("Vreme_kraja");
            Map(x => x.BrojIntervencija).Column("Broj_intervencija");

            References(x => x.Stanica).Column("ID_stanice").Not.Nullable();

            HasMany(x => x.Zaposleni)
                .KeyColumn("ID_smene")
                .Inverse()
                .Cascade.None();

            HasManyToMany(x => x.Intervencije)
                .Table("INTERVENCIJA_SMENA")
                .ParentKeyColumn("ID_smene")
                .ChildKeyColumn("ID_intervencije")
                .Cascade.None();
        }
    }
}
