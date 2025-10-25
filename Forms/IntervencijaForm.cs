using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VatrogasnaSluzba.DTO;

namespace VatrogasnaSluzba.Forms
{
    public partial class IntervencijaForm : Form
    {
        private readonly BindingList<IntervencijaListDTO> _model = new();
        private bool _editMode = false;
        private int _editingId = 0;

        private List<LiceDTO> selectedLica = new();
        private List<VoziloDTO> selectedVozila = new();
        private List<OpremaDTO> selectedOprema = new();
        private List<VoziloVolonteraSimpleDTO> selectedVozilaVol = new();

        private List<LiceDTO> tempLica = new();
        private List<VoziloDTO> tempVozila = new();
        private List<OpremaDTO> tempOprema = new();
        private List<VoziloVolonteraSimpleDTO> tempVozilaVol = new();

        public IntervencijaForm()
        {
            InitializeComponent();

            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.DataSource = _model;

            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;

            PrepareNullableDtp(dateTimePickerDatumPocetka);
            PrepareNullableDtp(dateTimePickerDatumKraj);
            PrepareNullableDtp(dateTimePickerVremeDolaska);
            PrepareNullableDtp(dateTimePickerVremePromena);

            comboStatus.Items.AddRange(new[] { "U toku", "Završena", "Odložena" });

            SetEditMode(false);

            buttonDodajIntervenciju.Click += buttonDodajIntervenciju_Click;
            buttonObrisiIntervenciju.Click += buttonObrisiIntervenciju_Click;
            buttonIzmeniIntervenciju.Click += buttonIzmeniIntervenciju_Click;
            buttonSacuvaj.Click += buttonSacuvaj_Click;
            buttonOtkazi.Click += buttonOtkazi_Click;

            btnResursi.Click += btnResursi_Click;

            this.Load += IntervencijaForm_Load;
        }

        private void dataGridView1_SelectionChanged(object? sender, EventArgs e)
        {
            if (_editMode) return;

            var row = GetSelectedRow();
            if (row == null) return;

            var full = IntervencijaDTOManager.GetIntervencija(row.IdIntervencije);
            if (full == null) return;

            FillForm(full);

            selectedLica = new List<LiceDTO>(full.Lica);
            selectedVozila = new List<VoziloDTO>(full.Vozila);
            selectedOprema = new List<OpremaDTO>(full.Oprema);
            selectedVozilaVol = new List<VoziloVolonteraSimpleDTO>(full.VozilaVolontera);
        }

        private void IntervencijaForm_Load(object sender, EventArgs e) => RefreshData();

        private void RefreshData()
        {
            _model.Clear();
            var data = IntervencijaDTOManager.GetSveIntervencijeList();
            foreach (var it in data) _model.Add(it);
        }

        private void buttonDodajIntervenciju_Click(object? sender, EventArgs e)
        {
            var dto = ReadDtoFromForm();
            if (dto == null) return;

            if (IntervencijaDTOManager.AddIntervencija(dto))
            {
                RefreshData();
                ClearForm();
            }
        }

        private void buttonObrisiIntervenciju_Click(object? sender, EventArgs e)
        {
            var row = GetSelectedRow();
            if (row == null) { MessageBox.Show("Selektuj intervenciju u tabeli."); return; }

            if (MessageBox.Show("Obrisati izabranu intervenciju?", "Potvrda",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (IntervencijaDTOManager.DeleteIntervencija(row.IdIntervencije))
                {
                    RefreshData();
                    if (_editMode) CancelEdit();
                }
            }
        }

        private void buttonIzmeniIntervenciju_Click(object? sender, EventArgs e)
        {
            var row = GetSelectedRow();
            if (row == null) { MessageBox.Show("Selektuj intervenciju u tabeli."); return; }

            var full = IntervencijaDTOManager.GetIntervencija(row.IdIntervencije);
            if (full == null) { MessageBox.Show("Intervencija nije pronađena."); return; }

            FillForm(full);

            tempLica = new List<LiceDTO>(full.Lica);
            tempVozila = new List<VoziloDTO>(full.Vozila);
            tempOprema = new List<OpremaDTO>(full.Oprema);
            tempVozilaVol = new List<VoziloVolonteraSimpleDTO>(full.VozilaVolontera);

            _editingId = row.IdIntervencije;
            SetEditMode(true);
        }

        private void buttonSacuvaj_Click(object? sender, EventArgs e)
        {
            if (!_editMode) return;

            var dto = ReadDtoFromForm();
            if (dto == null) return;

            dto.IdIntervencije = _editingId;

            if (IntervencijaDTOManager.UpdateIntervencija(dto))
            {
                selectedLica = new List<LiceDTO>(tempLica);
                selectedVozila = new List<VoziloDTO>(tempVozila);
                selectedOprema = new List<OpremaDTO>(tempOprema);
                selectedVozilaVol = new List<VoziloVolonteraSimpleDTO>(tempVozilaVol);

                RefreshData();
                CancelEdit();
            }
        }

        private void buttonOtkazi_Click(object? sender, EventArgs e) => CancelEdit();

        private IntervencijaListDTO? GetSelectedRow()
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is IntervencijaListDTO it) return it;
            return null;
        }

        private void SetEditMode(bool enabled)
        {
            _editMode = enabled;

            dataGridView1.Enabled = !enabled;

            buttonDodajIntervenciju.Enabled = !enabled;
            buttonObrisiIntervenciju.Enabled = !enabled;
            buttonIzmeniIntervenciju.Enabled = !enabled;

            buttonSacuvaj.Visible = enabled;
            buttonOtkazi.Visible = enabled;

            btnResursi.Enabled = enabled;

            if (!enabled)
            {
                _editingId = 0;
                ClearForm();
            }
        }

        private void CancelEdit()
        {
            tempLica.Clear();
            tempVozila.Clear();
            tempOprema.Clear();
            tempVozilaVol.Clear();
            SetEditMode(false);
        }

        private void ClearForm()
        {
            txbVrstaInterakcije.Clear();
            txbAdresaIntervencije.Clear();
            txbOpisSituacije.Clear();
            comboStatus.SelectedIndex = -1;
            txbBrojVatrogasaca.Clear();

            ResetNullableDtp(dateTimePickerDatumPocetka);
            ResetNullableDtp(dateTimePickerDatumKraj);
            ResetNullableDtp(dateTimePickerVremeDolaska);
            ResetNullableDtp(dateTimePickerVremePromena);
        }

        private void PrepareNullableDtp(DateTimePicker dtp)
        {
            dtp.ShowCheckBox = true;
            dtp.Checked = false;
        }

        private void ResetNullableDtp(DateTimePicker dtp)
        {
            dtp.Checked = false;
        }

        private DateTime? GetNullable(DateTimePicker dtp) {
            return (dtp.Checked ? dtp.Value : null);
        }

        private IntervencijaDTO? ReadDtoFromForm()
        {
            if (string.IsNullOrWhiteSpace(txbVrstaInterakcije.Text))
            {
                MessageBox.Show("Unesi VrstaIntervencije.");
                return null;
            }
            if (string.IsNullOrWhiteSpace(txbAdresaIntervencije.Text))
            {
                MessageBox.Show("Unesi AdresaIntervencije.");
                return null;
            }

            int? brojVatrogasaca = null;
            if (!string.IsNullOrWhiteSpace(txbBrojVatrogasaca.Text))
            {
                if (int.TryParse(txbBrojVatrogasaca.Text.Trim(), out var n)) brojVatrogasaca = n;
                else { MessageBox.Show("BrojVatrogasaca mora biti ceo broj."); return null; }
            }

            return new IntervencijaDTO
            {
                VrstaIntervencije = txbVrstaInterakcije.Text.Trim(),
                AdresaIntervencije = txbAdresaIntervencije.Text.Trim(),
                DatumPocetka = GetNullable(dateTimePickerDatumPocetka),
                DatumKraja = GetNullable(dateTimePickerDatumKraj),
                OpisSituacije = string.IsNullOrWhiteSpace(txbOpisSituacije.Text) ? null : txbOpisSituacije.Text.Trim(),
                BrojVatrogasaca = brojVatrogasaca,
                VremeDolaska = GetNullable(dateTimePickerVremeDolaska),
                DatumPromene = GetNullable(dateTimePickerVremePromena),
                Status = string.IsNullOrWhiteSpace(comboStatus.SelectedItem?.ToString()) ? null : comboStatus.SelectedItem?.ToString().Trim(),
                Lica = _editMode ? tempLica : selectedLica,
                Vozila = _editMode ? tempVozila : selectedVozila,
                Oprema = _editMode ? tempOprema : selectedOprema,
                VozilaVolontera = _editMode ? tempVozilaVol : selectedVozilaVol
            };
        }

        private void FillForm(IntervencijaDTO dto)
        {
            txbVrstaInterakcije.Text = dto.VrstaIntervencije;
            txbAdresaIntervencije.Text = dto.AdresaIntervencije;
            txbOpisSituacije.Text = dto.OpisSituacije ?? "";
            comboStatus.SelectedItem = dto.Status ?? "";
            txbBrojVatrogasaca.Text = dto.BrojVatrogasaca?.ToString() ?? "";

            SetDtp(dateTimePickerDatumPocetka, dto.DatumPocetka);
            SetDtp(dateTimePickerDatumKraj, dto.DatumKraja);
            SetDtp(dateTimePickerVremeDolaska, dto.VremeDolaska);
            SetDtp(dateTimePickerVremePromena, dto.DatumPromene);
        }

        private void SetDtp(DateTimePicker dtp, DateTime? value)
        {
            dtp.ShowCheckBox = true;
            if (value.HasValue)
            {
                dtp.Value = value.Value;
                dtp.Checked = true;
            }
            else
            {
                dtp.Checked = false;
            }
        }

        private void btnResursi_Click(object sender, EventArgs e)
        {
            if (!_editMode || _editingId == 0) return;

            var row = GetSelectedRow();
            if (row == null) { MessageBox.Show("Nijedna intervencija nije selektovana."); return; }

            var dto = IntervencijaDTOManager.GetIntervencija(row.IdIntervencije);
            if (dto == null) { MessageBox.Show("Intervencija ne postoji."); return; }

            var form = new IntervencijaResursiForm(new IntervencijaDTO
            {
                Lica = new List<LiceDTO>(tempLica),
                Vozila = new List<VoziloDTO>(tempVozila),
                Oprema = new List<OpremaDTO>(tempOprema),
                VozilaVolontera = new List<VoziloVolonteraSimpleDTO>(tempVozilaVol)
            });

            if (form.ShowDialog() == DialogResult.OK)
            {
                tempLica = new List<LiceDTO>(form.IzabranaLica);
                tempVozila = new List<VoziloDTO>(form.IzabranaVozila);
                tempOprema = new List<OpremaDTO>(form.IzabranaOprema);
                tempVozilaVol = new List<VoziloVolonteraSimpleDTO>(form.IzabranaVozilaVolontera);

                MessageBox.Show(
                    $"Označeno {tempLica.Count} lica, {tempVozila.Count} vozila, {tempVozilaVol.Count} vozila volontera, {tempOprema.Count} opreme.",
                    "Resursi"
                );
            }
        }
    }
}
