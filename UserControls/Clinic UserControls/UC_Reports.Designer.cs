namespace ClinicManagementSystem
{
    partial class UC_Reports
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Reports));
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            panel1 = new Panel();
            StudentReportsbtn = new ReaLTaiizor.Controls.HopeRoundButton();
            label4 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            InventoryReportsbtn = new ReaLTaiizor.Controls.HopeRoundButton();
            label5 = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            bigLabel3 = new ReaLTaiizor.Controls.BigLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Century Gothic", 25.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.DodgerBlue;
            bigLabel1.Location = new Point(171, 107);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(508, 49);
            bigLabel1.TabIndex = 0;
            bigLabel1.Text = "Clinic Reports & Analytics";
            bigLabel1.Click += bigLabel1_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(StudentReportsbtn);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.ForeColor = Color.DodgerBlue;
            panel1.Location = new Point(45, 251);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 265);
            panel1.TabIndex = 2;
            // 
            // StudentReportsbtn
            // 
            StudentReportsbtn.BorderColor = Color.FromArgb(220, 223, 230);
            StudentReportsbtn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            StudentReportsbtn.DangerColor = Color.FromArgb(245, 108, 108);
            StudentReportsbtn.DefaultColor = Color.FromArgb(255, 255, 255);
            StudentReportsbtn.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StudentReportsbtn.HoverTextColor = Color.FromArgb(48, 49, 51);
            StudentReportsbtn.InfoColor = Color.FromArgb(144, 147, 153);
            StudentReportsbtn.Location = new Point(53, 192);
            StudentReportsbtn.Name = "StudentReportsbtn";
            StudentReportsbtn.PrimaryColor = Color.FromArgb(64, 158, 255);
            StudentReportsbtn.Size = new Size(240, 35);
            StudentReportsbtn.SuccessColor = Color.FromArgb(103, 194, 58);
            StudentReportsbtn.TabIndex = 3;
            StudentReportsbtn.Text = "Export Consultation ";
            StudentReportsbtn.TextColor = Color.White;
            StudentReportsbtn.WarningColor = Color.FromArgb(230, 162, 60);
            StudentReportsbtn.Click += StudentReportsbtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(61, 158);
            label4.Name = "label4";
            label4.Size = new Size(228, 17);
            label4.TabIndex = 2;
            label4.Text = "Export student consultation history";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(95, 131);
            label2.Name = "label2";
            label2.Size = new Size(155, 19);
            label2.TabIndex = 1;
            label2.Text = "Student Visits Logs";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(125, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 102);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(InventoryReportsbtn);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBox2);
            panel2.ForeColor = Color.DodgerBlue;
            panel2.Location = new Point(435, 252);
            panel2.Name = "panel2";
            panel2.Size = new Size(355, 264);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // InventoryReportsbtn
            // 
            InventoryReportsbtn.BorderColor = Color.FromArgb(220, 223, 230);
            InventoryReportsbtn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            InventoryReportsbtn.DangerColor = Color.FromArgb(245, 108, 108);
            InventoryReportsbtn.DefaultColor = Color.FromArgb(255, 255, 255);
            InventoryReportsbtn.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InventoryReportsbtn.HoverTextColor = Color.FromArgb(48, 49, 51);
            InventoryReportsbtn.InfoColor = Color.FromArgb(144, 147, 153);
            InventoryReportsbtn.Location = new Point(53, 192);
            InventoryReportsbtn.Name = "InventoryReportsbtn";
            InventoryReportsbtn.PrimaryColor = Color.FromArgb(64, 158, 255);
            InventoryReportsbtn.Size = new Size(240, 35);
            InventoryReportsbtn.SuccessColor = Color.FromArgb(103, 194, 58);
            InventoryReportsbtn.TabIndex = 4;
            InventoryReportsbtn.Text = "Export Inventory";
            InventoryReportsbtn.TextColor = Color.White;
            InventoryReportsbtn.WarningColor = Color.FromArgb(230, 162, 60);
            InventoryReportsbtn.Click += InventoryReportsbtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(49, 157);
            label5.Name = "label5";
            label5.Size = new Size(258, 17);
            label5.TabIndex = 3;
            label5.Text = "Generate current medical supply levels";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(81, 129);
            label3.Name = "label3";
            label3.Size = new Size(182, 19);
            label3.TabIndex = 2;
            label3.Text = "Inventory Stock Audit";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(127, 20);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(115, 102);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // bigLabel3
            // 
            bigLabel3.AutoSize = true;
            bigLabel3.BackColor = Color.Transparent;
            bigLabel3.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            bigLabel3.ForeColor = SystemColors.ActiveCaptionText;
            bigLabel3.Location = new Point(160, 168);
            bigLabel3.Name = "bigLabel3";
            bigLabel3.Size = new Size(520, 18);
            bigLabel3.TabIndex = 66;
            bigLabel3.Text = "Generate CSV data exports for institutional compliance and planning";
            // 
            // UC_Reports
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(bigLabel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(bigLabel1);
            Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "UC_Reports";
            Size = new Size(834, 591);
            Load += UC_Reports_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label label5;
        private ReaLTaiizor.Controls.HopeRoundButton StudentReportsbtn;
        private ReaLTaiizor.Controls.HopeRoundButton InventoryReportsbtn;
        private ReaLTaiizor.Controls.BigLabel bigLabel3;
    }
}
