using System;
using System.ComponentModel;
using System.Windows.Forms;
using DTO = VatrogasnaSluzba.DTO;  // alias da forsiramo DTO namespace

namespace VatrogasnaSluzba.Forms
{
    public partial class SmeneForm : Form
    {
        private DTO.SmenaDTO? _current;     // trenutno učitana smena u desnom panelu
        private bool _isEdit = false;       // menjamo postojeću ili kreiramo novu

        public SmeneForm()
        {
            InitializeComponent();
            InitUi();
            LoadStanice();
            ApplyFilter();
        }

        // ---------- UI init ----------
        private void InitUi()
        {
            // filter panel
            dtpOd.Format = DateTimePickerFormat.Short;
            dtpDo.Format = DateTimePickerFormat.Short;
            dtpOd.Value = DateTime.Today.AddDays(-7);
            dtpDo.Value = DateTime.Today;

            // desni panel – vremena kao "up/down"
            dtpStart.Format = DateTimePickerFormat.Time; dtpStart.ShowUpDown = true;
            dtpEnd.Format = DateTimePickerFormat.Time; dtpEnd.ShowUpDown = true;
            dtpDatum.Format = DateTimePickerFormat.Short;

            // dugmad
            btnRefresh.Click += (_, __) => ApplyFilter();
            btnOtkazi.Click += (_, __) => ClearDetails();
            btnSnimi.Click += (_, __) => SaveCurrent();

            // grid – očisti dizajnerske kolone da ne stoje "dataGridViewText..."
            dgvSmene.AutoGenerateColumns = false;
            dgvSmene.Columns.Clear();
            dgvSmene.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSmene.MultiSelect = false;
            dgvSmene.ReadOnly = true;
            dgvSmene.AllowUserToAddRows = false;
            dgvSmene.AllowUserToDeleteRows = false;

            // moje kolone
            dgvSmene.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colDatum",
                DataPropertyName = nameof(DTO.SmenaDTO.Datum),
                HeaderText = "Datum",
                Width = 90,
                DefaultCellStyle = { Format = "d" }
            });
            dgvSmene.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colPocetak",
                DataPropertyName = nameof(DTO.SmenaDTO.VremePocetka),
                HeaderText = "Početak",
                Width = 80,
                DefaultCellStyle = { Format = "t" }
            });
            dgvSmene.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colKraj",
                DataPropertyName = nameof(DTO.SmenaDTO.VremeKraja),
                HeaderText = "Kraj",
                Width = 80,
                DefaultCellStyle = { Format = "t" }
            });
            // stanica je nested (Stanica.Naziv): nevezana kolona, punimo u CellFormatting
            dgvSmene.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colStanica",
                HeaderText = "Stanica",
                Width = 160
            });
            dgvSmene.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colVatrogasci",
                DataPropertyName = nameof(DTO.SmenaDTO.BrVatrogasaca),
                HeaderText = "Vatrogasci",
                Width = 90
            });
            dgvSmene.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colDispeceri",
                DataPropertyName = nameof(DTO.SmenaDTO.BrDispecera),
                HeaderText = "Dispečeri",
                Width = 85
            });
            dgvSmene.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colInterv",
                DataPropertyName = nameof(DTO.SmenaDTO.BrojIntervencija),
                HeaderText = "#Interv.",
                Width = 70
            });

            dgvSmene.CellFormatting += DgvSmene_CellFormatting;
            dgvSmene.SelectionChanged += DgvSmene_SelectionChanged;
        }

        // prikaži naziv stanice (nested DTO.StanicaSimpleDTO)
        private void DgvSmene_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvSmene.Columns[e.ColumnIndex].Name == "colStanica")
            {
                var dto = dgvSmene.Rows[e.RowIndex].DataBoundItem as DTO.SmenaDTO;
                e.Value = dto?.Stanica?.Naziv ?? "";
                e.FormattingApplied = true;
            }
        }

        // ---------- podaci ----------
        private void LoadStanice()
        {
            // lista stanica za filter i za unos
            var stanice = DTO.StanicaDTOManager.GetSveStaniceSimple();

            // FILTER: dodaj "(sve)" na početak
            var listFilter = new BindingList<DTO.StanicaSimpleDTO>(new System.Collections.Generic.List<DTO.StanicaSimpleDTO>
            {
                new DTO.StanicaSimpleDTO { IdStanice = 0, Naziv = "(sve stanice)" }
            });
            foreach (var s in stanice) listFilter.Add(s);

            cbStanicaFilter.DataSource = listFilter;
            cbStanicaFilter.DisplayMember = nameof(DTO.StanicaSimpleDTO.Naziv);
            cbStanicaFilter.ValueMember = nameof(DTO.StanicaSimpleDTO.IdStanice);

            // DESNI PANEL
            cbStanica.DataSource = new BindingList<DTO.StanicaSimpleDTO>(stanice);
            cbStanica.DisplayMember = nameof(DTO.StanicaSimpleDTO.Naziv);
            cbStanica.ValueMember = nameof(DTO.StanicaSimpleDTO.IdStanice);
            cbStanica.SelectedIndex = -1;
        }

        private void ApplyFilter()
        {
            int? idStanice = null;
            if (cbStanicaFilter.SelectedValue is int v && v > 0)
                idStanice = v;

            var od = dtpOd.Value.Date;
            var @do = dtpDo.Value.Date;

            var list = DTO.SmenaDTOManager.GetByFilter(idStanice, od, @do);

            // direktno vežemo DTO listu; colStanica se formatira u CellFormatting
            dgvSmene.DataSource = new BindingList<DTO.SmenaDTO>(list);

            if (dgvSmene.Rows.Count > 0)
                dgvSmene.Rows[0].Selected = true;
            else
                ClearDetails();
        }

        private void DgvSmene_SelectionChanged(object? sender, EventArgs e)
        {
            var dto = dgvSmene.CurrentRow?.DataBoundItem as DTO.SmenaDTO;
            if (dto == null) { ClearDetails(); return; }

            _isEdit = true;
            _current = dto;

            dtpDatum.Value = dto.Datum;
            dtpStart.Value = dto.VremePocetka;
            dtpEnd.Value = dto.VremeKraja ?? dto.VremePocetka;
            

            if (dto.Stanica != null)
                cbStanica.SelectedValue = dto.Stanica.IdStanice;
            else
                cbStanica.SelectedIndex = -1;
        }

        private void ClearDetails()
        {
            _isEdit = false;
            _current = null;

            dtpDatum.Value = DateTime.Today;
            dtpStart.Value = DateTime.Today.AddHours(7);
            dtpEnd.Value = DateTime.Today.AddHours(15);
            cbStanica.SelectedIndex = -1;
            
        }

        private void SaveCurrent()
        {
            try
            {
                if (cbStanica.SelectedItem is not DTO.StanicaSimpleDTO stanica)
                {
                    MessageBox.Show("Izaberi stanicu.");
                    return;
                }

                var dto = new DTO.SmenaDTO
                {
                    IdSmene = _isEdit ? (_current?.IdSmene ?? 0) : 0,
                    Datum = dtpDatum.Value.Date,
                    VremePocetka = dtpStart.Value,
                    VremeKraja = dtpEnd.Value,
                    Stanica = stanica,
                    
                    // BrVatrogasaca, BrDispecera, BrojIntervencija – popunjavaš po potrebi
                };

                if (dto.IdSmene == 0)
                    dto.IdSmene = DTO.SmenaDTOManager.Add(dto);   // Add vraća ID
                else
                    DTO.SmenaDTOManager.Update(dto);

                ApplyFilter();
                MessageBox.Show("Sačuvano.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri čuvanju: " + ex.Message);
            }
        }
    }
}
