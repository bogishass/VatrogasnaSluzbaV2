using FluentNHibernate.Mapping;
using VatrogasnaSluzba.Entiteti;

namespace VatrogasnaSluzba.Mapiranja
{
    public class SmenaMap : ClassMap<Smena>
    {
        public SmenaMap()
        {
            Table("SMENA");

            Id(x => x.IdSmene)
                .Column("ID_smene")
                // .GeneratedBy.Assigned() // samo ako ručno dodeljuješ
                .GeneratedBy.SequenceIdentity("SMENA_SEQ"); // prilagodi generator

            Map(x => x.Datum).Column("DATUM").Not.Nullable();
            Map(x => x.VremePocetka).Column("VREME_POCETKA").Not.Nullable();
            Map(x => x.VremeKraja).Column("VREME_KRAJA").Nullable();
            Map(x => x.BrojIntervencija).Column("BROJ_INTERVENCIJA").Nullable();

            References(x => x.Stanica)
                .Column("ID_stanice")
                .Not.Nullable()
                .Cascade.None();

            // M:N sa LICE preko LICE_U_SMENI
            HasManyToMany(x => x.Lica)
                .Table("LICE_U_SMENI")
                .ParentKeyColumn("ID_smene")
                .ChildKeyColumn("JMBG")
                .Cascade.None()
                .AsBag()
                .LazyLoad();

            // M:N sa INTERVENCIJA preko INTERVENCIJA_SMENA
            HasManyToMany(x => x.Intervencije)
                .Table("INTERVENCIJA_SMENA")
                .ParentKeyColumn("ID_smene")
                .ChildKeyColumn("ID_intervencije")
                .Cascade.SaveUpdate()  // ili .All()
                .AsBag()
                .LazyLoad()
                .Inverse(); // ako druga strana nije inverse
        }
    }
}

