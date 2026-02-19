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
            SearchInfo = new TextBox();
            pictureBox1 = new PictureBox();
            StudentID = new DataGridViewTextBoxColumn();
            StudentName = new DataGridViewTextBoxColumn();
            Course = new DataGridViewTextBoxColumn();
            Symptoms = new DataGridViewTextBoxColumn();
            DateVisited = new DataGridViewTextBoxColumn();
            hopeRoundButton1 = new ReaLTaiizor.Controls.HopeRoundButton();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            Medicine = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            label2 = new Label();
            SearchBtn = new ReaLTaiizor.Controls.HopeRoundButton();
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
            // SearchInfo
            // 
            SearchInfo.BackColor = Color.White;
            SearchInfo.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchInfo.Location = new Point(23, 159);
            SearchInfo.Name = "SearchInfo";
            SearchInfo.ReadOnly = true;
            SearchInfo.Size = new Size(186, 26);
            SearchInfo.TabIndex = 26;
            SearchInfo.Text = "Search...";
            SearchInfo.TextChanged += SearchInfo_TextChanged;
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
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, Medicine, dataGridViewTextBoxColumn5 });
            dataGridView1.GridColor = SystemColors.InactiveCaptionText;
            dataGridView1.Location = new Point(23, 207);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(761, 355);
            dataGridView1.TabIndex = 42;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn1.DataPropertyName = "StudentID";
            dataGridViewTextBoxColumn1.HeaderText = "StudentID";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 104;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "StudentName";
            dataGridViewTextBoxColumn2.HeaderText = "StudentName";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Course";
            dataGridViewTextBoxColumn3.HeaderText = "Course";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Symptoms";
            dataGridViewTextBoxColumn4.HeaderText = "Symptoms";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Medicine
            // 
            Medicine.DataPropertyName = "Medicine";
            Medicine.HeaderText = "Medicine";
            Medicine.MinimumWidth = 6;
            Medicine.Name = "Medicine";
            Medicine.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "DateVisited";
            dataGridViewTextBoxColumn5.HeaderText = "DateVisited";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 169);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 43;
            label2.Click += label2_Click;
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = Color.FromArgb(64, 158, 255);
            SearchBtn.BorderColor = Color.FromArgb(64, 158, 255);
            SearchBtn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            SearchBtn.DangerColor = Color.FromArgb(245, 108, 108);
            SearchBtn.DefaultColor = Color.FromArgb(255, 255, 255);
            SearchBtn.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            SearchBtn.HoverTextColor = Color.FromArgb(48, 49, 51);
            SearchBtn.InfoColor = Color.FromArgb(144, 147, 153);
            SearchBtn.Location = new Point(232, 151);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.PrimaryColor = Color.FromArgb(64, 158, 255);
            SearchBtn.Size = new Size(108, 38);
            SearchBtn.SuccessColor = Color.FromArgb(103, 194, 58);
            SearchBtn.TabIndex = 44;
            SearchBtn.Text = "Search";
            SearchBtn.TextColor = Color.White;
            SearchBtn.WarningColor = Color.FromArgb(230, 162, 60);
            SearchBtn.Click += SearchBtn_Click;
            // 
            // UC_UpdateInfomation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(SearchBtn);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(hopeRoundButton1);
            Controls.Add(pictureBox1);
            Controls.Add(SearchInfo);
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
        private TextBox SearchInfo;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn StudentID;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn Course;
        private DataGridViewTextBoxColumn Symptoms;
        private DataGridViewTextBoxColumn Treatment;
        private DataGridViewTextBoxColumn DateVisited;
        private ReaLTaiizor.Controls.HopeRoundButton hopeRoundButton1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn Medicine;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Label label2;
        private ReaLTaiizor.Controls.HopeRoundButton SearchBtn;
    }
}
