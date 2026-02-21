using ClinicManagementSystem.Data;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace ClinicManagementSystem
{
    public partial class UC_StudentRecords : UserControl
    {
        public UC_StudentRecords()
        {
            InitializeComponent();

            // 1. Grid Configuration
            dgvUCStudentRecords.ReadOnly = true;
            dgvUCStudentRecords.AllowUserToAddRows = false;
            dgvUCStudentRecords.AllowUserToDeleteRows = false;
            dgvUCStudentRecords.EditMode = DataGridViewEditMode.EditProgrammatically;

            // 2. Initial Data Load
            LoadData();
        }

        /// <summary>
        /// Loads the student's personal records using the centralized StudentDataService.
        /// </summary>
        public void LoadData()
        {
            // We delegate the logic to the Service for a cleaner approach
            var myPrivateRecords = StudentDataService.GetFilteredRecords();

            dgvUCStudentRecords.DataSource = null;
            dgvUCStudentRecords.DataSource = myPrivateRecords;

            // Optional: Update a count label if it exists on your dashboard
            // if (Total_0 != null) Total_0.Text = myPrivateRecords.Count.ToString();

            // Attach styling logic to the event that fires once data is finished loading
            dgvUCStudentRecords.DataBindingComplete += DataGridView1_DataBindingComplete;
        }

        /// <summary>
        /// Handles real-time searching within the student's own records.
        /// </summary>
        private void PerformStudentSearch()
        {
            string term = hopeTextBox1.Text.Trim();

            // Use the Service to get filtered/searched results safely
            var filtered = StudentDataService.GetFilteredRecords(term);

            dgvUCStudentRecords.DataSource = null;
            dgvUCStudentRecords.DataSource = filtered;
        }

        private void DataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Required for custom header color
            dgvUCStudentRecords.EnableHeadersVisualStyles = false;

            // =========================
            // HEADER STYLE
            // =========================
            dgvUCStudentRecords.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvUCStudentRecords.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvUCStudentRecords.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dgvUCStudentRecords.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            dgvUCStudentRecords.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Regular);

            // =========================
            // ROW STYLE (NO HIGHLIGHT)
            // =========================
            dgvUCStudentRecords.DefaultCellStyle.BackColor = Color.White;
            dgvUCStudentRecords.DefaultCellStyle.ForeColor = Color.Black;
            dgvUCStudentRecords.DefaultCellStyle.SelectionBackColor = Color.White;
            dgvUCStudentRecords.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvUCStudentRecords.DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Regular);

            // =========================
            // CLEAN LOOK SETTINGS
            // =========================
            dgvUCStudentRecords.RowHeadersVisible = false;
            dgvUCStudentRecords.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvUCStudentRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUCStudentRecords.BackgroundColor = Color.White;
            dgvUCStudentRecords.BorderStyle = BorderStyle.None;

            // Fix Date Column Format
            if (dgvUCStudentRecords.Columns.Contains("DateVisited"))
            {
                dgvUCStudentRecords.Columns["DateVisited"].DefaultCellStyle.Format = "MM/dd/yyyy hh:mm tt";
            }

            // Remove initial selection
            dgvUCStudentRecords.ClearSelection();
        }

        private void hopeTextBox1_TextChanged(object sender, EventArgs e)
        {
            PerformStudentSearch();
        }

        // Empty event handlers kept to avoid Designer errors
        private void hopeTextBox1_Click(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void hopeTextBox1_TextAlignChanged(object sender, EventArgs e) { }
        private void dgvUCStudentRecords_CellValidating(object sender, DataGridViewCellValidatingEventArgs e) { }
    }
}