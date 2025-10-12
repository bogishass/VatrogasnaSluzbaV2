using FluentNHibernate.Mapping;
using VatrogasnaSluzba.Entiteti;

namespace VatrogasnaSluzba.Mapiranja
{
    public class VoziloVolonteraMap : ClassMap<VoziloVolontera>
    {
        public VoziloVolonteraMap()
        {
            Table("VOZILO_VOLONTERA");
            Id(x => x.RegBroj).Column("Reg_broj").GeneratedBy.Assigned();
            Map(x => x.Tip).Column("Tip");
            Map(x => x.Proizvodjac).Column("Proizvodjac");

            References(x => x.Vlasnik).Column("Mbr_volontera").Not.Nullable();

            HasManyToMany(x => x.Intervencije)
                .Table("VOZILA_VOL_U_INTERVENCIJI")
                .ParentKeyColumn("Reg_broj")
                .ChildKeyColumn("ID_intervencije")
                .Cascade.None();
        }
    }
}
