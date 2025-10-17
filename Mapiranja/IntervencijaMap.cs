using FluentNHibernate.Mapping;
using VatrogasnaSluzba.Entiteti;

namespace VatrogasnaSluzba.Mapiranja
{
    public class IntervencijaMap : ClassMap<Intervencija>
    {
        public IntervencijaMap()
        {
            Table("INTERVENCIJA");
            Id(x => x.IdIntervencije).Column("ID_intervencije").GeneratedBy.Increment(); 

            Map(x => x.VrstaIntervencije).Column("Vrsta_intervencije");
            Map(x => x.AdresaIntervencije).Column("Adresa_intervencije");
            Map(x => x.DatumPocetka).Column("Datum_pocetka");
            Map(x => x.DatumKraja).Column("Datum_kraja");
            Map(x => x.OpisSituacije).Column("Opis_situacije").Not.Nullable();
            Map(x => x.BrojVatrogasaca).Column("Broj_vatrogasaca");
            Map(x => x.VremeDolaska).Column("Vreme_dolaska");
            Map(x => x.DatumPromene).Column("Datum_promene");
            Map(x => x.Status).Column("Status");

            HasManyToMany(x => x.Smene)
                .Table("INTERVENCIJA_SMENA")
                .ParentKeyColumn("ID_intervencije")
                .ChildKeyColumn("ID_smene")
                .Cascade.None();

            HasManyToMany(x => x.Lica)
                .Table("LICE_U_INTERVENCIJI")
                .ParentKeyColumn("ID_intervencije")
                .ChildKeyColumn("Maticni_broj")
                .Cascade.None();

            HasManyToMany(x => x.Vozila)
                .Table("VOZILA_U_INTERVENCIJI")
                .ParentKeyColumn("ID_intervencije")
                .ChildKeyColumn("Reg_broj")
                .Cascade.None();

            HasManyToMany(x => x.Oprema)
                .Table("OPREMA_U_INTERVENCIJI")
                .ParentKeyColumn("ID_intervencije")
                .ChildKeyColumn("Inventarski_broj")
                .Cascade.None();

            HasManyToMany(x => x.VozilaVolontera)
                .Table("VOZILA_VOL_U_INTERVENCIJI")
                .ParentKeyColumn("ID_intervencije")
                .ChildKeyColumn("Reg_broj")
                .Cascade.None();
        }
    }
}
