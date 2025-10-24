using System;
using System.ComponentModel;
using System.Windows.Forms;
using VatrogasnaSluzba.DTO;
using DTO = VatrogasnaSluzba.DTO;

namespace VatrogasnaSluzba.Forms
{
    public partial class SmeneForm : Form
    {
        private SmenaDTO? _current;
        private FormMode CurrentMode = FormMode.Default;
        private StanicaSimpleDTO singleStanica;

        public SmeneForm(StanicaDTO stanica = null)
        {
            InitializeComponent();

            if (stanica != null)
            {
                singleStanica = new StanicaSimpleDTO(stanica);
            }

            InitUi();
            LoadStanice();
            ApplyFilter();
        }

        // ---------- enum ----------
        public enum FormMode { Default, Creating, Editing }

        // ---------- UI init ----------
        private void InitUi()
        {
            // filter panel
            dtpOd.Format = DateTimePickerFormat.Short;
            dtpDo.Format = DateTimePickerFormat.Short;
            dtpOd.Value = DateTime.Today.AddDays(-7);
            dtpDo.Value = DateTime.Today;

            // handleri za filtriranje
            cbStanicaFilter.SelectedIndexChanged += (_, __) => ApplyFilter();
            dtpOd.ValueChanged += (_, __) => ApplyFilter();
            dtpDo.ValueChanged += (_, __) => ApplyFilter();

            // desni panel
            dtpStart.Format = DateTimePickerFormat.Time; dtpStart.ShowUpDown = true;
            dtpEnd.Format = DateTimePickerFormat.Time; dtpEnd.ShowUpDown = true;
            dtpDatum.Format = DateTimePickerFormat.Short;

            // dugmici
            btnNova.Click += (_, __) => StartNew();
            btnIzmeni.Click += (_, __) => StartEdit();
            btnObrisi.Click += (_, __) => DeleteSelected();
            btnSnimi.Click += (_, __) => SaveCurrent();
            btnOtkazi.Click += (_, __) => CancelChanges();

            // grid
            dgvSmene.AutoGenerateColumns = true;
            dgvSmene.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSmene.MultiSelect = false;
            dgvSmene.ReadOnly = true;
            dgvSmene.AllowUserToAddRows = false;
            dgvSmene.AllowUserToDeleteRows = false;

            dgvSmene.SelectionChanged += DgvSmene_SelectionChanged;

            // misc
            //numBrIntervencija.Enabled = false; // broj intervencija ne treba da se menja rucno, on se automatski odredjuje na osnovu intervencija povezanih sa tom stanicom

            UpdateUiState();
        }

        // ---------- podaci ----------
        private void LoadStanice()
        {
            List<StanicaSimpleDTO> stanice;
            var listFilter = new BindingList<StanicaSimpleDTO>(new System.Collections.Generic.List<StanicaSimpleDTO>());

            if (singleStanica != null)
            {
                stanice = new List<StanicaSimpleDTO>() { singleStanica };
            }
            else
            {
                stanice = StanicaDTOManager.GetSveStaniceSimple();
                listFilter.Add(new StanicaSimpleDTO { IdStanice = 0, Naziv = "(sve stanice)" });
            }

            foreach (var s in stanice) listFilter.Add(s);

            cbStanicaFilter.DataSource = listFilter;
            cbStanicaFilter.DisplayMember = nameof(StanicaSimpleDTO.Naziv);
            cbStanicaFilter.ValueMember = nameof(StanicaSimpleDTO.IdStanice);

            // DESNI PANEL
            cbStanica.DataSource = new BindingList<StanicaSimpleDTO>(stanice);
            cbStanica.DisplayMember = nameof(StanicaSimpleDTO.Naziv);
            cbStanica.ValueMember = nameof(StanicaSimpleDTO.IdStanice);
            cbStanica.SelectedIndex = -1;
        }

        private void ApplyFilter()
        {
            int? idStanice = null;
            if (cbStanicaFilter.SelectedValue is int v && v > 0)
                idStanice = v;

            var od = dtpOd.Value.Date;
            var @do = dtpDo.Value.Date;

            var list = SmenaDTOManager.GetByFilter(idStanice, od, @do);

            dgvSmene.DataSource = new BindingList<SmenaDTO>(list);

            if (dgvSmene.Columns.Contains("Stanica"))
                dgvSmene.Columns["Stanica"].Visible = false;

            if (dgvSmene.Rows.Count > 0)
                dgvSmene.Rows[0].Selected = true;
            else
                ClearDetails();

            UpdateUiState();
        }


        private void DgvSmene_SelectionChanged(object? sender, EventArgs e)
        {
            if (CurrentMode != FormMode.Default) return;

            var dto = dgvSmene.CurrentRow?.DataBoundItem as SmenaDTO;
            if (dto == null)
            {
                _current = null;
                ClearDetails();
                UpdateUiState();
                return;
            }

            _current = dto;
            dtpDatum.Value = dto.Datum;
            dtpStart.Value = dto.VremePocetka;
            dtpEnd.Value = dto.VremeKraja ?? dto.VremePocetka;

            if (dto.Stanica != null)
                cbStanica.SelectedValue = dto.Stanica.IdStanice;
            else
                cbStanica.SelectedIndex = -1;

            //numBrIntervencija.Value = dto.BrojIntervencija ?? 0;

            UpdateUiState();
        }

        private void ClearDetails()
        {
            _current = null;
            dtpDatum.Value = DateTime.Today;
            dtpStart.Value = DateTime.Today.AddHours(7);
            dtpEnd.Value = DateTime.Today.AddHours(15);
            cbStanica.SelectedIndex = -1;
            //numBrIntervencija.Value = 0;
        }

        // ---------- Režimi ----------
        private void SetMode(FormMode mode)
        {
            CurrentMode = mode;
            UpdateUiState();
        }

        private void UpdateUiState()
        {
            bool editing = CurrentMode != FormMode.Default;

            // Glavni delovi forme
            gbLista.Enabled = !editing;
            panelFilter.Enabled = !editing;

            // Desni panel
            dtpDatum.Enabled = editing;
            dtpStart.Enabled = editing;
            dtpEnd.Enabled = editing;
            cbStanica.Enabled = editing;

            // Dugmad
            btnNova.Enabled = !editing;
            btnIzmeni.Enabled = !editing && _current != null;
            btnObrisi.Enabled = !editing && _current != null;
            btnSnimi.Enabled = editing;
            btnOtkazi.Enabled = editing;
        }

        // ---------- Dugmad ----------
        private void StartNew()
        {
            ClearDetails();
            _current = new SmenaDTO();
            SetMode(FormMode.Creating);
        }

        private void StartEdit()
        {
            if (dgvSmene.CurrentRow?.DataBoundItem is not SmenaDTO dto)
            {
                MessageBox.Show("Izaberi smenu za izmenu.");
                return;
            }

            _current = dto;
            SetMode(FormMode.Editing);
        }

        private void DeleteSelected()
        {
            if (dgvSmene.CurrentRow?.DataBoundItem is not SmenaDTO dto)
            {
                MessageBox.Show("Izaberi smenu za brisanje.");
                return;
            }

            if (MessageBox.Show("Da li želite da izbrišete ovu smenu?",
                                "Potvrda", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SmenaDTOManager.Delete(dto.IdSmene);
                ApplyFilter();
            }
        }

        private void SaveCurrent()
        {
            try
            {
                if (cbStanica.SelectedItem is not StanicaSimpleDTO stanica)
                {
                    MessageBox.Show("Izaberite stanicu.");
                    return;
                }

                var current = dgvSmene.CurrentRow?.DataBoundItem as SmenaDTO;

                var dto = new SmenaDTO
                {
                    IdSmene = (CurrentMode == FormMode.Editing) ? (_current?.IdSmene ?? 0) : 0,
                    Datum = dtpDatum.Value.Date,
                    VremePocetka = dtpStart.Value,
                    VremeKraja = dtpEnd.Value,
                    Stanica = stanica
                };

                if (dto.IdSmene == 0)
                {
                    dto.IdSmene = SmenaDTOManager.Add(dto);
                    MessageBox.Show("Smena uspešno dodata.");
                }
                else
                {
                    SmenaDTOManager.Update(dto);
                    MessageBox.Show("Podaci uspešno izmenjeni.");
                }

                ApplyFilter();
                SetMode(FormMode.Default);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri čuvanju: " + ex.Message);
            }
        }

        private void CancelChanges()
        {
            ClearDetails();
            SetMode(FormMode.Default);
        }
    }
}
