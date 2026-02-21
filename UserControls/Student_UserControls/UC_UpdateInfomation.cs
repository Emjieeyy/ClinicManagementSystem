using ClinicManagementSystem.Data;

using System;

using System.Collections.Generic;

using System.Data;

using System.Linq;

using System.Windows.Forms;

using System.Drawing;



namespace ClinicManagementSystem

{

    public partial class UC_UpdateInfomation : UserControl

    {

        public UC_UpdateInfomation()

        {

            InitializeComponent();



            // Safety check: Using the name from your Properties window to avoid NullReference

            if (dgvUCupdateInfo == null) return;



            // MANUAL WIRING: Ensures search and validation work even if Designer is empty

            dgvUCupdateInfo.CellValidating += dataGridView1_CellValidating;

            SearchInfo.TextChanged += SearchInfo_TextChanged;

            if (SearchBtn != null) SearchBtn.Click += SearchBtn_Click;



            // INITIAL GRID SETUP

            dgvUCupdateInfo.AutoGenerateColumns = true;



            // --- UPDATED: Use the Service to load only the student's records ---

            LoadData();



            dgvUCupdateInfo.AllowUserToOrderColumns = false;

            dgvUCupdateInfo.AllowUserToAddRows = false;

            dgvUCupdateInfo.ReadOnly = false;



            SearchInfo.Enabled = true;

            SearchInfo.ReadOnly = false;

            SearchInfo.TabStop = true;



            dgvUCupdateInfo.MultiSelect = false;

            dgvUCupdateInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;



            dgvUCupdateInfo.DataBindingComplete += (s, e) =>

            {

                if (dgvUCupdateInfo.Columns.Contains("Medicine"))

                    dgvUCupdateInfo.Columns["Medicine"].Visible = false;



                if (dgvUCupdateInfo.Columns.Contains("StudentID"))

                    dgvUCupdateInfo.Columns["StudentID"].ReadOnly = true;



                // Lock StudentName if the user is a student to keep data clean

                if (SessionManager.Role == "Student" && dgvUCupdateInfo.Columns.Contains("StudentName"))

                    dgvUCupdateInfo.Columns["StudentName"].ReadOnly = true;

            };

        }



        // --- REUSABLE LOAD METHOD ---

        public void LoadData()

        {

            // Simply call the service we created

            var myRecords = StudentDataService.GetFilteredRecords();

            dgvUCupdateInfo.DataSource = null;

            dgvUCupdateInfo.DataSource = myRecords;

        }



        // --- UPDATED SEARCH FEATURE LOGIC ---



        private void PerformStudentSearch()

        {

            if (dgvUCupdateInfo == null) return;

            string term = SearchInfo.Text.Trim();



            // Pass the term to the service; it handles the Privacy Filter automatically

            var results = StudentDataService.GetFilteredRecords(term);



            dgvUCupdateInfo.DataSource = null;

            dgvUCupdateInfo.DataSource = results;

        }



        private void SearchInfo_TextChanged(object sender, EventArgs e)

        {

            PerformStudentSearch();

        }



        private void SearchBtn_Click(object sender, EventArgs e)

        {

            PerformStudentSearch();

        }



        // --- GRID VALIDATION LOGIC (Kept exactly as you had it) ---



        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)

        {

            if (dgvUCupdateInfo == null) return;

            string columnName = dgvUCupdateInfo.Columns[e.ColumnIndex].Name;



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

            if (dgvUCupdateInfo == null) return;



            dgvUCupdateInfo.EndEdit();



            // Save the current state of the list back to the JSON file

            ClinicData.SaveData();



            MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);



            // Refresh to ensure we are still looking at our private filtered list

            LoadData();

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }

    }

}