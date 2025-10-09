using FluentNHibernate.Mapping;
using VatrogasnaSluzba.Entiteti;

namespace VatrogasnaSluzba.Mapiranja
{
    // abstract sjebe konekciju
    public class LiceMap : ClassMap<Lice>
    {
        public LiceMap()
        {
            Table("LICE");

            Id(x => x.MaticniBroj).Column("MATICNI_BROJ").GeneratedBy.Assigned();

            Map(x => x.Ime).Column("IME").Not.Nullable().Length(50);
            Map(x => x.Prezime).Column("PREZIME").Not.Nullable().Length(50);
            Map(x => x.Pol).Column("POL").Not.Nullable().Length(1);
            Map(x => x.DatumRodjenja).Column("DATUM_RODJENJA").Not.Nullable();
            Map(x => x.Adresa).Column("ADRESA").Not.Nullable().Length(200);
            Map(x => x.Email).Column("EMAIL").Nullable().Length(100);
            Map(x => x.DatPocetkaAngaz).Column("DAT_POCETKA_ANGAZ").Nullable();
            Map(x => x.Pozicija).Column("POZICIJA").Not.Nullable().Length(20);

            References(x => x.Smena).Column("ID_SMENE").Nullable();

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