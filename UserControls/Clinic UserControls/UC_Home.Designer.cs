namespace ClinicManagementSystem
{
    partial class UC_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Home));
            hopeTextBox1 = new ReaLTaiizor.Controls.HopeTextBox();
            pictureBox1 = new PictureBox();
            btnAdd = new ReaLTaiizor.Controls.HopeRoundButton();
            hopeRoundButton9 = new ReaLTaiizor.Controls.HopeRoundButton();
            btnUpdate = new ReaLTaiizor.Controls.HopeRoundButton();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            hopeButton2 = new ReaLTaiizor.Controls.HopeButton();
            btn_view = new ReaLTaiizor.Controls.HopeRoundButton();
            btnDelete = new ReaLTaiizor.Controls.HopeRoundButton();
            bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            bigLabel3 = new ReaLTaiizor.Controls.BigLabel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            dgvStudentRecords = new DataGridView();
            StudentID = new DataGridViewTextBoxColumn();
            StudentName = new DataGridViewTextBoxColumn();
            Course = new DataGridViewTextBoxColumn();
            Symptoms = new DataGridViewTextBoxColumn();
            Medicine = new DataGridViewTextBoxColumn();
            DateVisited = new DataGridViewTextBoxColumn();
            Total_0 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudentRecords).BeginInit();
            SuspendLayout();
            // 
            // hopeTextBox1
            // 
            hopeTextBox1.BackColor = Color.White;
            hopeTextBox1.BaseColor = Color.White;
            hopeTextBox1.BorderColorA = Color.FromArgb(64, 158, 255);
            hopeTextBox1.BorderColorB = Color.FromArgb(220, 223, 230);
            hopeTextBox1.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            hopeTextBox1.ForeColor = Color.FromArgb(48, 49, 51);
            hopeTextBox1.Hint = "";
            hopeTextBox1.Location = new Point(468, 229);
            hopeTextBox1.MaxLength = 32767;
            hopeTextBox1.Multiline = false;
            hopeTextBox1.Name = "hopeTextBox1";
            hopeTextBox1.PasswordChar = '\0';
            hopeTextBox1.ScrollBars = ScrollBars.None;
            hopeTextBox1.SelectedText = "";
            hopeTextBox1.SelectionLength = 0;
            hopeTextBox1.SelectionStart = 0;
            hopeTextBox1.Size = new Size(216, 35);
            hopeTextBox1.TabIndex = 45;
            hopeTextBox1.TabStop = false;
            hopeTextBox1.Text = "Search Records...";
            hopeTextBox1.UseSystemPasswordChar = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(712, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 62);
            pictureBox1.TabIndex = 43;
            pictureBox1.TabStop = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(76, 175, 80);
            btnAdd.BorderColor = Color.FromArgb(76, 175, 80);
            btnAdd.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnAdd.DangerColor = Color.FromArgb(245, 108, 108);
            btnAdd.DefaultColor = Color.FromArgb(255, 255, 255);
            btnAdd.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnAdd.InfoColor = Color.FromArgb(144, 147, 153);
            btnAdd.Location = new Point(27, 641);
            btnAdd.Name = "btnAdd";
            btnAdd.PrimaryColor = Color.FromArgb(76, 175, 80);
            btnAdd.Size = new Size(170, 50);
            btnAdd.SuccessColor = Color.FromArgb(103, 194, 58);
            btnAdd.TabIndex = 48;
            btnAdd.Text = "Add ";
            btnAdd.TextColor = Color.White;
            btnAdd.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // hopeRoundButton9
            // 
            hopeRoundButton9.BackColor = Color.FromArgb(64, 158, 255);
            hopeRoundButton9.BorderColor = Color.FromArgb(64, 158, 255);
            hopeRoundButton9.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            hopeRoundButton9.DangerColor = Color.FromArgb(245, 108, 108);
            hopeRoundButton9.DefaultColor = Color.FromArgb(255, 255, 255);
            hopeRoundButton9.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hopeRoundButton9.ForeColor = Color.White;
            hopeRoundButton9.HoverTextColor = Color.FromArgb(48, 49, 51);
            hopeRoundButton9.InfoColor = Color.FromArgb(144, 147, 153);
            hopeRoundButton9.Location = new Point(700, 226);
            hopeRoundButton9.Name = "hopeRoundButton9";
            hopeRoundButton9.PrimaryColor = Color.FromArgb(64, 158, 255);
            hopeRoundButton9.Size = new Size(108, 41);
            hopeRoundButton9.SuccessColor = Color.FromArgb(103, 194, 58);
            hopeRoundButton9.TabIndex = 46;
            hopeRoundButton9.Text = "Search";
            hopeRoundButton9.TextColor = Color.White;
            hopeRoundButton9.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(64, 158, 255);
            btnUpdate.BorderColor = Color.FromArgb(64, 158, 255);
            btnUpdate.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnUpdate.DangerColor = Color.FromArgb(245, 108, 108);
            btnUpdate.DefaultColor = Color.FromArgb(255, 255, 255);
            btnUpdate.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnUpdate.InfoColor = Color.FromArgb(144, 147, 153);
            btnUpdate.Location = new Point(227, 641);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.PrimaryColor = Color.FromArgb(33, 150, 243);
            btnUpdate.Size = new Size(170, 50);
            btnUpdate.SuccessColor = Color.FromArgb(103, 194, 58);
            btnUpdate.TabIndex = 49;
            btnUpdate.Text = "Update";
            btnUpdate.TextColor = Color.White;
            btnUpdate.WarningColor = Color.FromArgb(230, 162, 60);
            btnUpdate.Click += btnUpdate_Click;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Century Gothic", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.DodgerBlue;
            bigLabel1.Location = new Point(23, 32);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(383, 56);
            bigLabel1.TabIndex = 44;
            bigLabel1.Text = "Staff Dashboard";
            // 
            // hopeButton2
            // 
            hopeButton2.BorderColor = Color.FromArgb(220, 223, 230);
            hopeButton2.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            hopeButton2.DangerColor = Color.FromArgb(245, 108, 108);
            hopeButton2.DefaultColor = Color.FromArgb(255, 255, 255);
            hopeButton2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hopeButton2.HoverTextColor = Color.FromArgb(48, 49, 51);
            hopeButton2.InfoColor = Color.FromArgb(144, 147, 153);
            hopeButton2.Location = new Point(335, 154);
            hopeButton2.Name = "hopeButton2";
            hopeButton2.PrimaryColor = Color.FromArgb(64, 158, 255);
            hopeButton2.Size = new Size(236, 50);
            hopeButton2.SuccessColor = Color.FromArgb(103, 194, 58);
            hopeButton2.TabIndex = 55;
            hopeButton2.Text = " Low inventory alert";
            hopeButton2.TextColor = Color.White;
            hopeButton2.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // btn_view
            // 
            btn_view.BackColor = Color.FromArgb(64, 158, 255);
            btn_view.BorderColor = Color.FromArgb(64, 158, 255);
            btn_view.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btn_view.DangerColor = Color.FromArgb(245, 108, 108);
            btn_view.DefaultColor = Color.FromArgb(255, 255, 255);
            btn_view.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_view.ForeColor = Color.White;
            btn_view.HoverTextColor = Color.FromArgb(48, 49, 51);
            btn_view.InfoColor = Color.FromArgb(144, 147, 153);
            btn_view.Location = new Point(635, 641);
            btn_view.Name = "btn_view";
            btn_view.PrimaryColor = Color.FromArgb(96, 125, 139);
            btn_view.Size = new Size(171, 50);
            btn_view.SuccessColor = Color.FromArgb(103, 194, 58);
            btn_view.TabIndex = 51;
            btn_view.Text = "View ";
            btn_view.TextColor = Color.White;
            btn_view.WarningColor = Color.FromArgb(230, 162, 60);
            btn_view.Click += hopeRoundButton8_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.BorderColor = Color.FromArgb(255, 152, 0);
            btnDelete.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnDelete.DangerColor = Color.FromArgb(245, 108, 108);
            btnDelete.DefaultColor = Color.FromArgb(255, 255, 255);
            btnDelete.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnDelete.InfoColor = Color.FromArgb(144, 147, 153);
            btnDelete.Location = new Point(437, 641);
            btnDelete.Name = "btnDelete";
            btnDelete.PrimaryColor = Color.Red;
            btnDelete.Size = new Size(170, 50);
            btnDelete.SuccessColor = Color.FromArgb(103, 194, 58);
            btnDelete.TabIndex = 50;
            btnDelete.Text = "Delete";
            btnDelete.TextColor = Color.White;
            btnDelete.WarningColor = Color.FromArgb(230, 162, 60);
            btnDelete.Click += btnDelete_Click;
            // 
            // bigLabel2
            // 
            bigLabel2.AutoSize = true;
            bigLabel2.BackColor = Color.Transparent;
            bigLabel2.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel2.ForeColor = Color.DodgerBlue;
            bigLabel2.Location = new Point(21, 226);
            bigLabel2.Name = "bigLabel2";
            bigLabel2.Size = new Size(426, 37);
            bigLabel2.TabIndex = 58;
            bigLabel2.Text = "Student Consultation Record";
            // 
            // bigLabel3
            // 
            bigLabel3.AutoSize = true;
            bigLabel3.BackColor = Color.Transparent;
            bigLabel3.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            bigLabel3.ForeColor = SystemColors.ActiveCaptionText;
            bigLabel3.Location = new Point(36, 94);
            bigLabel3.Name = "bigLabel3";
            bigLabel3.Size = new Size(296, 18);
            bigLabel3.TabIndex = 59;
            bigLabel3.Text = "Your Daily Tools for Better Student Care.";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(28, 125);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(288, 87);
            pictureBox2.TabIndex = 60;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(74, 155, 250);
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(56, 166);
            label1.Name = "label1";
            label1.Size = new Size(214, 19);
            label1.TabIndex = 61;
            label1.Text = "Total consultations today:";
            // 
            // dgvStudentRecords
            // 
            dgvStudentRecords.AllowUserToOrderColumns = true;
            dgvStudentRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudentRecords.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvStudentRecords.BackgroundColor = SystemColors.ControlLightLight;
            dgvStudentRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentRecords.Columns.AddRange(new DataGridViewColumn[] { StudentID, StudentName, Course, Symptoms, Medicine, DateVisited });
            dgvStudentRecords.GridColor = SystemColors.InactiveCaptionText;
            dgvStudentRecords.Location = new Point(35, 285);
            dgvStudentRecords.MultiSelect = false;
            dgvStudentRecords.Name = "dgvStudentRecords";
            dgvStudentRecords.ReadOnly = true;
            dgvStudentRecords.RowHeadersVisible = false;
            dgvStudentRecords.RowHeadersWidth = 51;
            dgvStudentRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudentRecords.Size = new Size(761, 340);
            dgvStudentRecords.TabIndex = 62;
            // 
            // StudentID
            // 
            StudentID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            StudentID.DataPropertyName = "StudentID";
            StudentID.HeaderText = "StudentID";
            StudentID.MinimumWidth = 6;
            StudentID.Name = "StudentID";
            StudentID.ReadOnly = true;
            StudentID.Width = 104;
            // 
            // StudentName
            // 
            StudentName.DataPropertyName = "StudentName";
            StudentName.HeaderText = "StudentName";
            StudentName.MinimumWidth = 6;
            StudentName.Name = "StudentName";
            StudentName.ReadOnly = true;
            // 
            // Course
            // 
            Course.DataPropertyName = "Course";
            Course.HeaderText = "Course";
            Course.MinimumWidth = 6;
            Course.Name = "Course";
            Course.ReadOnly = true;
            // 
            // Symptoms
            // 
            Symptoms.DataPropertyName = "Symptoms";
            Symptoms.HeaderText = "Symptoms";
            Symptoms.MinimumWidth = 6;
            Symptoms.Name = "Symptoms";
            Symptoms.ReadOnly = true;
            // 
            // Medicine
            // 
            Medicine.DataPropertyName = "Medicine";
            Medicine.HeaderText = "Medicine";
            Medicine.MinimumWidth = 6;
            Medicine.Name = "Medicine";
            Medicine.ReadOnly = true;
            // 
            // DateVisited
            // 
            DateVisited.DataPropertyName = "DateVisited";
            DateVisited.HeaderText = "DateVisited";
            DateVisited.MinimumWidth = 6;
            DateVisited.Name = "DateVisited";
            DateVisited.ReadOnly = true;
            // 
            // Total_0
            // 
            Total_0.AutoSize = true;
            Total_0.BackColor = Color.FromArgb(74, 155, 250);
            Total_0.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Total_0.ForeColor = Color.White;
            Total_0.Location = new Point(271, 167);
            Total_0.Name = "Total_0";
            Total_0.Size = new Size(19, 19);
            Total_0.TabIndex = 63;
            Total_0.Text = "0";
            // 
            // UC_Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(Total_0);
            Controls.Add(dgvStudentRecords);
            Controls.Add(label1);
            Controls.Add(bigLabel3);
            Controls.Add(bigLabel2);
            Controls.Add(hopeTextBox1);
            Controls.Add(pictureBox1);
            Controls.Add(btnAdd);
            Controls.Add(hopeRoundButton9);
            Controls.Add(btnUpdate);
            Controls.Add(bigLabel1);
            Controls.Add(hopeButton2);
            Controls.Add(btn_view);
            Controls.Add(btnDelete);
            Controls.Add(pictureBox2);
            Name = "UC_Home";
            Size = new Size(831, 704);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudentRecords).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.HopeTextBox hopeTextBox1;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.HopeRoundButton btnAdd;
        private ReaLTaiizor.Controls.HopeRoundButton hopeRoundButton9;
        private ReaLTaiizor.Controls.HopeRoundButton btnUpdate;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.HopeButton hopeButton2;
        private ReaLTaiizor.Controls.HopeRoundButton btn_view;
        private ReaLTaiizor.Controls.HopeRoundButton btnDelete;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private Label Total_0;
        private ReaLTaiizor.Controls.BigLabel bigLabel3;
        private PictureBox pictureBox2;
        private Label label1;
        private DataGridView dgvStudentRecords;
        private DataGridViewTextBoxColumn StudentID;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn Course;
        private DataGridViewTextBoxColumn Symptoms;
        private DataGridViewTextBoxColumn Medicine;
        private DataGridViewTextBoxColumn DateVisited;
    }
}
