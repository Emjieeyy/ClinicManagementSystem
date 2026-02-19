using ClinicManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq; // Added for .Where and .ToList
using System.Windows.Forms;

namespace ClinicManagementSystem
{
    public partial class UC_UpdateInfomation : UserControl
    {
        public UC_UpdateInfomation()
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = ClinicData.StudentRecords;

            dataGridView1.AllowUserToOrderColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = false;

            SearchInfo.Enabled = true;
            SearchInfo.ReadOnly = false;
            SearchInfo.TabStop = true;

            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.DataBindingComplete += (s, e) =>
            {
                if (dataGridView1.Columns.Contains("Medicine"))
                    dataGridView1.Columns["Medicine"].Visible = false;

                if (dataGridView1.Columns.Contains("StudentID"))
                    dataGridView1.Columns["StudentID"].ReadOnly = true;
            };

        }

        // --- SEARCH FEATURE LOGIC (Copied from your AdminDashboard style) ---

        private void PerformStudentSearch()
        {
            string term = SearchInfo.Text.Trim();

            if (string.IsNullOrWhiteSpace(term))
            {
                // Reset to full list if search is empty
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ClinicData.StudentRecords;
                return;
            }

            string lowerTerm = term.ToLower();

            // Filtering logic using the same Null-Conditional and Null-Coalescing pattern
            var results = ClinicData.StudentRecords.Where(s =>
                (s.StudentID?.ToLower().Contains(lowerTerm) ?? false) ||
                (s.StudentName?.ToLower().Contains(lowerTerm) ?? false) ||
                (s.Symptoms?.ToLower().Contains(lowerTerm) ?? false) ||
                (s.Course?.ToLower().Contains(lowerTerm) ?? false)
            ).ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = results;
        }

        private void SearchInfo_TextChanged(object sender, EventArgs e)
        {
            PerformStudentSearch();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            PerformStudentSearch();
        }

        // --- EXISTING GRID LOGIC ---

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string columnName = dataGridView1.Columns[e.ColumnIndex].Name;

            if (columnName == "StudentName" && string.IsNullOrWhiteSpace(e.FormattedValue?.ToString()))
            {
                MessageBox.Show("Student Name cannot be empty.");
                e.Cancel = true;
            }

            if (columnName == "Symptoms" && string.IsNullOrWhiteSpace(e.FormattedValue?.ToString()))
            {
                MessageBox.Show("Symptoms cannot be empty.");
                e.Cancel = true;
            }

            if (columnName == "DateVisited" && DateTime.TryParse(e.FormattedValue?.ToString(), out DateTime date) && date > DateTime.Now)
            {
                MessageBox.Show("Date Visited cannot be in the future.");
                e.Cancel = true;
            }
        }

        private void applyChanges_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            ClinicData.SaveData();
            MessageBox.Show("Record updated successfully!");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
    }
}