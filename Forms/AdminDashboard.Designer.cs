namespace ClinicManagementSystem.Forms
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            student_navbar = new Panel();
            pictureBox6 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox8 = new PictureBox();
            LogOutbtn = new ReaLTaiizor.Controls.HopeRoundButton();
            AuditLogsbtn = new ReaLTaiizor.Controls.HopeRoundButton();
            pictureBox2 = new PictureBox();
            UserManagementbtn = new ReaLTaiizor.Controls.HopeRoundButton();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            pictureBox1 = new PictureBox();
            Searchbtn = new ReaLTaiizor.Controls.HopeRoundButton();
            txtSearchTab1 = new TextBox();
            dgvUsers = new DataGridView();
            UserID_clmn = new DataGridViewTextBoxColumn();
            Name_clmn = new DataGridViewTextBoxColumn();
            Role_clmn = new DataGridViewTextBoxColumn();
            Email_clmn = new DataGridViewTextBoxColumn();
            Status_clmn = new DataGridViewTextBoxColumn();
            RecentLogPnl = new Panel();
            RecentLogs_label_0 = new Label();
            label5 = new Label();
            TotalUserPnl = new Panel();
            TotalUserlabel_0 = new Label();
            label2 = new Label();
            DeleteUserbtn = new ReaLTaiizor.Controls.HopeRoundButton();
            UpdateUserbtn = new ReaLTaiizor.Controls.HopeRoundButton();
            AddUserbtn = new ReaLTaiizor.Controls.HopeRoundButton();
            label1 = new Label();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            tabPage2 = new TabPage();
            label6 = new Label();
            Tab2_ClearLogsbt = new ReaLTaiizor.Controls.HopeRoundButton();
            pictureBox4 = new PictureBox();
            Filterlabel = new Label();
            Tab2_Seachbtn = new ReaLTaiizor.Controls.HopeRoundButton();
            Tab2_Searchtxtbx = new TextBox();
            dgvAuditLogs = new DataGridView();
            Tab2Timestamp_clmn = new DataGridViewTextBoxColumn();
            Tab2Email_clmn = new DataGridViewTextBoxColumn();
            Tab2Activity_clmn = new DataGridViewTextBoxColumn();
            Tab2Description_clmn = new DataGridViewTextBoxColumn();
            Tab2Status_clmn = new DataGridViewTextBoxColumn();
            Tab2_Exportbtn = new ReaLTaiizor.Controls.HopeRoundButton();
            Refreshbt = new ReaLTaiizor.Controls.HopeRoundButton();
            cmbFilterActivity = new ComboBox();
            bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            student_navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            RecentLogPnl.SuspendLayout();
            TotalUserPnl.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAuditLogs).BeginInit();
            SuspendLayout();
            // 
            // student_navbar
            // 
            student_navbar.BackColor = Color.FromArgb(64, 158, 255);
            student_navbar.Controls.Add(pictureBox6);
            student_navbar.Controls.Add(pictureBox3);
            student_navbar.Controls.Add(pictureBox8);
            student_navbar.Controls.Add(LogOutbtn);
            student_navbar.Controls.Add(AuditLogsbtn);
            student_navbar.Controls.Add(pictureBox2);
            student_navbar.Controls.Add(UserManagementbtn);
            student_navbar.Dock = DockStyle.Left;
            student_navbar.Location = new Point(0, 0);
            student_navbar.Name = "student_navbar";
            student_navbar.Size = new Size(307, 625);
            student_navbar.TabIndex = 2;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.FromArgb(189, 233, 255);
            pictureBox6.BackgroundImage = (Image)resources.GetObject("pictureBox6.BackgroundImage");
            pictureBox6.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox6.Location = new Point(48, 380);
            pictureBox6.Margin = new Padding(3, 3, 3, 2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(40, 31);
            pictureBox6.TabIndex = 18;
            pictureBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(189, 233, 255);
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(48, 284);
            pictureBox3.Margin = new Padding(3, 3, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 31);
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.FromArgb(189, 233, 255);
            pictureBox8.BackgroundImage = (Image)resources.GetObject("pictureBox8.BackgroundImage");
            pictureBox8.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox8.Location = new Point(48, 192);
            pictureBox8.Margin = new Padding(3, 3, 3, 2);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(40, 31);
            pictureBox8.TabIndex = 14;
            pictureBox8.TabStop = false;
            // 
            // LogOutbtn
            // 
            LogOutbtn.BackColor = Color.FromArgb(189, 233, 255);
            LogOutbtn.BorderColor = Color.FromArgb(189, 233, 255);
            LogOutbtn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            LogOutbtn.DangerColor = Color.FromArgb(245, 108, 108);
            LogOutbtn.DefaultColor = Color.FromArgb(255, 255, 255);
            LogOutbtn.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogOutbtn.ForeColor = Color.DodgerBlue;
            LogOutbtn.HoverTextColor = Color.FromArgb(48, 49, 51);
            LogOutbtn.InfoColor = Color.FromArgb(144, 147, 153);
            LogOutbtn.Location = new Point(26, 372);
            LogOutbtn.Name = "LogOutbtn";
            LogOutbtn.PrimaryColor = Color.FromArgb(189, 233, 255);
            LogOutbtn.Size = new Size(250, 50);
            LogOutbtn.SuccessColor = Color.FromArgb(103, 194, 58);
            LogOutbtn.TabIndex = 5;
            LogOutbtn.Text = "Logout";
            LogOutbtn.TextColor = Color.DeepSkyBlue;
            LogOutbtn.WarningColor = Color.FromArgb(230, 162, 60);
            LogOutbtn.Click += hopeRoundButton4_Click;
            // 
            // AuditLogsbtn
            // 
            AuditLogsbtn.BackColor = Color.FromArgb(189, 233, 255);
            AuditLogsbtn.BorderColor = Color.FromArgb(189, 233, 255);
            AuditLogsbtn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            AuditLogsbtn.DangerColor = Color.FromArgb(245, 108, 108);
            AuditLogsbtn.DefaultColor = Color.FromArgb(255, 255, 255);
            AuditLogsbtn.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AuditLogsbtn.ForeColor = Color.DodgerBlue;
            AuditLogsbtn.HoverTextColor = Color.FromArgb(48, 49, 51);
            AuditLogsbtn.InfoColor = Color.FromArgb(144, 147, 153);
            AuditLogsbtn.Location = new Point(26, 275);
            AuditLogsbtn.Name = "AuditLogsbtn";
            AuditLogsbtn.PrimaryColor = Color.FromArgb(189, 233, 255);
            AuditLogsbtn.Size = new Size(250, 50);
            AuditLogsbtn.SuccessColor = Color.FromArgb(103, 194, 58);
            AuditLogsbtn.TabIndex = 4;
            AuditLogsbtn.Text = "Audit Logs";
            AuditLogsbtn.TextColor = Color.DeepSkyBlue;
            AuditLogsbtn.WarningColor = Color.FromArgb(230, 162, 60);
            AuditLogsbtn.Click += AuditLogsbtn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(14, 36);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(278, 106);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // UserManagementbtn
            // 
            UserManagementbtn.BackColor = Color.FromArgb(189, 233, 255);
            UserManagementbtn.BorderColor = Color.FromArgb(189, 233, 255);
            UserManagementbtn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            UserManagementbtn.DangerColor = Color.FromArgb(245, 108, 108);
            UserManagementbtn.DefaultColor = Color.FromArgb(255, 255, 255);
            UserManagementbtn.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserManagementbtn.ForeColor = Color.DodgerBlue;
            UserManagementbtn.HoverTextColor = Color.FromArgb(48, 49, 51);
            UserManagementbtn.InfoColor = Color.FromArgb(144, 147, 153);
            UserManagementbtn.Location = new Point(26, 184);
            UserManagementbtn.Name = "UserManagementbtn";
            UserManagementbtn.PrimaryColor = Color.FromArgb(189, 233, 255);
            UserManagementbtn.Size = new Size(250, 50);
            UserManagementbtn.SuccessColor = Color.FromArgb(103, 194, 58);
            UserManagementbtn.TabIndex = 0;
            UserManagementbtn.Text = "        User Management";
            UserManagementbtn.TextColor = Color.DeepSkyBlue;
            UserManagementbtn.WarningColor = Color.FromArgb(230, 162, 60);
            UserManagementbtn.Click += UserManagementbtn_Click;
            // 
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.Location = new Point(307, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(916, 625);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(Searchbtn);
            tabPage1.Controls.Add(txtSearchTab1);
            tabPage1.Controls.Add(dgvUsers);
            tabPage1.Controls.Add(RecentLogPnl);
            tabPage1.Controls.Add(TotalUserPnl);
            tabPage1.Controls.Add(DeleteUserbtn);
            tabPage1.Controls.Add(UpdateUserbtn);
            tabPage1.Controls.Add(AddUserbtn);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(bigLabel1);
            tabPage1.Location = new Point(4, 5);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(908, 616);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(796, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 62);
            pictureBox1.TabIndex = 44;
            pictureBox1.TabStop = false;
            // 
            // Searchbtn
            // 
            Searchbtn.BorderColor = Color.FromArgb(220, 223, 230);
            Searchbtn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            Searchbtn.DangerColor = Color.FromArgb(245, 108, 108);
            Searchbtn.DefaultColor = Color.FromArgb(255, 255, 255);
            Searchbtn.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Searchbtn.HoverTextColor = Color.FromArgb(48, 49, 51);
            Searchbtn.InfoColor = Color.FromArgb(144, 147, 153);
            Searchbtn.Location = new Point(751, 170);
            Searchbtn.Name = "Searchbtn";
            Searchbtn.PrimaryColor = Color.FromArgb(64, 158, 255);
            Searchbtn.Size = new Size(122, 48);
            Searchbtn.SuccessColor = Color.FromArgb(103, 194, 58);
            Searchbtn.TabIndex = 9;
            Searchbtn.Text = "Search";
            Searchbtn.TextColor = Color.White;
            Searchbtn.WarningColor = Color.FromArgb(230, 162, 60);
            Searchbtn.Click += Searchbtn_Click;
            // 
            // txtSearchTab1
            // 
            txtSearchTab1.Location = new Point(535, 181);
            txtSearchTab1.Name = "txtSearchTab1";
            txtSearchTab1.Size = new Size(210, 27);
            txtSearchTab1.TabIndex = 8;
            txtSearchTab1.TextChanged += txtSearchTab1_TextChanged_1;
            // 
            // dgvUsers
            // 
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvUsers.BackgroundColor = Color.White;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Columns.AddRange(new DataGridViewColumn[] { UserID_clmn, Name_clmn, Role_clmn, Email_clmn, Status_clmn });
            dgvUsers.GridColor = Color.Black;
            dgvUsers.Location = new Point(36, 238);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.Size = new Size(838, 290);
            dgvUsers.TabIndex = 7;
            // 
            // UserID_clmn
            // 
            UserID_clmn.DataPropertyName = "UserID";
            UserID_clmn.HeaderText = "User ID";
            UserID_clmn.MinimumWidth = 6;
            UserID_clmn.Name = "UserID_clmn";
            // 
            // Name_clmn
            // 
            Name_clmn.DataPropertyName = "Name";
            Name_clmn.HeaderText = "Name";
            Name_clmn.MinimumWidth = 6;
            Name_clmn.Name = "Name_clmn";
            // 
            // Role_clmn
            // 
            Role_clmn.DataPropertyName = "Role";
            Role_clmn.HeaderText = "Role";
            Role_clmn.MinimumWidth = 6;
            Role_clmn.Name = "Role_clmn";
            // 
            // Email_clmn
            // 
            Email_clmn.DataPropertyName = "Email";
            Email_clmn.HeaderText = "Email";
            Email_clmn.MinimumWidth = 6;
            Email_clmn.Name = "Email_clmn";
            // 
            // Status_clmn
            // 
            Status_clmn.DataPropertyName = "Status";
            Status_clmn.HeaderText = "Status";
            Status_clmn.MinimumWidth = 6;
            Status_clmn.Name = "Status_clmn";
            // 
            // RecentLogPnl
            // 
            RecentLogPnl.BackColor = Color.DodgerBlue;
            RecentLogPnl.BackgroundImageLayout = ImageLayout.Zoom;
            RecentLogPnl.Controls.Add(RecentLogs_label_0);
            RecentLogPnl.Controls.Add(label5);
            RecentLogPnl.ForeColor = Color.DodgerBlue;
            RecentLogPnl.Location = new Point(230, 139);
            RecentLogPnl.Name = "RecentLogPnl";
            RecentLogPnl.Size = new Size(170, 73);
            RecentLogPnl.TabIndex = 6;
            RecentLogPnl.Tag = "";
            // 
            // RecentLogs_label_0
            // 
            RecentLogs_label_0.AutoSize = true;
            RecentLogs_label_0.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RecentLogs_label_0.ForeColor = Color.White;
            RecentLogs_label_0.Location = new Point(76, 11);
            RecentLogs_label_0.Name = "RecentLogs_label_0";
            RecentLogs_label_0.Size = new Size(25, 27);
            RecentLogs_label_0.TabIndex = 1;
            RecentLogs_label_0.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(39, 40);
            label5.Name = "label5";
            label5.Size = new Size(97, 18);
            label5.TabIndex = 0;
            label5.Text = "Recent Logs";
            // 
            // TotalUserPnl
            // 
            TotalUserPnl.BackColor = Color.DodgerBlue;
            TotalUserPnl.BackgroundImageLayout = ImageLayout.Zoom;
            TotalUserPnl.Controls.Add(TotalUserlabel_0);
            TotalUserPnl.Controls.Add(label2);
            TotalUserPnl.ForeColor = Color.DodgerBlue;
            TotalUserPnl.Location = new Point(36, 139);
            TotalUserPnl.Name = "TotalUserPnl";
            TotalUserPnl.Size = new Size(170, 73);
            TotalUserPnl.TabIndex = 5;
            TotalUserPnl.Tag = "";
            // 
            // TotalUserlabel_0
            // 
            TotalUserlabel_0.AutoSize = true;
            TotalUserlabel_0.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalUserlabel_0.ForeColor = Color.White;
            TotalUserlabel_0.Location = new Point(76, 11);
            TotalUserlabel_0.Name = "TotalUserlabel_0";
            TotalUserlabel_0.Size = new Size(25, 27);
            TotalUserlabel_0.TabIndex = 1;
            TotalUserlabel_0.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(45, 40);
            label2.Name = "label2";
            label2.Size = new Size(83, 18);
            label2.TabIndex = 0;
            label2.Text = "Total Users";
            // 
            // DeleteUserbtn
            // 
            DeleteUserbtn.BorderColor = Color.FromArgb(220, 223, 230);
            DeleteUserbtn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            DeleteUserbtn.DangerColor = Color.FromArgb(245, 108, 108);
            DeleteUserbtn.DefaultColor = Color.FromArgb(255, 255, 255);
            DeleteUserbtn.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteUserbtn.HoverTextColor = Color.FromArgb(48, 49, 51);
            DeleteUserbtn.InfoColor = Color.FromArgb(144, 147, 153);
            DeleteUserbtn.Location = new Point(707, 547);
            DeleteUserbtn.Name = "DeleteUserbtn";
            DeleteUserbtn.PrimaryColor = Color.Red;
            DeleteUserbtn.Size = new Size(169, 48);
            DeleteUserbtn.SuccessColor = Color.FromArgb(103, 194, 58);
            DeleteUserbtn.TabIndex = 4;
            DeleteUserbtn.Text = "Delete User";
            DeleteUserbtn.TextColor = Color.White;
            DeleteUserbtn.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // UpdateUserbtn
            // 
            UpdateUserbtn.BorderColor = Color.FromArgb(220, 223, 230);
            UpdateUserbtn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            UpdateUserbtn.DangerColor = Color.FromArgb(245, 108, 108);
            UpdateUserbtn.DefaultColor = Color.FromArgb(255, 255, 255);
            UpdateUserbtn.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateUserbtn.HoverTextColor = Color.FromArgb(48, 49, 51);
            UpdateUserbtn.InfoColor = Color.FromArgb(144, 147, 153);
            UpdateUserbtn.Location = new Point(519, 547);
            UpdateUserbtn.Name = "UpdateUserbtn";
            UpdateUserbtn.PrimaryColor = Color.FromArgb(64, 158, 255);
            UpdateUserbtn.Size = new Size(169, 48);
            UpdateUserbtn.SuccessColor = Color.FromArgb(103, 194, 58);
            UpdateUserbtn.TabIndex = 3;
            UpdateUserbtn.Text = "Update User";
            UpdateUserbtn.TextColor = Color.White;
            UpdateUserbtn.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // AddUserbtn
            // 
            AddUserbtn.BorderColor = Color.FromArgb(220, 223, 230);
            AddUserbtn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            AddUserbtn.DangerColor = Color.FromArgb(245, 108, 108);
            AddUserbtn.DefaultColor = Color.FromArgb(255, 255, 255);
            AddUserbtn.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddUserbtn.HoverTextColor = Color.FromArgb(48, 49, 51);
            AddUserbtn.InfoColor = Color.FromArgb(144, 147, 153);
            AddUserbtn.Location = new Point(333, 547);
            AddUserbtn.Name = "AddUserbtn";
            AddUserbtn.PrimaryColor = Color.FromArgb(76, 175, 80);
            AddUserbtn.Size = new Size(169, 48);
            AddUserbtn.SuccessColor = Color.FromArgb(103, 194, 58);
            AddUserbtn.TabIndex = 2;
            AddUserbtn.Text = "Add User";
            AddUserbtn.TextColor = Color.White;
            AddUserbtn.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 80);
            label1.Name = "label1";
            label1.Size = new Size(194, 18);
            label1.TabIndex = 1;
            label1.Text = "Manage users effortlessly";
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Century Gothic", 25.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.DodgerBlue;
            bigLabel1.Location = new Point(20, 21);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(395, 49);
            bigLabel1.TabIndex = 0;
            bigLabel1.Text = "User Management";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(Tab2_ClearLogsbt);
            tabPage2.Controls.Add(pictureBox4);
            tabPage2.Controls.Add(Filterlabel);
            tabPage2.Controls.Add(Tab2_Seachbtn);
            tabPage2.Controls.Add(Tab2_Searchtxtbx);
            tabPage2.Controls.Add(dgvAuditLogs);
            tabPage2.Controls.Add(Tab2_Exportbtn);
            tabPage2.Controls.Add(Refreshbt);
            tabPage2.Controls.Add(cmbFilterActivity);
            tabPage2.Controls.Add(bigLabel2);
            tabPage2.Location = new Point(4, 5);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(908, 616);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(34, 74);
            label6.Name = "label6";
            label6.Size = new Size(176, 18);
            label6.TabIndex = 46;
            label6.Text = "Track. Monitor. Secure.";
            // 
            // Tab2_ClearLogsbt
            // 
            Tab2_ClearLogsbt.BackColor = Color.Gray;
            Tab2_ClearLogsbt.BorderColor = Color.DodgerBlue;
            Tab2_ClearLogsbt.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            Tab2_ClearLogsbt.DangerColor = Color.FromArgb(245, 108, 108);
            Tab2_ClearLogsbt.DefaultColor = Color.DeepSkyBlue;
            Tab2_ClearLogsbt.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tab2_ClearLogsbt.HoverTextColor = Color.FromArgb(48, 49, 51);
            Tab2_ClearLogsbt.InfoColor = Color.FromArgb(144, 147, 153);
            Tab2_ClearLogsbt.Location = new Point(596, 546);
            Tab2_ClearLogsbt.Name = "Tab2_ClearLogsbt";
            Tab2_ClearLogsbt.PrimaryColor = Color.Gainsboro;
            Tab2_ClearLogsbt.Size = new Size(161, 50);
            Tab2_ClearLogsbt.SuccessColor = Color.FromArgb(103, 194, 58);
            Tab2_ClearLogsbt.TabIndex = 45;
            Tab2_ClearLogsbt.Text = "Clear Logs";
            Tab2_ClearLogsbt.TextColor = Color.DodgerBlue;
            Tab2_ClearLogsbt.WarningColor = Color.FromArgb(230, 162, 60);
            Tab2_ClearLogsbt.Click += Tab2_ClearLogsbt_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(798, 14);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(103, 62);
            pictureBox4.TabIndex = 44;
            pictureBox4.TabStop = false;
            // 
            // Filterlabel
            // 
            Filterlabel.AutoSize = true;
            Filterlabel.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Filterlabel.Location = new Point(36, 119);
            Filterlabel.Name = "Filterlabel";
            Filterlabel.Size = new Size(123, 18);
            Filterlabel.TabIndex = 9;
            Filterlabel.Text = "Filter by Activity";
            // 
            // Tab2_Seachbtn
            // 
            Tab2_Seachbtn.BorderColor = Color.FromArgb(220, 223, 230);
            Tab2_Seachbtn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            Tab2_Seachbtn.DangerColor = Color.FromArgb(245, 108, 108);
            Tab2_Seachbtn.DefaultColor = Color.FromArgb(255, 255, 255);
            Tab2_Seachbtn.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tab2_Seachbtn.HoverTextColor = Color.FromArgb(48, 49, 51);
            Tab2_Seachbtn.InfoColor = Color.FromArgb(144, 147, 153);
            Tab2_Seachbtn.Location = new Point(761, 130);
            Tab2_Seachbtn.Name = "Tab2_Seachbtn";
            Tab2_Seachbtn.PrimaryColor = Color.FromArgb(64, 158, 255);
            Tab2_Seachbtn.Size = new Size(126, 50);
            Tab2_Seachbtn.SuccessColor = Color.FromArgb(103, 194, 58);
            Tab2_Seachbtn.TabIndex = 8;
            Tab2_Seachbtn.Text = "Search";
            Tab2_Seachbtn.TextColor = Color.White;
            Tab2_Seachbtn.WarningColor = Color.FromArgb(230, 162, 60);
            Tab2_Seachbtn.Click += Tab2_Seachbtn_Click;
            // 
            // Tab2_Searchtxtbx
            // 
            Tab2_Searchtxtbx.Location = new Point(528, 145);
            Tab2_Searchtxtbx.Name = "Tab2_Searchtxtbx";
            Tab2_Searchtxtbx.Size = new Size(225, 27);
            Tab2_Searchtxtbx.TabIndex = 7;
            Tab2_Searchtxtbx.TextChanged += Tab2_Searchtxtbx_TextChanged_1;
            // 
            // dgvAuditLogs
            // 
            dgvAuditLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAuditLogs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvAuditLogs.BackgroundColor = Color.White;
            dgvAuditLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuditLogs.Columns.AddRange(new DataGridViewColumn[] { Tab2Timestamp_clmn, Tab2Email_clmn, Tab2Activity_clmn, Tab2Description_clmn, Tab2Status_clmn });
            dgvAuditLogs.Location = new Point(40, 194);
            dgvAuditLogs.Name = "dgvAuditLogs";
            dgvAuditLogs.RowHeadersWidth = 51;
            dgvAuditLogs.Size = new Size(847, 333);
            dgvAuditLogs.TabIndex = 6;
            // 
            // Tab2Timestamp_clmn
            // 
            Tab2Timestamp_clmn.DataPropertyName = "Timestamp";
            Tab2Timestamp_clmn.HeaderText = "Timestamp";
            Tab2Timestamp_clmn.MinimumWidth = 6;
            Tab2Timestamp_clmn.Name = "Tab2Timestamp_clmn";
            // 
            // Tab2Email_clmn
            // 
            Tab2Email_clmn.DataPropertyName = "Email";
            Tab2Email_clmn.HeaderText = "Email";
            Tab2Email_clmn.MinimumWidth = 6;
            Tab2Email_clmn.Name = "Tab2Email_clmn";
            // 
            // Tab2Activity_clmn
            // 
            Tab2Activity_clmn.DataPropertyName = "Activity";
            Tab2Activity_clmn.HeaderText = "Activity";
            Tab2Activity_clmn.MinimumWidth = 6;
            Tab2Activity_clmn.Name = "Tab2Activity_clmn";
            // 
            // Tab2Description_clmn
            // 
            Tab2Description_clmn.DataPropertyName = "Description";
            Tab2Description_clmn.HeaderText = "Description";
            Tab2Description_clmn.MinimumWidth = 6;
            Tab2Description_clmn.Name = "Tab2Description_clmn";
            // 
            // Tab2Status_clmn
            // 
            Tab2Status_clmn.DataPropertyName = "Status";
            Tab2Status_clmn.HeaderText = "Status";
            Tab2Status_clmn.MinimumWidth = 6;
            Tab2Status_clmn.Name = "Tab2Status_clmn";
            // 
            // Tab2_Exportbtn
            // 
            Tab2_Exportbtn.BorderColor = Color.FromArgb(220, 223, 230);
            Tab2_Exportbtn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            Tab2_Exportbtn.DangerColor = Color.FromArgb(245, 108, 108);
            Tab2_Exportbtn.DefaultColor = Color.FromArgb(255, 255, 255);
            Tab2_Exportbtn.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tab2_Exportbtn.HoverTextColor = Color.FromArgb(48, 49, 51);
            Tab2_Exportbtn.InfoColor = Color.FromArgb(144, 147, 153);
            Tab2_Exportbtn.Location = new Point(767, 546);
            Tab2_Exportbtn.Name = "Tab2_Exportbtn";
            Tab2_Exportbtn.PrimaryColor = Color.FromArgb(64, 158, 255);
            Tab2_Exportbtn.Size = new Size(126, 50);
            Tab2_Exportbtn.SuccessColor = Color.FromArgb(103, 194, 58);
            Tab2_Exportbtn.TabIndex = 4;
            Tab2_Exportbtn.Text = "Export";
            Tab2_Exportbtn.TextColor = Color.White;
            Tab2_Exportbtn.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // Refreshbt
            // 
            Refreshbt.BackColor = Color.FromArgb(76, 175, 80);
            Refreshbt.BorderColor = Color.FromArgb(220, 223, 230);
            Refreshbt.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            Refreshbt.DangerColor = Color.FromArgb(245, 108, 108);
            Refreshbt.DefaultColor = Color.FromArgb(255, 255, 255);
            Refreshbt.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Refreshbt.HoverTextColor = Color.FromArgb(48, 49, 51);
            Refreshbt.InfoColor = Color.FromArgb(144, 147, 153);
            Refreshbt.Location = new Point(266, 128);
            Refreshbt.Name = "Refreshbt";
            Refreshbt.PrimaryColor = Color.FromArgb(76, 175, 80);
            Refreshbt.Size = new Size(126, 50);
            Refreshbt.SuccessColor = Color.FromArgb(103, 194, 58);
            Refreshbt.TabIndex = 3;
            Refreshbt.Text = "Refresh";
            Refreshbt.TextColor = Color.White;
            Refreshbt.WarningColor = Color.FromArgb(230, 162, 60);
            Refreshbt.Click += Refreshbt_Click;
            // 
            // cmbFilterActivity
            // 
            cmbFilterActivity.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbFilterActivity.FormattingEnabled = true;
            cmbFilterActivity.Items.AddRange(new object[] { "All Activities", "User Management", "Authentication" });
            cmbFilterActivity.Location = new Point(40, 143);
            cmbFilterActivity.Name = "cmbFilterActivity";
            cmbFilterActivity.Size = new Size(211, 28);
            cmbFilterActivity.TabIndex = 2;
            cmbFilterActivity.SelectedIndexChanged += cmbFilterActivity_SelectedIndexChanged_1;
            // 
            // bigLabel2
            // 
            bigLabel2.AutoSize = true;
            bigLabel2.BackColor = Color.Transparent;
            bigLabel2.Font = new Font("Century Gothic", 25.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel2.ForeColor = Color.DodgerBlue;
            bigLabel2.Location = new Point(26, 20);
            bigLabel2.Name = "bigLabel2";
            bigLabel2.Size = new Size(232, 49);
            bigLabel2.TabIndex = 1;
            bigLabel2.Text = "Audit Logs";
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1223, 625);
            Controls.Add(tabControl1);
            Controls.Add(student_navbar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminDashboard";
            student_navbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            RecentLogPnl.ResumeLayout(false);
            RecentLogPnl.PerformLayout();
            TotalUserPnl.ResumeLayout(false);
            TotalUserPnl.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAuditLogs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel student_navbar;
        private PictureBox pictureBox6;
        private PictureBox pictureBox3;
        private PictureBox pictureBox8;
        private ReaLTaiizor.Controls.HopeRoundButton LogOutbtn;
        private ReaLTaiizor.Controls.HopeRoundButton AuditLogsbtn;
        private PictureBox pictureBox2;
        private ReaLTaiizor.Controls.HopeRoundButton UserManagementbtn;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private Panel TotalUserPnl;
        private ReaLTaiizor.Controls.HopeRoundButton DeleteUserbtn;
        private ReaLTaiizor.Controls.HopeRoundButton UpdateUserbtn;
        private ReaLTaiizor.Controls.HopeRoundButton AddUserbtn;
        private Label TotalUserlabel_0;
        private Label label2;
        private DataGridView dgvUsers;
        private Panel RecentLogPnl;
        private Label RecentLogs_label_0;
        private Label label5;
        private ReaLTaiizor.Controls.HopeRoundButton Searchbtn;
        private TextBox txtSearchTab1;
        private PictureBox pictureBox1;
        private DataGridView dgvAuditLogs;
        private ReaLTaiizor.Controls.HopeRoundButton Tab2_Exportbtn;
        private ReaLTaiizor.Controls.HopeRoundButton Refreshbt;
        private ComboBox cmbFilterActivity;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private ReaLTaiizor.Controls.HopeRoundButton Tab2_Seachbtn;
        private TextBox Tab2_Searchtxtbx;
        private Label Filterlabel;
        private PictureBox pictureBox4;
        private ReaLTaiizor.Controls.HopeRoundButton Tab2_ClearLogsbt;
        private Label label6;
        private DataGridViewTextBoxColumn UserID_clmn;
        private DataGridViewTextBoxColumn Name_clmn;
        private DataGridViewTextBoxColumn Role_clmn;
        private DataGridViewTextBoxColumn Email_clmn;
        private DataGridViewTextBoxColumn Status_clmn;
        private DataGridViewTextBoxColumn Tab2Timestamp_clmn;
        private DataGridViewTextBoxColumn Tab2Email_clmn;
        private DataGridViewTextBoxColumn Tab2Activity_clmn;
        private DataGridViewTextBoxColumn Tab2Description_clmn;
        private DataGridViewTextBoxColumn Tab2Status_clmn;
    }
}