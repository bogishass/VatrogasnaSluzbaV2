using FluentNHibernate.Data;
using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using VatrogasnaSluzba.Entiteti;

namespace VatrogasnaSluzba.DTO
{
    public class IntervencijaDTO
    {
        public int IdIntervencije { get; set; }
        public string VrstaIntervencije { get; set; }
        public string AdresaIntervencije { get; set; }
        public DateTime? DatumPocetka { get; set; }
        public DateTime? DatumKraja { get; set; }
        public string OpisSituacije { get; set; }
        public int? BrojVatrogasaca { get; set; }
        public DateTime? VremeDolaska { get; set; }
        public DateTime? DatumPromene { get; set; }
        public string Status { get; set; }

        public List<LiceDTO> Lica { get; set; } = new();
        public List<VoziloDTO> Vozila { get; set; } = new();
        public List<OpremaDTO> Oprema { get; set; } = new();
        public List<VoziloVolonteraSimpleDTO> VozilaVolontera { get; set; } = new();

        public IntervencijaDTO() { }

        public IntervencijaDTO(Intervencija i)
        {
            IdIntervencije = i.IdIntervencije;
            VrstaIntervencije = i.VrstaIntervencije;
            AdresaIntervencije = i.AdresaIntervencije;
            DatumPocetka = i.DatumPocetka;
            DatumKraja = i.DatumKraja;
            OpisSituacije = i.OpisSituacije;
            BrojVatrogasaca = i.BrojVatrogasaca;
            VremeDolaska = i.VremeDolaska;
            DatumPromene = i.DatumPromene;
            Status = i.Status;

            if (i.Lica != null)
                Lica = i.Lica.Select(LiceDTOManager.Create).ToList();

            if (i.Vozila != null)
                Vozila = i.Vozila.Select(v => new VoziloDTO(v)).ToList();

            if (i.Oprema != null)
                Oprema = i.Oprema.Select(o => new OpremaDTO(o)).ToList();

            if (i.VozilaVolontera != null)
                VozilaVolontera = i.VozilaVolontera.Select(v => new VoziloVolonteraSimpleDTO(v)).ToList();
        }
    }

    public class IntervencijaListDTO
    {
        [DisplayName("ID")]
        public int IdIntervencije { get; set; }

        [DisplayName("Vrsta intervencije")]
        public string VrstaIntervencije { get; set; }

        [DisplayName("Adresa")]
        public string AdresaIntervencije { get; set; }

        [DisplayName("Početak")]
        public DateTime? DatumPocetka { get; set; }

        [DisplayName("Kraj")]
        public DateTime? DatumKraja { get; set; }

        [DisplayName("Status")]
        public string Status { get; set; }

        public IntervencijaListDTO() { }

        public IntervencijaListDTO(Intervencija i)
        {
            IdIntervencije = i.IdIntervencije;
            VrstaIntervencije = i.VrstaIntervencije;
            AdresaIntervencije = i.AdresaIntervencije;
            DatumPocetka = i.DatumPocetka;
            DatumKraja = i.DatumKraja;
            Status = i.Status;
        }
    }
    
    public static class IntervencijaDTOManager
    {
        public static IntervencijaDTO Create(Intervencija i) => new IntervencijaDTO(i);

        public static bool AddIntervencija(IntervencijaDTO dto)
        {
            try
            {
                using ISession s = DataLayer.GetSession();
                using ITransaction tx = s.BeginTransaction();

                var entity = new Intervencija
                {
                    VrstaIntervencije = dto.VrstaIntervencije,
                    AdresaIntervencije = dto.AdresaIntervencije,
                    DatumPocetka = dto.DatumPocetka,
                    DatumKraja = dto.DatumKraja,
                    OpisSituacije = dto.OpisSituacije,
                    BrojVatrogasaca = dto.BrojVatrogasaca,
                    VremeDolaska = dto.VremeDolaska,
                    DatumPromene = dto.DatumPromene,
                    Status = dto.Status
                };

                if (dto.Lica != null && dto.Lica.Count > 0)
                {
                    foreach (var liceDto in dto.Lica)
                    {
                        var lice = s.Get<Lice>(liceDto.MaticniBroj);
                        if (lice != null)
                            entity.Lica.Add(lice);
                    }
                }

                if (dto.Vozila != null && dto.Vozila.Count > 0)
                {
                    foreach (var voz in dto.Vozila)
                    {
                        var v = s.Get<Vozilo>(voz.RegBroj);
                        if (v != null)
                            entity.Vozila.Add(v);
                    }
                }

                if (dto.Oprema != null && dto.Oprema.Count > 0)
                {
                    foreach (var op in dto.Oprema)
                    {
                        var o = s.Get<Oprema>(op.InventarskiBroj);
                        if (o != null)
                            entity.Oprema.Add(o);
                    }
                }

                if (dto.VozilaVolontera != null && dto.VozilaVolontera.Count > 0)
                {
                    foreach (var voz in dto.VozilaVolontera)
                    {
                        var v = s.Get<VoziloVolontera>(voz.RegBroj);
                        if (v != null)
                            entity.VozilaVolontera.Add(v);
                    }
                }

                s.Save(entity);
                tx.Commit();

                dto.IdIntervencije = entity.IdIntervencije;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("AddIntervencija: " + ex.Message);
                return false;
            }
        }

        public static bool UpdateIntervencija(IntervencijaDTO dto)
        {
            try
            {
                using ISession s = DataLayer.GetSession();
                using ITransaction tx = s.BeginTransaction();

                var ent = s.Get<Intervencija>(dto.IdIntervencije);
                if (ent == null)
                {
                    MessageBox.Show("Intervencija nije pronađena u bazi.");
                    return false;
                }

                ent.VrstaIntervencije = dto.VrstaIntervencije;
                ent.AdresaIntervencije = dto.AdresaIntervencije;
                ent.DatumPocetka = dto.DatumPocetka;
                ent.DatumKraja = dto.DatumKraja;
                ent.OpisSituacije = dto.OpisSituacije;
                ent.BrojVatrogasaca = dto.BrojVatrogasaca;
                ent.VremeDolaska = dto.VremeDolaska;
                ent.DatumPromene = dto.DatumPromene;
                ent.Status = dto.Status;

                ent.Lica.Clear();
                ent.Vozila.Clear();
                ent.Oprema.Clear();
                ent.VozilaVolontera.Clear();

                if (dto.Lica != null)
                {
                    foreach (var liceDto in dto.Lica)
                    {
                        var lice = s.Get<Lice>(liceDto.MaticniBroj);
                        if (lice != null)
                            ent.Lica.Add(lice);
                    }
                }

                if (dto.Vozila != null)
                {
                    foreach (var voz in dto.Vozila)
                    {
                        var v = s.Get<Vozilo>(voz.RegBroj);
                        if (v != null)
                            ent.Vozila.Add(v);
                    }
                }

                if (dto.Oprema != null)
                {
                    foreach (var op in dto.Oprema)
                    {
                        var o = s.Get<Oprema>(op.InventarskiBroj);
                        if (o != null)
                            ent.Oprema.Add(o);
                    }
                }

                if (dto.VozilaVolontera != null && dto.VozilaVolontera.Count > 0)
                {
                    foreach (var voz in dto.VozilaVolontera)
                    {
                        var v = s.Get<VoziloVolontera>(voz.RegBroj);
                        if (v != null)
                            ent.VozilaVolontera.Add(v);
                    }
                }

                s.Update(ent);
                tx.Commit();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("UpdateIntervencija: " + ex.Message);
                return false;
            }
        }

        public static bool DeleteIntervencija(int id)
        {
            try
            {
                using ISession s = DataLayer.GetSession();
                using ITransaction tx = s.BeginTransaction();

                var ent = s.Get<Intervencija>(id);
                if (ent == null)
                {
                    MessageBox.Show("Intervencija nije pronađena.");
                    return false;
                }

                //MessageBox.Show($"{id} {ent.VrstaIntervencije}");

                s.Delete(ent);
                tx.Commit();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("DeleteIntervencija: " + ex.Message);
                return false;
            }
        }

        public static List<IntervencijaDTO> GetSveIntervencije()
        {
            try
            {
                using ISession s = DataLayer.GetSession();
                var q = s.Query<Intervencija>();
                return q.Select(Create).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("GetSveIntervencije: " + ex.Message);
                return new List<IntervencijaDTO>();
            }
        }

        public static List<IntervencijaListDTO> GetSveIntervencijeList()
        {
            try
            {
                using ISession s = DataLayer.GetSession();
                var q = s.Query<Intervencija>();
                return q.Select(i => new IntervencijaListDTO(i)).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("GetSveIntervencijeList: " + ex.Message);
                return new List<IntervencijaListDTO>();
            }
        }

        public static IntervencijaDTO GetIntervencija(int id)
        {
            try
            {
                using ISession s = DataLayer.GetSession();
                var ent = s.Get<Intervencija>(id);
                return ent == null ? null : Create(ent);
            }
            catch (Exception ex)
            {
                MessageBox.Show("GetIntervencija: " + ex.Message);
                return null;
            }
        }
    }
}
