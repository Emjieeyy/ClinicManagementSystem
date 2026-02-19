namespace ClinicManagementSystem
{
    partial class UC_AddInformation1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_AddInformation1));
            SaveRecordsbt = new ReaLTaiizor.Controls.HopeRoundButton();
            SymptomsTxt = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            StudentNametxt = new TextBox();
            label1 = new Label();
            StudentID = new TextBox();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            Clearbt = new ReaLTaiizor.Controls.HopeRoundButton();
            label7 = new Label();
            CourseComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // SaveRecordsbt
            // 
            SaveRecordsbt.BorderColor = Color.FromArgb(220, 223, 230);
            SaveRecordsbt.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            SaveRecordsbt.DangerColor = Color.FromArgb(245, 108, 108);
            SaveRecordsbt.DefaultColor = Color.FromArgb(255, 255, 255);
            SaveRecordsbt.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveRecordsbt.HoverTextColor = Color.FromArgb(48, 49, 51);
            SaveRecordsbt.InfoColor = Color.FromArgb(144, 147, 153);
            SaveRecordsbt.Location = new Point(500, 440);
            SaveRecordsbt.Name = "SaveRecordsbt";
            SaveRecordsbt.PrimaryColor = Color.FromArgb(64, 158, 255);
            SaveRecordsbt.Size = new Size(172, 39);
            SaveRecordsbt.SuccessColor = Color.FromArgb(103, 194, 58);
            SaveRecordsbt.TabIndex = 35;
            SaveRecordsbt.Text = "Save Records";
            SaveRecordsbt.TextColor = Color.White;
            SaveRecordsbt.WarningColor = Color.FromArgb(230, 162, 60);
            SaveRecordsbt.Click += SaveRecordsbt_Click;
            // 
            // SymptomsTxt
            // 
            SymptomsTxt.BackColor = Color.White;
            SymptomsTxt.Location = new Point(284, 367);
            SymptomsTxt.Name = "SymptomsTxt";
            SymptomsTxt.Size = new Size(360, 27);
            SymptomsTxt.TabIndex = 31;
            SymptomsTxt.KeyDown += SymptomsTxt_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(149, 376);
            label4.Name = "label4";
            label4.Size = new Size(104, 19);
            label4.TabIndex = 30;
            label4.Text = " Symptoms:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(152, 311);
            label3.Name = "label3";
            label3.Size = new Size(72, 19);
            label3.TabIndex = 28;
            label3.Text = "Course:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(148, 258);
            label2.Name = "label2";
            label2.Size = new Size(129, 19);
            label2.TabIndex = 27;
            label2.Text = " StudentName:";
            // 
            // StudentNametxt
            // 
            StudentNametxt.BackColor = Color.White;
            StudentNametxt.Location = new Point(284, 247);
            StudentNametxt.Name = "StudentNametxt";
            StudentNametxt.Size = new Size(360, 27);
            StudentNametxt.TabIndex = 26;
            StudentNametxt.KeyDown += StudentNametxt_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(154, 196);
            label1.Name = "label1";
            label1.Size = new Size(90, 19);
            label1.TabIndex = 25;
            label1.Text = "StudentID:";
            // 
            // StudentID
            // 
            StudentID.BackColor = Color.White;
            StudentID.Location = new Point(284, 188);
            StudentID.Name = "StudentID";
            StudentID.Size = new Size(360, 27);
            StudentID.TabIndex = 24;
            StudentID.KeyDown += StudentID_KeyDown;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Century Gothic", 25.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.DodgerBlue;
            bigLabel1.Location = new Point(145, 41);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(568, 49);
            bigLabel1.TabIndex = 36;
            bigLabel1.Text = "Add New Medical Records";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(154, 103);
            label5.Name = "label5";
            label5.Size = new Size(301, 21);
            label5.TabIndex = 37;
            label5.Text = "Please fill the student details below";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(66, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 61);
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            // 
            // Clearbt
            // 
            Clearbt.BackColor = Color.Gray;
            Clearbt.BorderColor = Color.DodgerBlue;
            Clearbt.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            Clearbt.DangerColor = Color.FromArgb(245, 108, 108);
            Clearbt.DefaultColor = Color.DeepSkyBlue;
            Clearbt.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Clearbt.HoverTextColor = Color.FromArgb(48, 49, 51);
            Clearbt.InfoColor = Color.FromArgb(144, 147, 153);
            Clearbt.Location = new Point(294, 440);
            Clearbt.Name = "Clearbt";
            Clearbt.PrimaryColor = Color.Gainsboro;
            Clearbt.Size = new Size(161, 39);
            Clearbt.SuccessColor = Color.FromArgb(103, 194, 58);
            Clearbt.TabIndex = 40;
            Clearbt.Text = "Clear";
            Clearbt.TextColor = Color.DodgerBlue;
            Clearbt.WarningColor = Color.FromArgb(230, 162, 60);
            Clearbt.Click += Clearbt_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(263, 194);
            label7.Name = "label7";
            label7.Size = new Size(16, 19);
            label7.TabIndex = 41;
            label7.Text = "*";
            // 
            // CourseComboBox
            // 
            CourseComboBox.FormattingEnabled = true;
            CourseComboBox.Items.AddRange(new object[] { "BSIT ", "BSHM ", "BSTM ", "BSBA ", "BSED", "SHS" });
            CourseComboBox.Location = new Point(284, 307);
            CourseComboBox.Name = "CourseComboBox";
            CourseComboBox.Size = new Size(360, 28);
            CourseComboBox.TabIndex = 42;
            CourseComboBox.KeyDown += CourseComboBox_KeyDown;
            // 
            // UC_AddInformation1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(CourseComboBox);
            Controls.Add(label7);
            Controls.Add(Clearbt);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(bigLabel1);
            Controls.Add(SaveRecordsbt);
            Controls.Add(SymptomsTxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(StudentNametxt);
            Controls.Add(label1);
            Controls.Add(StudentID);
            Name = "UC_AddInformation1";
            Size = new Size(786, 588);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.HopeRoundButton SaveRecordsbt;
        private TextBox SymptomsTxt;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox StudentNametxt;
        private Label label1;
        private TextBox StudentID;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private Label label5;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.HopeRoundButton Clearbt;
        private Label label7;
        private ComboBox CourseComboBox;
    }
}
