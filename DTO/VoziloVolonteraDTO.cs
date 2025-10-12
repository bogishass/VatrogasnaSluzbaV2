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

        //public VolonterDTO Vlasnik { get; set; }  // nije neophodno za sad

        public VoziloVolonteraSimpleDTO() { }
        public VoziloVolonteraSimpleDTO(VoziloVolontera v) 
        {
            RegBroj = v.RegBroj;
            Tip = v.Tip;
            Proizvodjac = v.Proizvodjac;
            VlasnikJMBG = v.Vlasnik.MaticniBroj;

            //Vlasnik = new VolonterDTO(v.Vlasnik); // nije neophodno za sad
        }
    }

    public class VoziloVolonteraDTOManager
    {
        //public static List<VoziloVolonteraSimpleDTO> GetVozilaVolonteraSimple(string jmbg)
        //{
        //    VolonterDTO volonter = (VolonterDTO)LiceDTOManager.GetLice(jmbg);
        //    return volonter.Vozila;
        //}
    }
}
