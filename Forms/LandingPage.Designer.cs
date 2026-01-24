namespace ClinicManagementSystem
{
    partial class LandingPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandingPage));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            label1 = new Label();
            loginbt = new ReaLTaiizor.Controls.HopeRoundButton();
            exitbt = new ReaLTaiizor.Controls.HopeRoundButton();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(361, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(370, 154);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(565, 182);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(523, 389);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.FlatStyle = FlatStyle.Flat;
            bigLabel1.Font = new Font("Lucida Calligraphy", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.DodgerBlue;
            bigLabel1.Location = new Point(54, 279);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(519, 29);
            bigLabel1.TabIndex = 2;
            bigLabel1.Text = "Smarter Records. Healthier Campuses.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(93, 331);
            label1.Name = "label1";
            label1.Size = new Size(444, 42);
            label1.TabIndex = 4;
            label1.Text = "A secure, offline-ready desktop system for managing\r\nclinic records, consultations, inventory, and reports.";
            label1.Click += label1_Click;
            // 
            // loginbt
            // 
            loginbt.BorderColor = Color.FromArgb(220, 223, 230);
            loginbt.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            loginbt.DangerColor = Color.FromArgb(245, 108, 108);
            loginbt.DefaultColor = Color.FromArgb(255, 255, 255);
            loginbt.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginbt.HoverTextColor = Color.FromArgb(48, 49, 51);
            loginbt.InfoColor = Color.FromArgb(144, 147, 153);
            loginbt.Location = new Point(320, 407);
            loginbt.Name = "loginbt";
            loginbt.PrimaryColor = Color.FromArgb(64, 158, 255);
            loginbt.Size = new Size(173, 51);
            loginbt.SuccessColor = Color.FromArgb(103, 194, 58);
            loginbt.TabIndex = 5;
            loginbt.Text = "Login";
            loginbt.TextColor = Color.White;
            loginbt.WarningColor = Color.FromArgb(230, 162, 60);
            loginbt.Click += loginbt_Click;
            // 
            // exitbt
            // 
            exitbt.BorderColor = Color.FromArgb(220, 223, 230);
            exitbt.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            exitbt.DangerColor = Color.FromArgb(245, 108, 108);
            exitbt.DefaultColor = Color.FromArgb(255, 255, 255);
            exitbt.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitbt.HoverTextColor = Color.FromArgb(48, 49, 51);
            exitbt.InfoColor = Color.FromArgb(144, 147, 153);
            exitbt.Location = new Point(114, 407);
            exitbt.Name = "exitbt";
            exitbt.PrimaryColor = Color.FromArgb(64, 158, 255);
            exitbt.Size = new Size(179, 51);
            exitbt.SuccessColor = Color.FromArgb(103, 194, 58);
            exitbt.TabIndex = 6;
            exitbt.Text = "Exit";
            exitbt.TextColor = Color.White;
            exitbt.WarningColor = Color.FromArgb(230, 162, 60);
            exitbt.Click += exitbt_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(-5, 504);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(320, 130);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(306, 560);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(306, 130);
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // LandingPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1114, 631);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(exitbt);
            Controls.Add(loginbt);
            Controls.Add(label1);
            Controls.Add(bigLabel1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LandingPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LandingPage";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private Label label1;
        private ReaLTaiizor.Controls.HopeRoundButton loginbt;
        private ReaLTaiizor.Controls.HopeRoundButton exitbt;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}