using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClinicManagementSystem
{
    public partial class StudentDashboard : Form
    {
        public StudentDashboard()
        {
            InitializeComponent();
            ShowPage(new UC_StudentRecords());
        }

        public void ShowPage(UserControl page)
        {
            student_UC_container.Controls.Clear();      // remove current page
            page.Dock = DockStyle.Fill;      // make it fill the panel
            student_UC_container.Controls.Add(page);    // show new page
        }

        private void hopeRoundButton3_Click(object sender, EventArgs e)
        {
            ShowPage(new UC_AddInformation1());
        }

        private void hopeRoundButton2_Click(object sender, EventArgs e)
        {
            ShowPage(new UC_UpdateInfomation());
        }

        private void myRecordsbt_Click(object sender, EventArgs e)
        {
            ShowPage(new UC_StudentRecords());
        }
    }
}
