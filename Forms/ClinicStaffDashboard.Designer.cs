namespace ClinicManagementSystem
{
    partial class ClinicStaffDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClinicStaffDashboard));
            navbar = new Panel();
            pictureBox7 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            ClinicLogOutbtn = new ReaLTaiizor.Controls.HopeRoundButton();
            reportbt = new ReaLTaiizor.Controls.HopeRoundButton();
            inventorybt = new ReaLTaiizor.Controls.HopeRoundButton();
            pictureBox2 = new PictureBox();
            ClinicStaffStudentRecordsbt = new ReaLTaiizor.Controls.HopeRoundButton();
            mainPanel = new Panel();
            navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // navbar
            // 
            navbar.BackColor = Color.FromArgb(64, 158, 255);
            navbar.Controls.Add(pictureBox7);
            navbar.Controls.Add(pictureBox5);
            navbar.Controls.Add(pictureBox4);
            navbar.Controls.Add(pictureBox3);
            navbar.Controls.Add(ClinicLogOutbtn);
            navbar.Controls.Add(reportbt);
            navbar.Controls.Add(inventorybt);
            navbar.Controls.Add(pictureBox2);
            navbar.Controls.Add(ClinicStaffStudentRecordsbt);
            navbar.Dock = DockStyle.Left;
            navbar.Location = new Point(0, 0);
            navbar.Margin = new Padding(3, 3, 3, 2);
            navbar.Name = "navbar";
            navbar.Size = new Size(307, 723);
            navbar.TabIndex = 0;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.FromArgb(189, 233, 255);
            pictureBox7.BackgroundImage = (Image)resources.GetObject("pictureBox7.BackgroundImage");
            pictureBox7.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox7.Location = new Point(50, 530);
            pictureBox7.Margin = new Padding(3, 3, 3, 2);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(40, 37);
            pictureBox7.TabIndex = 12;
            pictureBox7.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.FromArgb(189, 233, 255);
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.Location = new Point(48, 431);
            pictureBox5.Margin = new Padding(3, 3, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(42, 39);
            pictureBox5.TabIndex = 10;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(189, 233, 255);
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(48, 321);
            pictureBox4.Margin = new Padding(3, 3, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(40, 40);
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(189, 233, 255);
            pictureBox3.BackgroundImage = Properties.Resources.edit;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(47, 208);
            pictureBox3.Margin = new Padding(3, 3, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 39);
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // ClinicLogOutbtn
            // 
            ClinicLogOutbtn.BackColor = Color.FromArgb(189, 233, 255);
            ClinicLogOutbtn.BorderColor = Color.FromArgb(189, 233, 255);
            ClinicLogOutbtn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            ClinicLogOutbtn.DangerColor = Color.FromArgb(245, 108, 108);
            ClinicLogOutbtn.DefaultColor = Color.FromArgb(255, 255, 255);
            ClinicLogOutbtn.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClinicLogOutbtn.ForeColor = Color.DodgerBlue;
            ClinicLogOutbtn.HoverTextColor = Color.FromArgb(48, 49, 51);
            ClinicLogOutbtn.InfoColor = Color.FromArgb(144, 147, 153);
            ClinicLogOutbtn.Location = new Point(13, 517);
            ClinicLogOutbtn.Name = "ClinicLogOutbtn";
            ClinicLogOutbtn.PrimaryColor = Color.FromArgb(189, 233, 255);
            ClinicLogOutbtn.Size = new Size(272, 63);
            ClinicLogOutbtn.SuccessColor = Color.FromArgb(103, 194, 58);
            ClinicLogOutbtn.TabIndex = 5;
            ClinicLogOutbtn.Text = "Logout";
            ClinicLogOutbtn.TextColor = Color.DeepSkyBlue;
            ClinicLogOutbtn.WarningColor = Color.FromArgb(230, 162, 60);
            ClinicLogOutbtn.Click += ClinicLogOutbtn_Click;
            // 
            // reportbt
            // 
            reportbt.BackColor = Color.FromArgb(189, 233, 255);
            reportbt.BorderColor = Color.FromArgb(189, 233, 255);
            reportbt.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            reportbt.DangerColor = Color.FromArgb(245, 108, 108);
            reportbt.DefaultColor = Color.FromArgb(255, 255, 255);
            reportbt.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reportbt.ForeColor = Color.DodgerBlue;
            reportbt.HoverTextColor = Color.FromArgb(48, 49, 51);
            reportbt.InfoColor = Color.FromArgb(144, 147, 153);
            reportbt.Location = new Point(13, 414);
            reportbt.Name = "reportbt";
            reportbt.PrimaryColor = Color.FromArgb(189, 233, 255);
            reportbt.Size = new Size(276, 56);
            reportbt.SuccessColor = Color.FromArgb(103, 194, 58);
            reportbt.TabIndex = 4;
            reportbt.Text = "Reports";
            reportbt.TextColor = Color.DeepSkyBlue;
            reportbt.WarningColor = Color.FromArgb(230, 162, 60);
            reportbt.Click += reportbt_Click;
            // 
            // inventorybt
            // 
            inventorybt.BackColor = Color.FromArgb(189, 233, 255);
            inventorybt.BorderColor = Color.FromArgb(189, 233, 255);
            inventorybt.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            inventorybt.DangerColor = Color.FromArgb(245, 108, 108);
            inventorybt.DefaultColor = Color.FromArgb(255, 255, 255);
            inventorybt.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inventorybt.ForeColor = Color.DodgerBlue;
            inventorybt.HoverTextColor = Color.FromArgb(48, 49, 51);
            inventorybt.InfoColor = Color.FromArgb(144, 147, 153);
            inventorybt.Location = new Point(13, 309);
            inventorybt.Name = "inventorybt";
            inventorybt.PrimaryColor = Color.FromArgb(189, 233, 255);
            inventorybt.Size = new Size(276, 59);
            inventorybt.SuccessColor = Color.FromArgb(103, 194, 58);
            inventorybt.TabIndex = 3;
            inventorybt.Text = "Inventory";
            inventorybt.TextColor = Color.DeepSkyBlue;
            inventorybt.WarningColor = Color.FromArgb(230, 162, 60);
            inventorybt.Click += inventorybt_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(-7, 26);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(318, 107);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // ClinicStaffStudentRecordsbt
            // 
            ClinicStaffStudentRecordsbt.BackColor = Color.FromArgb(189, 233, 255);
            ClinicStaffStudentRecordsbt.BorderColor = Color.FromArgb(189, 233, 255);
            ClinicStaffStudentRecordsbt.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            ClinicStaffStudentRecordsbt.DangerColor = Color.FromArgb(245, 108, 108);
            ClinicStaffStudentRecordsbt.DefaultColor = Color.FromArgb(255, 255, 255);
            ClinicStaffStudentRecordsbt.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClinicStaffStudentRecordsbt.ForeColor = Color.DodgerBlue;
            ClinicStaffStudentRecordsbt.HoverTextColor = Color.FromArgb(48, 49, 51);
            ClinicStaffStudentRecordsbt.InfoColor = Color.FromArgb(144, 147, 153);
            ClinicStaffStudentRecordsbt.Location = new Point(13, 197);
            ClinicStaffStudentRecordsbt.Name = "ClinicStaffStudentRecordsbt";
            ClinicStaffStudentRecordsbt.PrimaryColor = Color.FromArgb(189, 233, 255);
            ClinicStaffStudentRecordsbt.Size = new Size(276, 63);
            ClinicStaffStudentRecordsbt.SuccessColor = Color.FromArgb(103, 194, 58);
            ClinicStaffStudentRecordsbt.TabIndex = 0;
            ClinicStaffStudentRecordsbt.Text = "          Student Records";
            ClinicStaffStudentRecordsbt.TextColor = Color.DeepSkyBlue;
            ClinicStaffStudentRecordsbt.WarningColor = Color.FromArgb(230, 162, 60);
            ClinicStaffStudentRecordsbt.Click += ClinicStaffStudentRecordsbt_Click;
            // 
            // mainPanel
            // 
            mainPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(307, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(836, 723);
            mainPanel.TabIndex = 1;
            // 
            // ClinicStaffDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1143, 723);
            ControlBox = false;
            Controls.Add(mainPanel);
            Controls.Add(navbar);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ClinicStaffDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClinicStaffDashboard";
            navbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel navbar;
        private ReaLTaiizor.Controls.HopeRoundButton ClinicStaffStudentRecordsbt;
        private PictureBox pictureBox2;
        private ReaLTaiizor.Controls.HopeRoundButton reportbt;
        private ReaLTaiizor.Controls.HopeRoundButton inventorybt;
        private ReaLTaiizor.Controls.HopeRoundButton ClinicLogOutbtn;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox7;
        private Panel mainPanel;
    }
}