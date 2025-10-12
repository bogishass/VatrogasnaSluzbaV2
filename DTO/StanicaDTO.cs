using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VatrogasnaSluzba.DTO
{
    //public class StanicaDTO
    //{
    //    public int IdStanice { get; set; }
    //    public string Naziv { get; set; }
    //    public string Adresa { get; set; }
    //    public int? BrojZaposlenih { get; set; }
    //    public int? BrojVozila { get; set; }
    //    public string DostupnaInfrastruktura { get; set; }
    //    public double? PovrsinaObjekta { get; set; }

    //    public virtual LiceDTO Komandir { get; set; }

    //    //public virtual List<SmenaDTO> Smene { get; set; } = new(); // jos nema SmenaDTO
    //    public virtual List<string> Infrastruktura { get; set; } = new();
    //}

    public class StanicaSimpleDTO
    {
        public int IdStanice { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public int? BrojZaposlenih { get; set; }
        public int? BrojVozila { get; set; }

        public StanicaSimpleDTO(VatrogasnaStanica s)
        {
            IdStanice = s.IdStanice;
            Naziv = s.Naziv;
            Adresa = s.Adresa;
            BrojZaposlenih = s.BrojZaposlenih;
            BrojVozila = s.BrojVozila;
        }
    }

    public static class StanicaDTOManager
    {
        public static List<StanicaSimpleDTO> GetSveStaniceSimple() // mozda try catch
        {
            using ISession session = DataLayer.GetSession();
            return session.Query<VatrogasnaStanica>()
                            .Select(o => new StanicaSimpleDTO(o))
                            .ToList();
        }
    }
}
