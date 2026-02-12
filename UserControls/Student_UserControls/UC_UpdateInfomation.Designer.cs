namespace ClinicManagementSystem
{
    partial class UC_UpdateInfomation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_UpdateInfomation));
            sDasboard = new ReaLTaiizor.Controls.BigLabel();
            label1 = new Label();
            txtDisplayID = new TextBox();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            StudentID = new DataGridViewTextBoxColumn();
            StudentName = new DataGridViewTextBoxColumn();
            Course = new DataGridViewTextBoxColumn();
            Symptoms = new DataGridViewTextBoxColumn();
            DateVisited = new DataGridViewTextBoxColumn();
            hopeRoundButton1 = new ReaLTaiizor.Controls.HopeRoundButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // sDasboard
            // 
            sDasboard.AutoSize = true;
            sDasboard.BackColor = Color.Transparent;
            sDasboard.Font = new Font("Century Gothic", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sDasboard.ForeColor = Color.DodgerBlue;
            sDasboard.Location = new Point(23, 31);
            sDasboard.Name = "sDasboard";
            sDasboard.Size = new Size(536, 56);
            sDasboard.TabIndex = 19;
            sDasboard.Text = "Modify Student Record";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 100);
            label1.Name = "label1";
            label1.Size = new Size(267, 18);
            label1.TabIndex = 25;
            label1.Text = "Wellness Made Simple for Students.";
            // 
            // txtDisplayID
            // 
            txtDisplayID.BackColor = Color.White;
            txtDisplayID.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDisplayID.Location = new Point(29, 156);
            txtDisplayID.Name = "txtDisplayID";
            txtDisplayID.ReadOnly = true;
            txtDisplayID.Size = new Size(303, 26);
            txtDisplayID.TabIndex = 26;
            txtDisplayID.Text = "Student ID:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(711, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 61);
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.InactiveCaptionText;
            dataGridView1.Location = new Point(29, 207);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(754, 355);
            dataGridView1.TabIndex = 40;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // StudentID
            // 
            StudentID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            StudentID.HeaderText = "StudentID";
            StudentID.MinimumWidth = 6;
            StudentID.Name = "StudentID";
            StudentID.ReadOnly = true;
            StudentID.Width = 125;
            // 
            // StudentName
            // 
            StudentName.HeaderText = "StudentName";
            StudentName.MinimumWidth = 6;
            StudentName.Name = "StudentName";
            StudentName.ReadOnly = true;
            StudentName.Width = 125;
            // 
            // Course
            // 
            Course.HeaderText = "Course";
            Course.MinimumWidth = 6;
            Course.Name = "Course";
            Course.ReadOnly = true;
            Course.Width = 125;
            // 
            // Symptoms
            // 
            Symptoms.HeaderText = "Symptoms";
            Symptoms.MinimumWidth = 6;
            Symptoms.Name = "Symptoms";
            Symptoms.ReadOnly = true;
            Symptoms.Width = 125;
            // 
            // DateVisited
            // 
            DateVisited.HeaderText = "DateVisited";
            DateVisited.MinimumWidth = 6;
            DateVisited.Name = "DateVisited";
            DateVisited.ReadOnly = true;
            DateVisited.Width = 125;
            // 
            // hopeRoundButton1
            // 
            hopeRoundButton1.BackColor = Color.FromArgb(64, 158, 255);
            hopeRoundButton1.BorderColor = Color.FromArgb(64, 158, 255);
            hopeRoundButton1.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            hopeRoundButton1.DangerColor = Color.FromArgb(245, 108, 108);
            hopeRoundButton1.DefaultColor = Color.FromArgb(255, 255, 255);
            hopeRoundButton1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hopeRoundButton1.ForeColor = Color.White;
            hopeRoundButton1.HoverTextColor = Color.FromArgb(48, 49, 51);
            hopeRoundButton1.InfoColor = Color.FromArgb(144, 147, 153);
            hopeRoundButton1.Location = new Point(619, 582);
            hopeRoundButton1.Name = "hopeRoundButton1";
            hopeRoundButton1.PrimaryColor = Color.FromArgb(64, 158, 255);
            hopeRoundButton1.Size = new Size(167, 41);
            hopeRoundButton1.SuccessColor = Color.FromArgb(103, 194, 58);
            hopeRoundButton1.TabIndex = 41;
            hopeRoundButton1.Text = "Apply Changes";
            hopeRoundButton1.TextColor = Color.White;
            hopeRoundButton1.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // UC_UpdateInfomation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(hopeRoundButton1);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Controls.Add(txtDisplayID);
            Controls.Add(label1);
            Controls.Add(sDasboard);
            Name = "UC_UpdateInfomation";
            Size = new Size(812, 639);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel sDasboard;
        private Label label1;
        private TextBox txtDisplayID;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn StudentID;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn Course;
        private DataGridViewTextBoxColumn Symptoms;
        private DataGridViewTextBoxColumn Treatment;
        private DataGridViewTextBoxColumn DateVisited;
        private ReaLTaiizor.Controls.HopeRoundButton hopeRoundButton1;
    }
}
