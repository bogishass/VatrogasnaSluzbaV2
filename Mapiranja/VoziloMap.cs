using FluentNHibernate.Mapping;
using VatrogasnaSluzba.Entiteti;

namespace VatrogasnaSluzba.Mapiranja
{
    public class VoziloMap : ClassMap<Vozilo>
    {
        public VoziloMap()
        {
            Table("VOZILO");
            Id(x => x.RegBroj).Column("Reg_broj").GeneratedBy.Assigned();

            Map(x => x.Tip).Column("Tip").Not.Nullable();
            Map(x => x.Podtip).Column("Podtip").Not.Nullable();
            Map(x => x.Proizvodjac).Column("Proizvodjac");
            Map(x => x.GodProizvodnje).Column("God_proizvodnje");
            Map(x => x.Status).Column("Status").Not.Nullable();
            Map(x => x.Kapacitet).Column("Kapacitet");
            Map(x => x.DatIstekaReg).Column("Dat_isteka_reg");

            HasManyToMany(x => x.Intervencije)
                .Table("VOZILA_U_INTERVENCIJI")
                .ParentKeyColumn("Reg_broj")
                .ChildKeyColumn("ID_intervencije")
                .Cascade.None();

            HasMany(x => x.Sertifikati)
                .Table("Vozilo_sertifikat")
                .KeyColumn("Reg_broj")
                .Element("Sertifikat")
                .Cascade.AllDeleteOrphan();
        }
    }
}
