using FluentNHibernate.Mapping;
using VatrogasnaSluzba.Entiteti;

namespace VatrogasnaSluzba.Mapiranja
{
    public class VolonterMap : SubclassMap<Volonter>
    {
        public VolonterMap()
        {
            Table("VOLONTER");
            KeyColumn("MATICNI_BROJ");

            HasMany(x => x.Vozila)
                .KeyColumn("Mbr_volontera")
                .Table("VOZILO_VOLONTERA")
                .Cascade.AllDeleteOrphan()
                .Inverse(); // VoziloVolontera.Vlasnik je zaduzen za ovu vezu jer je tamo fk
        }
    }
}
