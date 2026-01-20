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
        }

        private void hopeRoundButton3_Click(object sender, EventArgs e)
        {
            AddInformation addInfo = new AddInformation();
            addInfo.ShowDialog();
        }

        private void hopeRoundButton2_Click(object sender, EventArgs e)
        {
            UpdateInformation updateinfo = new UpdateInformation();
            updateinfo.ShowDialog();
        }
    }
}
