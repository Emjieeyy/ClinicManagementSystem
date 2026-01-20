namespace ClinicManagementSystem
{
    partial class UC_UserManagement
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
            UserID = new DataGridViewTextBoxColumn();
            UserName = new DataGridViewTextBoxColumn();
            Role = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            addUserBtn = new ReaLTaiizor.Controls.HopeRoundButton();
            editUserBtn = new ReaLTaiizor.Controls.HopeRoundButton();
            deleteUserBtn = new ReaLTaiizor.Controls.HopeRoundButton();
            searchTextBox = new TextBox();
            searchBtn = new ReaLTaiizor.Controls.HopeRoundButton();
            panel1 = new Panel();
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
            titleLabel.Size = new Size(342, 54);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "User Management";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { UserID, UserName, Role, Email, Status });
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
            dataGridView1.Size = new Size(1030, 400);
            dataGridView1.TabIndex = 1;
            // 
            // UserID
            // 
            UserID.HeaderText = "User ID";
            UserID.MinimumWidth = 6;
            UserID.Name = "UserID";
            UserID.ReadOnly = true;
            // 
            // UserName
            // 
            UserName.HeaderText = "Name";
            UserName.MinimumWidth = 6;
            UserName.Name = "UserName";
            UserName.ReadOnly = true;
            // 
            // Role
            // 
            Role.HeaderText = "Role";
            Role.MinimumWidth = 6;
            Role.Name = "Role";
            Role.ReadOnly = true;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // addUserBtn
            // 
            addUserBtn.BorderColor = Color.FromArgb(220, 223, 230);
            addUserBtn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Success;
            addUserBtn.Cursor = Cursors.Hand;
            addUserBtn.DangerColor = Color.FromArgb(245, 108, 108);
            addUserBtn.DefaultColor = Color.FromArgb(255, 255, 255);
            addUserBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            addUserBtn.HoverTextColor = Color.White;
            addUserBtn.InfoColor = Color.FromArgb(144, 147, 153);
            addUserBtn.Location = new Point(15, 20);
            addUserBtn.Name = "addUserBtn";
            addUserBtn.PrimaryColor = Color.FromArgb(64, 158, 255);
            addUserBtn.Size = new Size(120, 45);
            addUserBtn.SuccessColor = Color.FromArgb(103, 194, 58);
            addUserBtn.TabIndex = 2;
            addUserBtn.Text = "Add User";
            addUserBtn.TextColor = Color.White;
            addUserBtn.WarningColor = Color.FromArgb(230, 162, 60);
            addUserBtn.Click += addUserBtn_Click;
            // 
            // editUserBtn
            // 
            editUserBtn.BorderColor = Color.FromArgb(220, 223, 230);
            editUserBtn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            editUserBtn.Cursor = Cursors.Hand;
            editUserBtn.DangerColor = Color.FromArgb(245, 108, 108);
            editUserBtn.DefaultColor = Color.FromArgb(255, 255, 255);
            editUserBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            editUserBtn.HoverTextColor = Color.White;
            editUserBtn.InfoColor = Color.FromArgb(144, 147, 153);
            editUserBtn.Location = new Point(150, 20);
            editUserBtn.Name = "editUserBtn";
            editUserBtn.PrimaryColor = Color.FromArgb(64, 158, 255);
            editUserBtn.Size = new Size(120, 45);
            editUserBtn.SuccessColor = Color.FromArgb(103, 194, 58);
            editUserBtn.TabIndex = 3;
            editUserBtn.Text = "Edit User";
            editUserBtn.TextColor = Color.White;
            editUserBtn.WarningColor = Color.FromArgb(230, 162, 60);
            editUserBtn.Click += editUserBtn_Click;
            // 
            // deleteUserBtn
            // 
            deleteUserBtn.BorderColor = Color.FromArgb(220, 223, 230);
            deleteUserBtn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Danger;
            deleteUserBtn.Cursor = Cursors.Hand;
            deleteUserBtn.DangerColor = Color.FromArgb(245, 108, 108);
            deleteUserBtn.DefaultColor = Color.FromArgb(255, 255, 255);
            deleteUserBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            deleteUserBtn.HoverTextColor = Color.White;
            deleteUserBtn.InfoColor = Color.FromArgb(144, 147, 153);
            deleteUserBtn.Location = new Point(285, 20);
            deleteUserBtn.Name = "deleteUserBtn";
            deleteUserBtn.PrimaryColor = Color.FromArgb(64, 158, 255);
            deleteUserBtn.Size = new Size(130, 45);
            deleteUserBtn.SuccessColor = Color.FromArgb(103, 194, 58);
            deleteUserBtn.TabIndex = 4;
            deleteUserBtn.Text = "Delete User";
            deleteUserBtn.TextColor = Color.White;
            deleteUserBtn.WarningColor = Color.FromArgb(230, 162, 60);
            deleteUserBtn.Click += deleteUserBtn_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Font = new Font("Segoe UI", 11F);
            searchTextBox.Location = new Point(655, 27);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PlaceholderText = "Search users...";
            searchTextBox.Size = new Size(250, 32);
            searchTextBox.TabIndex = 5;
            // 
            // searchBtn
            // 
            searchBtn.BorderColor = Color.FromArgb(220, 223, 230);
            searchBtn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            searchBtn.Cursor = Cursors.Hand;
            searchBtn.DangerColor = Color.FromArgb(245, 108, 108);
            searchBtn.DefaultColor = Color.FromArgb(255, 255, 255);
            searchBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            searchBtn.HoverTextColor = Color.White;
            searchBtn.InfoColor = Color.FromArgb(144, 147, 153);
            searchBtn.Location = new Point(920, 20);
            searchBtn.Name = "searchBtn";
            searchBtn.PrimaryColor = Color.FromArgb(64, 158, 255);
            searchBtn.Size = new Size(100, 45);
            searchBtn.SuccessColor = Color.FromArgb(103, 194, 58);
            searchBtn.TabIndex = 6;
            searchBtn.Text = "Search";
            searchBtn.TextColor = Color.White;
            searchBtn.WarningColor = Color.FromArgb(230, 162, 60);
            searchBtn.Click += searchBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(addUserBtn);
            panel1.Controls.Add(searchBtn);
            panel1.Controls.Add(editUserBtn);
            panel1.Controls.Add(searchTextBox);
            panel1.Controls.Add(deleteUserBtn);
            panel1.Location = new Point(30, 110);
            panel1.Name = "panel1";
            panel1.Size = new Size(1030, 75);
            panel1.TabIndex = 7;
            // 
            // UC_UserManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(titleLabel);
            Name = "UC_UserManagement";
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
        private ReaLTaiizor.Controls.HopeRoundButton addUserBtn;
        private ReaLTaiizor.Controls.HopeRoundButton editUserBtn;
        private ReaLTaiizor.Controls.HopeRoundButton deleteUserBtn;
        private TextBox searchTextBox;
        private ReaLTaiizor.Controls.HopeRoundButton searchBtn;
        private Panel panel1;
        private DataGridViewTextBoxColumn UserID;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn Role;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Status;
    }
}
