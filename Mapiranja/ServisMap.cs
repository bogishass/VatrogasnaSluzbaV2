using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VatrogasnaSluzba.Mapiranja
{
    public class ServisMap : ClassMap<Servis>
    {
        public ServisMap()
        {
            Table("SERVIS");
            Id(x => x.IdServisa).Column("ID_SERVISA").GeneratedBy.Increment(); // bilo GeneratedBy.Assigned()

            Map(x => x.DatumServisa).Column("DATUM_SERVISA");
            Map(x => x.TipServisa).Column("TIP_SERVISA").Not.Nullable();

            References(x => x.Vozilo).Column("REG_BROJ_VOZILA").Nullable();
            References(x => x.Tehnicar).Column("MBR_TEHNICARA").Nullable();
        }
    }
}