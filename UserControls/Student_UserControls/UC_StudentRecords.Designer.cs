namespace ClinicManagementSystem
{
    partial class UC_StudentRecords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_StudentRecords));
            label1 = new Label();
            dgvUCStudentRecords = new DataGridView();
            StudentID = new DataGridViewTextBoxColumn();
            StudentName = new DataGridViewTextBoxColumn();
            Course = new DataGridViewTextBoxColumn();
            Symptoms = new DataGridViewTextBoxColumn();
            Medicine = new DataGridViewTextBoxColumn();
            DateVisited = new DataGridViewTextBoxColumn();
            bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            hopeRoundButton9 = new ReaLTaiizor.Controls.HopeRoundButton();
            hopeTextBox1 = new ReaLTaiizor.Controls.HopeTextBox();
            pictureBox1 = new PictureBox();
            sDasboard = new ReaLTaiizor.Controls.BigLabel();
            ((System.ComponentModel.ISupportInitialize)dgvUCStudentRecords).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 102);
            label1.Name = "label1";
            label1.Size = new Size(267, 18);
            label1.TabIndex = 24;
            label1.Text = "Wellness Made Simple for Students.";
            // 
            // dgvUCStudentRecords
            // 
            dgvUCStudentRecords.AllowUserToAddRows = false;
            dgvUCStudentRecords.AllowUserToDeleteRows = false;
            dgvUCStudentRecords.AllowUserToResizeColumns = false;
            dgvUCStudentRecords.AllowUserToResizeRows = false;
            dgvUCStudentRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUCStudentRecords.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvUCStudentRecords.BackgroundColor = SystemColors.ControlLightLight;
            dgvUCStudentRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUCStudentRecords.Columns.AddRange(new DataGridViewColumn[] { StudentID, StudentName, Course, Symptoms, Medicine, DateVisited });
            dgvUCStudentRecords.GridColor = SystemColors.InactiveCaptionText;
            dgvUCStudentRecords.Location = new Point(23, 216);
            dgvUCStudentRecords.MultiSelect = false;
            dgvUCStudentRecords.Name = "dgvUCStudentRecords";
            dgvUCStudentRecords.ReadOnly = true;
            dgvUCStudentRecords.RowHeadersVisible = false;
            dgvUCStudentRecords.RowHeadersWidth = 51;
            dgvUCStudentRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUCStudentRecords.Size = new Size(761, 355);
            dgvUCStudentRecords.TabIndex = 23;
            dgvUCStudentRecords.CellContentClick += dataGridView1_CellContentClick;
            dgvUCStudentRecords.CellValidating += dgvUCStudentRecords_CellValidating;
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
            // bigLabel2
            // 
            bigLabel2.AutoSize = true;
            bigLabel2.BackColor = Color.Transparent;
            bigLabel2.Font = new Font("Century Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel2.ForeColor = Color.DodgerBlue;
            bigLabel2.Location = new Point(16, 155);
            bigLabel2.Name = "bigLabel2";
            bigLabel2.Size = new Size(228, 44);
            bigLabel2.TabIndex = 22;
            bigLabel2.Text = "My Records";
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
            hopeRoundButton9.Location = new Point(672, 156);
            hopeRoundButton9.Name = "hopeRoundButton9";
            hopeRoundButton9.PrimaryColor = Color.FromArgb(64, 158, 255);
            hopeRoundButton9.Size = new Size(112, 41);
            hopeRoundButton9.SuccessColor = Color.FromArgb(103, 194, 58);
            hopeRoundButton9.TabIndex = 21;
            hopeRoundButton9.Text = "Search";
            hopeRoundButton9.TextColor = Color.White;
            hopeRoundButton9.WarningColor = Color.FromArgb(230, 162, 60);
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
            hopeTextBox1.Location = new Point(368, 162);
            hopeTextBox1.MaxLength = 32767;
            hopeTextBox1.Multiline = false;
            hopeTextBox1.Name = "hopeTextBox1";
            hopeTextBox1.PasswordChar = '\0';
            hopeTextBox1.ScrollBars = ScrollBars.None;
            hopeTextBox1.SelectedText = "";
            hopeTextBox1.SelectionLength = 0;
            hopeTextBox1.SelectionStart = 0;
            hopeTextBox1.Size = new Size(298, 35);
            hopeTextBox1.TabIndex = 20;
            hopeTextBox1.TabStop = false;
            hopeTextBox1.UseSystemPasswordChar = false;
            hopeTextBox1.Click += hopeTextBox1_Click;
            hopeTextBox1.TextAlignChanged += hopeTextBox1_TextAlignChanged;
            hopeTextBox1.TextChanged += hopeTextBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(681, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 62);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // sDasboard
            // 
            sDasboard.AutoSize = true;
            sDasboard.BackColor = Color.Transparent;
            sDasboard.Font = new Font("Century Gothic", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sDasboard.ForeColor = Color.DodgerBlue;
            sDasboard.Location = new Point(15, 39);
            sDasboard.Name = "sDasboard";
            sDasboard.Size = new Size(457, 56);
            sDasboard.TabIndex = 18;
            sDasboard.Text = "Student Dashboard";
            // 
            // UC_StudentRecords
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label1);
            Controls.Add(dgvUCStudentRecords);
            Controls.Add(bigLabel2);
            Controls.Add(hopeRoundButton9);
            Controls.Add(hopeTextBox1);
            Controls.Add(pictureBox1);
            Controls.Add(sDasboard);
            Name = "UC_StudentRecords";
            Size = new Size(813, 601);
            ((System.ComponentModel.ISupportInitialize)dgvUCStudentRecords).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvUCStudentRecords;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private ReaLTaiizor.Controls.HopeRoundButton hopeRoundButton9;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBox1;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.BigLabel sDasboard;
        private DataGridViewTextBoxColumn StudentID;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn Course;
        private DataGridViewTextBoxColumn Symptoms;
        private DataGridViewTextBoxColumn Medicine;
        private DataGridViewTextBoxColumn DateVisited;
    }
}
