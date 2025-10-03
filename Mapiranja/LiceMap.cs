using FluentNHibernate.Mapping;
using VatrogasnaSluzba.Entiteti;

namespace VatrogasnaSluzba.Mapiranja
{
    public class LiceMap : ClassMap<Lice>
    {
        public LiceMap()
        {
            Table("LICE");

            // Primary key
            Id(x => x.MaticniBroj)
                .Column("MATICNI_BROJ")
                .GeneratedBy.Assigned()
                .Length(13);

            // Basic properties
            Map(x => x.Ime)
                .Column("IME")
                .Not.Nullable()
                .Length(50);

            Map(x => x.Prezime)
                .Column("PREZIME")
                .Not.Nullable()
                .Length(50);

            Map(x => x.Pol)
                .Column("POL")
                .Not.Nullable()
                .Length(1);

            Map(x => x.DatumRodjenja)
                .Column("DATUM_RODJENJA")
                .Not.Nullable();

            Map(x => x.Adresa)
                .Column("ADRESA")
                .Not.Nullable()
                .Length(200);

            Map(x => x.Email)
                .Column("EMAIL")
                .Nullable()
                .Length(100);

            Map(x => x.DatPocetkaAngaz)
                .Column("DAT_POCETKA_ANGAZ")
                .Nullable();

            Map(x => x.Pozicija)
                .Column("POZICIJA")
                .Nullable()
                .Length(50);

            // Uncomment these when you have the corresponding mapping classes

            References(x => x.Smena)
                .Column("ID_SMENE")
                .Nullable();

            HasOne(x => x.Tehnicar)
                .PropertyRef(t => t.Lice)
                .Cascade.All();

            HasOne(x => x.Dispecer)
                .PropertyRef(d => d.Lice)
                .Cascade.All();

            HasOne(x => x.Vatrogasac)
                .PropertyRef(v => v.Lice)
                .Cascade.All();

            HasMany(x => x.Telefoni)
                .Table("LICE_TELEFON")
                .KeyColumn("MBR_LICA")
                .Element("BROJ_TELEFONA")
                .Cascade.AllDeleteOrphan();

            HasManyToMany(x => x.Intervencije)
                .Table("ZAPOSLENI_U_INTERVENCIJI")
                .ParentKeyColumn("MATICNI_BROJ")
                .ChildKeyColumn("ID_INTERVENCIJE")
                .Cascade.None();

        }
    }
}