using FluentNHibernate.Mapping;
using VatrogasnaSluzba.Entiteti;

namespace VatrogasnaSluzba.Mapiranja
{
    public class DispecerMap : SubclassMap<Dispecer>
    {
        public DispecerMap()
        {
            Table("DISPECER");
            KeyColumn("MATICNI_BROJ");

            Map(x => x.TipKomunikacioneOpreme).Column("Tip_komunikacione_opreme");
            Map(x => x.BrojSmenaMesecno).Column("Broj_smena_mesecno");
        }
    }
}
 