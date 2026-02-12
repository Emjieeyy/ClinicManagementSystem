using ClinicManagementSystem.Data;
using System;
using System.Windows.Forms;

namespace ClinicManagementSystem
{
    public partial class UC_StudentRecords : UserControl
    {
        public UC_StudentRecords()
        {
            InitializeComponent();
            LoadData(); // Load immediately on startup
        }

        // Call this to sync with student entries and fix the UI
        public void LoadData()
        {// 1. Set the data source
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ClinicData.StudentRecords;

            // 2. Attach a one-time event to format columns ONLY after they are created
            dataGridView1.DataBindingComplete += DataGridView1_DataBindingComplete;
        }

        private void DataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
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
}