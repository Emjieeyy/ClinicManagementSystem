using ClinicManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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
            ClinicData.SaveData(); // 🔥 Save after editing
            MessageBox.Show("Record updated successfully!");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


