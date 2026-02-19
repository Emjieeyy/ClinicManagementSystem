using ClinicManagementSystem.Data;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClinicManagementSystem
{
    public partial class UC_StudentRecords : UserControl
    {
        public UC_StudentRecords()
        {
            InitializeComponent();

            // 1. Load from JSON immediately
            ClinicData.LoadData();

            // 2. Setup Grid Behavior
            dataGridView1.ReadOnly = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            LoadData();
        }

        // Call this to sync with student entries and fix the UI
        public void LoadData()
        {// 1. Set the data source
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ClinicData.StudentRecords;

            // Attach the styling logic to the event that fires once data is finished loading
            dataGridView1.DataBindingComplete += DataGridView1_DataBindingComplete;
        }

        private void DataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // --- EXACT COPY OF YOUR SETUP ---
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Header styling
            dataGridView1.EnableHeadersVisualStyles = false; // Required to show custom header colors
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // Row-specific styling (Adapted loop from your inventory setup)
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Note: Replace 'YourItemType' with your actual class name (e.g., Student)
                // and 'Condition' with your logic (e.g., item.IsUrgent)
                if (row.DataBoundItem is var item)
                {
                    // if (Condition == true) 
                    // {
                    // Highlighting logic for danger items
                    row.DefaultCellStyle.BackColor = Color.MistyRose;
                    row.DefaultCellStyle.ForeColor = Color.DarkRed;
                    row.DefaultCellStyle.SelectionBackColor = Color.IndianRed;
                    row.DefaultCellStyle.SelectionForeColor = Color.White;
                    // }
                    // else
                    // {
                    // Ensure normal rows stay black
                    row.DefaultCellStyle.ForeColor = Color.Black;
                    row.DefaultCellStyle.BackColor = Color.White;
                    // }
                }
                // Check specifically for your column name
                if (dataGridView1.Columns.Contains("DateVisited"))
                {
                    // Fix the "split" time by widening the column
                    dataGridView1.Columns["DateVisited"].Width = 160;
                    dataGridView1.Columns["DateVisited"].DefaultCellStyle.Format = "MM/dd/yyyy hh:mm tt";
                }

                // Remove the event so it doesn't keep firing
                dataGridView1.DataBindingComplete -= DataGridView1_DataBindingComplete;
            }
        }

        private void hopeTextBox1_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void PerformStudentSearch()
        {
            string term = hopeTextBox1.Text.Trim().ToLower();

            // If empty or placeholder, show everything
            if (string.IsNullOrEmpty(term) || term == "search records...")
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ClinicData.StudentRecords.ToList();
                return;
            }

            // Real-time filter
            var filtered = ClinicData.StudentRecords.Where(s =>
                (s.StudentID?.ToLower().Contains(term) ?? false) ||
                (s.StudentName?.ToLower().Contains(term) ?? false) ||
                (s.Course?.ToLower().Contains(term) ?? false) ||
                (s.Symptoms?.ToLower().Contains(term) ?? false) ||
                (s.Medicine?.ToLower().Contains(term) ?? false)
            ).ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = filtered;
        }

        private void hopeTextBox1_TextAlignChanged(object sender, EventArgs e)
        {

        }

        private void hopeTextBox1_TextChanged(object sender, EventArgs e)
        {
            PerformStudentSearch();
        }
    }
}