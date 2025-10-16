using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VatrogasnaSluzba.DTO
{
    public class VoziloVolonteraSimpleDTO
    {
        public string RegBroj { get; set; }
        public string Tip { get; set; }
        public string Proizvodjac { get; set; }
        public string VlasnikJMBG { get; set; }

       

        public VoziloVolonteraSimpleDTO() { }
        public VoziloVolonteraSimpleDTO(VoziloVolontera v) 
        {
            RegBroj = v.RegBroj;
            Tip = v.Tip;
            Proizvodjac = v.Proizvodjac;
            VlasnikJMBG = v.Vlasnik.MaticniBroj;

            
        }
    }

    public class VoziloVolonteraDTOManager
    {
        
    }
}
