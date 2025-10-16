using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;

using VatrogasnaSluzba.DTO;


namespace VatrogasnaSluzba.Forms
{
    public partial class IntervencijaForm : Form
    {
        private readonly BindingList<IntervencijaListDTO> _model = new();
        private bool _editMode = false;
        private int _editingId = 0;

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

            // << NOVO: reaguj na promenu selekcije >>
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;

            PrepareNullableDtp(dateTimePickerDatumPocetka);
            PrepareNullableDtp(dateTimePickerDatumKraj);
            PrepareNullableDtp(dateTimePickerVremeDolaska);
            PrepareNullableDtp(dateTimePickerVremePromena);

            SetEditMode(false);

            buttonDodajIntervenciju.Click += buttonDodajIntervenciju_Click;
            buttonObrisiIntervenciju.Click += buttonObrisiIntervenciju_Click;
            buttonIzmeniIntervenciju.Click += buttonIzmeniIntervenciju_Click;
            buttonSacuvaj.Click += buttonSacuvaj_Click;
            buttonOtkazi.Click += buttonOtkazi_Click;

            this.Load += IntervencijaForm_Load;
        }

        private void dataGridView1_SelectionChanged(object? sender, EventArgs e)
        {
            // Dok si u režimu izmene, ne diramo formu (da ne pregazimo izmene)
            if (_editMode) return;

            var row = GetSelectedRow();
            if (row == null) return;

            var full = IntervencijaDTOManager.GetIntervencija(row.IdIntervencije);
            if (full == null) return;

            FillForm(full);
        }


        private void IntervencijaForm_Load(object sender, EventArgs e) => RefreshData();

        private void RefreshData()
        {
            _model.Clear();
            var data = IntervencijaDTOManager.GetSveIntervencijeList();
            foreach (var it in data) _model.Add(it);
        }

        // ===== Dodaj =====
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

        // ===== Obriši =====
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

        // ===== Uđi u režim izmene =====
        private void buttonIzmeniIntervenciju_Click(object? sender, EventArgs e)
        {
            var row = GetSelectedRow();
            if (row == null) { MessageBox.Show("Selektuj intervenciju u tabeli."); return; }

            var full = IntervencijaDTOManager.GetIntervencija(row.IdIntervencije);
            if (full == null) { MessageBox.Show("Intervencija nije pronađena."); return; }

            FillForm(full);
            _editingId = row.IdIntervencije;
            SetEditMode(true);
        }

        // ===== Sačuvaj izmene =====
        private void buttonSacuvaj_Click(object? sender, EventArgs e)
        {
            if (!_editMode) return;

            var dto = ReadDtoFromForm();
            if (dto == null) return;

            dto.IdIntervencije = _editingId;

            if (IntervencijaDTOManager.UpdateIntervencija(dto))
            {
                RefreshData();
                CancelEdit();
            }
        }

        // ===== Otkaži izmene =====
        private void buttonOtkazi_Click(object? sender, EventArgs e) => CancelEdit();



        // ===== Pomocne =====
        private IntervencijaListDTO? GetSelectedRow()
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is IntervencijaListDTO it) return it;
            return null;
        }

        private void SetEditMode(bool enabled)
        {
            _editMode = enabled;

            buttonDodajIntervenciju.Enabled = !enabled;
            buttonObrisiIntervenciju.Enabled = !enabled;
            buttonIzmeniIntervenciju.Enabled = !enabled;

            buttonSacuvaj.Visible = enabled;
            buttonOtkazi.Visible = enabled;

            if (!enabled)
            {
                _editingId = 0;
                ClearForm();
            }
        }

        private void CancelEdit() => SetEditMode(false);

        private void ClearForm()
        {
            txbVrstaInterakcije.Clear(); // (naziv sa tvoje forme)
            txbAdresaIntervencije.Clear();
            txbOpisSituacije.Clear();
            txbStatus.Clear();
            txbBrojVatrogasaca.Clear();
            //txbSmena.Clear(); // ignorisemo u DTO, ali čistimo polje

            ResetNullableDtp(dateTimePickerDatumPocetka);
            ResetNullableDtp(dateTimePickerDatumKraj);
            ResetNullableDtp(dateTimePickerVremeDolaska);
            ResetNullableDtp(dateTimePickerVremePromena);
        }

        private void PrepareNullableDtp(DateTimePicker dtp)
        {
            dtp.ShowCheckBox = true; // checkbox = “ima vrednost”
            dtp.Checked = false;     // start kao null
        }

        private void ResetNullableDtp(DateTimePicker dtp) => dtp.Checked = false;

        private DateTime? GetNullable(DateTimePicker dtp) => dtp.Checked ? dtp.Value : (DateTime?)null;

        private IntervencijaDTO? ReadDtoFromForm()
        {
            // Osnovna validacija
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
                Status = string.IsNullOrWhiteSpace(txbStatus.Text) ? null : txbStatus.Text.Trim()
                // txbSmena se IGNORIŠE (DTO bez referenci)
            };
        }

        private void FillForm(IntervencijaDTO dto)
        {
            txbVrstaInterakcije.Text = dto.VrstaIntervencije;
            txbAdresaIntervencije.Text = dto.AdresaIntervencije;
            txbOpisSituacije.Text = dto.OpisSituacije ?? "";
            txbStatus.Text = dto.Status ?? "";
            txbBrojVatrogasaca.Text = dto.BrojVatrogasaca?.ToString() ?? "";
            // txbSmena ostaje prazan (nije deo DTO-a)

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

        private void IntervencijaForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
