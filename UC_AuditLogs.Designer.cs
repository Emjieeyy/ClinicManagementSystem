namespace ClinicManagementSystem
{
    partial class UC_AuditLogs
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            titleLabel = new Label();
            dataGridView1 = new DataGridView();
            Timestamp = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            Activity = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            StatusCol = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            clearLogsBtn = new ReaLTaiizor.Controls.HopeRoundButton();
            exportBtn = new ReaLTaiizor.Controls.HopeRoundButton();
            refreshBtn = new ReaLTaiizor.Controls.HopeRoundButton();
            searchBtn = new ReaLTaiizor.Controls.HopeRoundButton();
            searchTextBox = new TextBox();
            filterComboBox = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            titleLabel.ForeColor = Color.FromArgb(32, 129, 226);
            titleLabel.Location = new Point(30, 30);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(210, 54);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Audit Logs";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(32, 129, 226);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Timestamp, Username, Activity, Description, StatusCol });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(189, 233, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(30, 200);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1030, 450);
            dataGridView1.TabIndex = 1;
            // 
            // Timestamp
            // 
            Timestamp.HeaderText = "Timestamp";
            Timestamp.MinimumWidth = 6;
            Timestamp.Name = "Timestamp";
            Timestamp.ReadOnly = true;
            // 
            // Username
            // 
            Username.HeaderText = "Username";
            Username.MinimumWidth = 6;
            Username.Name = "Username";
            Username.ReadOnly = true;
            // 
            // Activity
            // 
            Activity.HeaderText = "Activity";
            Activity.MinimumWidth = 6;
            Activity.Name = "Activity";
            Activity.ReadOnly = true;
            // 
            // Description
            // 
            Description.HeaderText = "Description";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            Description.ReadOnly = true;
            // 
            // StatusCol
            // 
            StatusCol.HeaderText = "Status";
            StatusCol.MinimumWidth = 6;
            StatusCol.Name = "StatusCol";
            StatusCol.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(clearLogsBtn);
            panel1.Controls.Add(exportBtn);
            panel1.Controls.Add(refreshBtn);
            panel1.Controls.Add(searchBtn);
            panel1.Controls.Add(searchTextBox);
            panel1.Controls.Add(filterComboBox);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(30, 110);
            panel1.Name = "panel1";
            panel1.Size = new Size(1030, 75);
            panel1.TabIndex = 2;
            // 
            // clearLogsBtn
            // 
            clearLogsBtn.BorderColor = Color.FromArgb(220, 223, 230);
            clearLogsBtn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Danger;
            clearLogsBtn.Cursor = Cursors.Hand;
            clearLogsBtn.DangerColor = Color.FromArgb(245, 108, 108);
            clearLogsBtn.DefaultColor = Color.FromArgb(255, 255, 255);
            clearLogsBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            clearLogsBtn.HoverTextColor = Color.White;
            clearLogsBtn.InfoColor = Color.FromArgb(144, 147, 153);
            clearLogsBtn.Location = new Point(450, 17);
            clearLogsBtn.Name = "clearLogsBtn";
            clearLogsBtn.PrimaryColor = Color.FromArgb(64, 158, 255);
            clearLogsBtn.Size = new Size(110, 40);
            clearLogsBtn.SuccessColor = Color.FromArgb(103, 194, 58);
            clearLogsBtn.TabIndex = 6;
            clearLogsBtn.Text = "Clear Logs";
            clearLogsBtn.TextColor = Color.White;
            clearLogsBtn.WarningColor = Color.FromArgb(230, 162, 60);
            clearLogsBtn.Click += clearLogsBtn_Click;
            // 
            // exportBtn
            // 
            exportBtn.BorderColor = Color.FromArgb(220, 223, 230);
            exportBtn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            exportBtn.Cursor = Cursors.Hand;
            exportBtn.DangerColor = Color.FromArgb(245, 108, 108);
            exportBtn.DefaultColor = Color.FromArgb(255, 255, 255);
            exportBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            exportBtn.HoverTextColor = Color.White;
            exportBtn.InfoColor = Color.FromArgb(144, 147, 153);
            exportBtn.Location = new Point(335, 17);
            exportBtn.Name = "exportBtn";
            exportBtn.PrimaryColor = Color.FromArgb(64, 158, 255);
            exportBtn.Size = new Size(100, 40);
            exportBtn.SuccessColor = Color.FromArgb(103, 194, 58);
            exportBtn.TabIndex = 5;
            exportBtn.Text = "Export";
            exportBtn.TextColor = Color.White;
            exportBtn.WarningColor = Color.FromArgb(230, 162, 60);
            exportBtn.Click += exportBtn_Click;
            // 
            // refreshBtn
            // 
            refreshBtn.BorderColor = Color.FromArgb(220, 223, 230);
            refreshBtn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Success;
            refreshBtn.Cursor = Cursors.Hand;
            refreshBtn.DangerColor = Color.FromArgb(245, 108, 108);
            refreshBtn.DefaultColor = Color.FromArgb(255, 255, 255);
            refreshBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            refreshBtn.HoverTextColor = Color.White;
            refreshBtn.InfoColor = Color.FromArgb(144, 147, 153);
            refreshBtn.Location = new Point(220, 17);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.PrimaryColor = Color.FromArgb(64, 158, 255);
            refreshBtn.Size = new Size(100, 40);
            refreshBtn.SuccessColor = Color.FromArgb(103, 194, 58);
            refreshBtn.TabIndex = 4;
            refreshBtn.Text = "Refresh";
            refreshBtn.TextColor = Color.White;
            refreshBtn.WarningColor = Color.FromArgb(230, 162, 60);
            refreshBtn.Click += refreshBtn_Click;
            // 
            // searchBtn
            // 
            searchBtn.BorderColor = Color.FromArgb(220, 223, 230);
            searchBtn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            searchBtn.Cursor = Cursors.Hand;
            searchBtn.DangerColor = Color.FromArgb(245, 108, 108);
            searchBtn.DefaultColor = Color.FromArgb(255, 255, 255);
            searchBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            searchBtn.HoverTextColor = Color.White;
            searchBtn.InfoColor = Color.FromArgb(144, 147, 153);
            searchBtn.Location = new Point(910, 17);
            searchBtn.Name = "searchBtn";
            searchBtn.PrimaryColor = Color.FromArgb(64, 158, 255);
            searchBtn.Size = new Size(100, 40);
            searchBtn.SuccessColor = Color.FromArgb(103, 194, 58);
            searchBtn.TabIndex = 3;
            searchBtn.Text = "Search";
            searchBtn.TextColor = Color.White;
            searchBtn.WarningColor = Color.FromArgb(230, 162, 60);
            searchBtn.Click += searchBtn_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Font = new Font("Segoe UI", 10F);
            searchTextBox.Location = new Point(660, 22);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PlaceholderText = "Search logs...";
            searchTextBox.Size = new Size(235, 30);
            searchTextBox.TabIndex = 2;
            // 
            // filterComboBox
            // 
            filterComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            filterComboBox.Font = new Font("Segoe UI", 10F);
            filterComboBox.FormattingEnabled = true;
            filterComboBox.Items.AddRange(new object[] { "All Activities", "Login", "User Management", "Inventory", "Settings", "Backup", "Reports" });
            filterComboBox.Location = new Point(20, 22);
            filterComboBox.Name = "filterComboBox";
            filterComboBox.Size = new Size(180, 31);
            filterComboBox.TabIndex = 1;
            filterComboBox.SelectedIndexChanged += filterComboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(20, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 0;
            label1.Text = "Filter by Activity";
            // 
            // UC_AuditLogs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(titleLabel);
            Name = "UC_AuditLogs";
            Size = new Size(1093, 701);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label1;
        private ComboBox filterComboBox;
        private TextBox searchTextBox;
        private ReaLTaiizor.Controls.HopeRoundButton searchBtn;
        private ReaLTaiizor.Controls.HopeRoundButton refreshBtn;
        private ReaLTaiizor.Controls.HopeRoundButton exportBtn;
        private ReaLTaiizor.Controls.HopeRoundButton clearLogsBtn;
        private DataGridViewTextBoxColumn Timestamp;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Activity;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn StatusCol;
    }
}
