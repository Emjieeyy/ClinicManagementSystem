
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            btnAdd = new ReaLTaiizor.Controls.HopeRoundButton();
            SearchBtn = new ReaLTaiizor.Controls.HopeRoundButton();
            btnUpdate = new ReaLTaiizor.Controls.HopeRoundButton();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            LowInvAlertBtn = new ReaLTaiizor.Controls.HopeButton();
            SaveBtn = new ReaLTaiizor.Controls.HopeRoundButton();
            btnDelete = new ReaLTaiizor.Controls.HopeRoundButton();
            bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            bigLabel3 = new ReaLTaiizor.Controls.BigLabel();
            pictureBox2 = new PictureBox();
            TotalConsultation = new Label();
            dgvStudentRecords = new DataGridView();
            StudentID = new DataGridViewTextBoxColumn();
            StudentName = new DataGridViewTextBoxColumn();
            Course = new DataGridViewTextBoxColumn();
            Symptoms = new DataGridViewTextBoxColumn();
            Medicine = new DataGridViewTextBoxColumn();
            DateVisited = new DataGridViewTextBoxColumn();
            Total_0 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudentRecords).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(716, 23);
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
            btnAdd.Click += btnAdd_Click;
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = Color.FromArgb(64, 158, 255);
            SearchBtn.BorderColor = Color.FromArgb(64, 158, 255);
            SearchBtn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            SearchBtn.DangerColor = Color.FromArgb(245, 108, 108);
            SearchBtn.DefaultColor = Color.FromArgb(255, 255, 255);
            SearchBtn.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchBtn.ForeColor = Color.White;
            SearchBtn.HoverTextColor = Color.FromArgb(48, 49, 51);
            SearchBtn.InfoColor = Color.FromArgb(144, 147, 153);
            SearchBtn.Location = new Point(700, 226);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.PrimaryColor = Color.FromArgb(64, 158, 255);
            SearchBtn.Size = new Size(108, 41);
            SearchBtn.SuccessColor = Color.FromArgb(103, 194, 58);
            SearchBtn.TabIndex = 46;
            SearchBtn.Text = "Search";
            SearchBtn.TextColor = Color.White;
            SearchBtn.WarningColor = Color.FromArgb(230, 162, 60);
            SearchBtn.Click += SearchBtn_Click;
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
            // LowInvAlertBtn
            // 
            LowInvAlertBtn.BorderColor = Color.FromArgb(220, 223, 230);
            LowInvAlertBtn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            LowInvAlertBtn.DangerColor = Color.FromArgb(245, 108, 108);
            LowInvAlertBtn.DefaultColor = Color.FromArgb(255, 255, 255);
            LowInvAlertBtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LowInvAlertBtn.HoverTextColor = Color.FromArgb(48, 49, 51);
            LowInvAlertBtn.InfoColor = Color.FromArgb(144, 147, 153);
            LowInvAlertBtn.Location = new Point(335, 154);
            LowInvAlertBtn.Name = "LowInvAlertBtn";
            LowInvAlertBtn.PrimaryColor = Color.FromArgb(64, 158, 255);
            LowInvAlertBtn.Size = new Size(236, 50);
            LowInvAlertBtn.SuccessColor = Color.FromArgb(103, 194, 58);
            LowInvAlertBtn.TabIndex = 55;
            LowInvAlertBtn.Text = " Low inventory alert";
            LowInvAlertBtn.TextColor = Color.White;
            LowInvAlertBtn.WarningColor = Color.FromArgb(230, 162, 60);
            LowInvAlertBtn.Click += LowInvAlertBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.FromArgb(64, 158, 255);
            SaveBtn.BorderColor = Color.FromArgb(64, 158, 255);
            SaveBtn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            SaveBtn.DangerColor = Color.FromArgb(245, 108, 108);
            SaveBtn.DefaultColor = Color.FromArgb(255, 255, 255);
            SaveBtn.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveBtn.ForeColor = Color.White;
            SaveBtn.HoverTextColor = Color.FromArgb(48, 49, 51);
            SaveBtn.InfoColor = Color.FromArgb(144, 147, 153);
            SaveBtn.Location = new Point(635, 641);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.PrimaryColor = Color.FromArgb(96, 125, 139);
            SaveBtn.Size = new Size(171, 50);
            SaveBtn.SuccessColor = Color.FromArgb(103, 194, 58);
            SaveBtn.TabIndex = 51;
            SaveBtn.Text = "Save";
            SaveBtn.TextColor = Color.White;
            SaveBtn.WarningColor = Color.FromArgb(230, 162, 60);
            SaveBtn.Click += SaveBtn_Click;
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
            // TotalConsultation
            // 
            TotalConsultation.AutoSize = true;
            TotalConsultation.BackColor = Color.FromArgb(74, 155, 250);
            TotalConsultation.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalConsultation.ForeColor = Color.White;
            TotalConsultation.Location = new Point(56, 166);
            TotalConsultation.Name = "TotalConsultation";
            TotalConsultation.Size = new Size(219, 19);
            TotalConsultation.TabIndex = 61;
            TotalConsultation.Text = "Total consultations today: ";
            // 
            // dgvStudentRecords
            // 
            dgvStudentRecords.AllowUserToOrderColumns = true;
            dgvStudentRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudentRecords.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvStudentRecords.BackgroundColor = Color.White;
            dgvStudentRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentRecords.Columns.AddRange(new DataGridViewColumn[] { StudentID, StudentName, Course, Symptoms, Medicine, DateVisited });
            dgvStudentRecords.EnableHeadersVisualStyles = false;
            dgvStudentRecords.GridColor = Color.Gainsboro;
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
            dataGridViewCellStyle1.Font = new Font("Segoe Fluent Icons", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Blue;
            StudentID.DefaultCellStyle = dataGridViewCellStyle1;
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
            Total_0.Size = new Size(0, 19);
            Total_0.TabIndex = 63;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(509, 226);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(173, 27);
            textBox1.TabIndex = 64;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // UC_Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(textBox1);
            Controls.Add(Total_0);
            Controls.Add(dgvStudentRecords);
            Controls.Add(TotalConsultation);
            Controls.Add(bigLabel3);
            Controls.Add(bigLabel2);
            Controls.Add(pictureBox1);
            Controls.Add(btnAdd);
            Controls.Add(SearchBtn);
            Controls.Add(btnUpdate);
            Controls.Add(bigLabel1);
            Controls.Add(LowInvAlertBtn);
            Controls.Add(SaveBtn);
            Controls.Add(btnDelete);
            Controls.Add(pictureBox2);
            Name = "UC_Home";
            Size = new Size(827, 700);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudentRecords).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.HopeRoundButton btnAdd;
        private ReaLTaiizor.Controls.HopeRoundButton SearchBtn;
        private ReaLTaiizor.Controls.HopeRoundButton btnUpdate;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.HopeButton LowInvAlertBtn;
        private ReaLTaiizor.Controls.HopeRoundButton SaveBtn;
        private ReaLTaiizor.Controls.HopeRoundButton btnDelete;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private Label Total_0;
        private ReaLTaiizor.Controls.BigLabel bigLabel3;
        private PictureBox pictureBox2;
        private Label TotalConsultation;
        private DataGridView dgvStudentRecords;
        private DataGridViewTextBoxColumn StudentID;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn Course;
        private DataGridViewTextBoxColumn Symptoms;
        private DataGridViewTextBoxColumn Medicine;
        private DataGridViewTextBoxColumn DateVisited;
        private TextBox textBox1;
    }
}
