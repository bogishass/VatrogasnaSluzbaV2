using FluentNHibernate.Mapping;
using VatrogasnaSluzba.Entiteti;

namespace VatrogasnaSluzba.Mapiranja
{
    public class VolonterMap : ClassMap<Volonter>
    {
        public VolonterMap()
        {
            Table("VOLONTER");
            Id(x => x.MaticniBroj).Column("Maticni_broj").GeneratedBy.Assigned();

            Map(x => x.Ime).Column("Ime").Not.Nullable();
            Map(x => x.Prezime).Column("Prezime").Not.Nullable();
            Map(x => x.Pol).Column("Pol").Not.Nullable();
            Map(x => x.DatumRodjenja).Column("Datum_rodjenja").Not.Nullable();
            Map(x => x.Adresa).Column("Adresa").Not.Nullable();
            Map(x => x.Email).Column("Email");

            HasMany(x => x.Telefoni)
                .Table("VOLONTER_TELEFON")
                .KeyColumn("Mbr_volontera")
                .Element("Broj_telefona")
                .Cascade.AllDeleteOrphan();

            HasMany(x => x.Vozila)
                .KeyColumn("Mbr_volontera")
                .Table("VOZILO_VOLONTERA")
                .Cascade.AllDeleteOrphan()
                .Inverse();

            HasManyToMany(x => x.Intervencije)
                .Table("VOLONTERI_U_INTERVENCIJI")
                .ParentKeyColumn("Maticni_broj")
                .ChildKeyColumn("ID_intervencije")
                .Cascade.None();
        }
    }
}
