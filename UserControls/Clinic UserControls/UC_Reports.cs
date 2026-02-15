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
    public partial class UC_Reports : UserControl
    {
        public UC_Reports()
        {
            InitializeComponent();
        }

        private void bigLabel1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void UC_Reports_Load(object sender, EventArgs e)
        {

        }

        private void InventoryReportsbtn_Click(object sender, EventArgs e)
        {
            // Pulls the live list your classmate is using in UC_Inventory
            var items = InventoryData.InventoryItems;

            if (items == null || items.Count == 0)
            {
                MessageBox.Show("Inventory list is empty!");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog { Filter = "CSV|*.csv", FileName = "Clinic_Inventory_Report.csv" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("sep=,");
                sb.AppendLine("Item ID,Item Name,Quantity,Expiry Date");

                foreach (var item in items)
                {
                    // Using the exact property names from your Model
                    sb.AppendLine($"{item.ItemId},{item.ItemName},{item.Quantity},{item.ExpiryDate:yyyy-MM-dd}");
                }

                System.IO.File.WriteAllText(sfd.FileName, sb.ToString());
                MessageBox.Show("Inventory Exported! ✨");
            }
        }

        private void StudentReportsbtn_Click(object sender, EventArgs e)
        {
            // Pulls from the Student Records list in your Data folder
            var records = ClinicData.StudentRecords;

            if (records == null || records.Count == 0)
            {
                MessageBox.Show("No student visits found!");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog { Filter = "CSV|*.csv", FileName = "Student_Consultation_Logs.csv" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("sep=,");
                sb.AppendLine("StudentID,Name,Course,Symptoms,Medicine,DateVisited");

                foreach (var rec in records)
                {
                    sb.AppendLine($"{rec.StudentID},{rec.StudentName},{rec.Course},{rec.Symptoms},{rec.Medicine},{rec.DateVisited:yyyy-MM-dd}");
                }

                System.IO.File.WriteAllText(sfd.FileName, sb.ToString());
                MessageBox.Show("Consultation Logs Exported! 📄");
            }
        }
    }
 }



