using FluentNHibernate.Mapping;
using VatrogasnaSluzba.Entiteti;

namespace VatrogasnaSluzba.Mapiranja
{
    public class OpremaMap : ClassMap<Oprema>
    {
        public OpremaMap()
        {
            Table("OPREMA");
            Id(x => x.InventarskiBroj).Column("Inventarski_broj").GeneratedBy.Assigned();

            Map(x => x.Naziv).Column("Naziv").Not.Nullable();
            Map(x => x.Tip).Column("Tip").Not.Nullable();
            Map(x => x.Podtip).Column("Podtip").Not.Nullable();
            Map(x => x.LokacijaOpreme).Column("Lokacija_opreme").Not.Nullable();
            Map(x => x.Status).Column("Status").Not.Nullable();
            Map(x => x.DatumNabavke).Column("Datum_nabavke");

            HasManyToMany(x => x.Intervencije)
                .Table("OPREMA_U_INTERVENCIJI")
                .ParentKeyColumn("Inventarski_broj")
                .ChildKeyColumn("ID_intervencije")
                .Cascade.None();
        }
    }
}
