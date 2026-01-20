namespace ClinicManagementSystem
{
    partial class UC_SystemSettings
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
            titleLabel = new Label();
            groupBox1 = new GroupBox();
            clinicEmailTextBox = new TextBox();
            label4 = new Label();
            clinicPhoneTextBox = new TextBox();
            label3 = new Label();
            clinicAddressTextBox = new TextBox();
            label2 = new Label();
            clinicNameTextBox = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            backupNowBtn = new ReaLTaiizor.Controls.HopeRoundButton();
            browseBtn = new ReaLTaiizor.Controls.HopeRoundButton();
            backupPathTextBox = new TextBox();
            label5 = new Label();
            autoBackupCheckBox = new CheckBox();
            groupBox3 = new GroupBox();
            testEmailBtn = new ReaLTaiizor.Controls.HopeRoundButton();
            emailNotificationCheckBox = new CheckBox();
            notificationCheckBox = new CheckBox();
            saveSettingsBtn = new ReaLTaiizor.Controls.HopeRoundButton();
            resetSettingsBtn = new ReaLTaiizor.Controls.HopeRoundButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            titleLabel.ForeColor = Color.FromArgb(32, 129, 226);
            titleLabel.Location = new Point(30, 30);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(307, 54);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "System Settings";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(clinicEmailTextBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(clinicPhoneTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(clinicAddressTextBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(clinicNameTextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(30, 110);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(500, 280);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Clinic Information";
            // 
            // clinicEmailTextBox
            // 
            clinicEmailTextBox.Font = new Font("Segoe UI", 10F);
            clinicEmailTextBox.Location = new Point(150, 220);
            clinicEmailTextBox.Name = "clinicEmailTextBox";
            clinicEmailTextBox.Size = new Size(320, 30);
            clinicEmailTextBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(20, 223);
            label4.Name = "label4";
            label4.Size = new Size(51, 23);
            label4.TabIndex = 6;
            label4.Text = "Email";
            // 
            // clinicPhoneTextBox
            // 
            clinicPhoneTextBox.Font = new Font("Segoe UI", 10F);
            clinicPhoneTextBox.Location = new Point(150, 165);
            clinicPhoneTextBox.Name = "clinicPhoneTextBox";
            clinicPhoneTextBox.Size = new Size(320, 30);
            clinicPhoneTextBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(20, 168);
            label3.Name = "label3";
            label3.Size = new Size(59, 23);
            label3.TabIndex = 4;
            label3.Text = "Phone";
            // 
            // clinicAddressTextBox
            // 
            clinicAddressTextBox.Font = new Font("Segoe UI", 10F);
            clinicAddressTextBox.Location = new Point(150, 100);
            clinicAddressTextBox.Multiline = true;
            clinicAddressTextBox.Name = "clinicAddressTextBox";
            clinicAddressTextBox.Size = new Size(320, 50);
            clinicAddressTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(20, 103);
            label2.Name = "label2";
            label2.Size = new Size(70, 23);
            label2.TabIndex = 2;
            label2.Text = "Address";
            // 
            // clinicNameTextBox
            // 
            clinicNameTextBox.Font = new Font("Segoe UI", 10F);
            clinicNameTextBox.Location = new Point(150, 45);
            clinicNameTextBox.Name = "clinicNameTextBox";
            clinicNameTextBox.Size = new Size(320, 30);
            clinicNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(20, 48);
            label1.Name = "label1";
            label1.Size = new Size(103, 23);
            label1.TabIndex = 0;
            label1.Text = "Clinic Name";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(backupNowBtn);
            groupBox2.Controls.Add(browseBtn);
            groupBox2.Controls.Add(backupPathTextBox);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(autoBackupCheckBox);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox2.Location = new Point(560, 110);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(500, 200);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Backup Settings";
            // 
            // backupNowBtn
            // 
            backupNowBtn.BorderColor = Color.FromArgb(220, 223, 230);
            backupNowBtn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Success;
            backupNowBtn.Cursor = Cursors.Hand;
            backupNowBtn.DangerColor = Color.FromArgb(245, 108, 108);
            backupNowBtn.DefaultColor = Color.FromArgb(255, 255, 255);
            backupNowBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            backupNowBtn.HoverTextColor = Color.White;
            backupNowBtn.InfoColor = Color.FromArgb(144, 147, 153);
            backupNowBtn.Location = new Point(320, 135);
            backupNowBtn.Name = "backupNowBtn";
            backupNowBtn.PrimaryColor = Color.FromArgb(64, 158, 255);
            backupNowBtn.Size = new Size(150, 45);
            backupNowBtn.SuccessColor = Color.FromArgb(103, 194, 58);
            backupNowBtn.TabIndex = 8;
            backupNowBtn.Text = "Backup Now";
            backupNowBtn.TextColor = Color.White;
            backupNowBtn.WarningColor = Color.FromArgb(230, 162, 60);
            backupNowBtn.Click += backupNowBtn_Click;
            // 
            // browseBtn
            // 
            browseBtn.BorderColor = Color.FromArgb(220, 223, 230);
            browseBtn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            browseBtn.Cursor = Cursors.Hand;
            browseBtn.DangerColor = Color.FromArgb(245, 108, 108);
            browseBtn.DefaultColor = Color.FromArgb(255, 255, 255);
            browseBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            browseBtn.HoverTextColor = Color.White;
            browseBtn.InfoColor = Color.FromArgb(144, 147, 153);
            browseBtn.Location = new Point(400, 80);
            browseBtn.Name = "browseBtn";
            browseBtn.PrimaryColor = Color.FromArgb(64, 158, 255);
            browseBtn.Size = new Size(70, 35);
            browseBtn.SuccessColor = Color.FromArgb(103, 194, 58);
            browseBtn.TabIndex = 7;
            browseBtn.Text = "...";
            browseBtn.TextColor = Color.White;
            browseBtn.WarningColor = Color.FromArgb(230, 162, 60);
            browseBtn.Click += browseBtn_Click;
            // 
            // backupPathTextBox
            // 
            backupPathTextBox.Font = new Font("Segoe UI", 10F);
            backupPathTextBox.Location = new Point(150, 83);
            backupPathTextBox.Name = "backupPathTextBox";
            backupPathTextBox.Size = new Size(240, 30);
            backupPathTextBox.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(20, 86);
            label5.Name = "label5";
            label5.Size = new Size(106, 23);
            label5.TabIndex = 2;
            label5.Text = "Backup Path";
            // 
            // autoBackupCheckBox
            // 
            autoBackupCheckBox.AutoSize = true;
            autoBackupCheckBox.Font = new Font("Segoe UI", 10F);
            autoBackupCheckBox.Location = new Point(20, 45);
            autoBackupCheckBox.Name = "autoBackupCheckBox";
            autoBackupCheckBox.Size = new Size(228, 27);
            autoBackupCheckBox.TabIndex = 0;
            autoBackupCheckBox.Text = "Enable Automatic Backup";
            autoBackupCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(testEmailBtn);
            groupBox3.Controls.Add(emailNotificationCheckBox);
            groupBox3.Controls.Add(notificationCheckBox);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox3.Location = new Point(560, 330);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(500, 150);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Notification Settings";
            // 
            // testEmailBtn
            // 
            testEmailBtn.BorderColor = Color.FromArgb(220, 223, 230);
            testEmailBtn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            testEmailBtn.Cursor = Cursors.Hand;
            testEmailBtn.DangerColor = Color.FromArgb(245, 108, 108);
            testEmailBtn.DefaultColor = Color.FromArgb(255, 255, 255);
            testEmailBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            testEmailBtn.HoverTextColor = Color.White;
            testEmailBtn.InfoColor = Color.FromArgb(144, 147, 153);
            testEmailBtn.Location = new Point(320, 85);
            testEmailBtn.Name = "testEmailBtn";
            testEmailBtn.PrimaryColor = Color.FromArgb(64, 158, 255);
            testEmailBtn.Size = new Size(150, 45);
            testEmailBtn.SuccessColor = Color.FromArgb(103, 194, 58);
            testEmailBtn.TabIndex = 9;
            testEmailBtn.Text = "Test Email";
            testEmailBtn.TextColor = Color.White;
            testEmailBtn.WarningColor = Color.FromArgb(230, 162, 60);
            testEmailBtn.Click += testEmailBtn_Click;
            // 
            // emailNotificationCheckBox
            // 
            emailNotificationCheckBox.AutoSize = true;
            emailNotificationCheckBox.Font = new Font("Segoe UI", 10F);
            emailNotificationCheckBox.Location = new Point(20, 90);
            emailNotificationCheckBox.Name = "emailNotificationCheckBox";
            emailNotificationCheckBox.Size = new Size(206, 27);
            emailNotificationCheckBox.TabIndex = 1;
            emailNotificationCheckBox.Text = "Email Notifications (ON)";
            emailNotificationCheckBox.UseVisualStyleBackColor = true;
            // 
            // notificationCheckBox
            // 
            notificationCheckBox.AutoSize = true;
            notificationCheckBox.Font = new Font("Segoe UI", 10F);
            notificationCheckBox.Location = new Point(20, 45);
            notificationCheckBox.Name = "notificationCheckBox";
            notificationCheckBox.Size = new Size(229, 27);
            notificationCheckBox.TabIndex = 0;
            notificationCheckBox.Text = "System Notifications (ON)";
            notificationCheckBox.UseVisualStyleBackColor = true;
            // 
            // saveSettingsBtn
            // 
            saveSettingsBtn.BorderColor = Color.FromArgb(220, 223, 230);
            saveSettingsBtn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Success;
            saveSettingsBtn.Cursor = Cursors.Hand;
            saveSettingsBtn.DangerColor = Color.FromArgb(245, 108, 108);
            saveSettingsBtn.DefaultColor = Color.FromArgb(255, 255, 255);
            saveSettingsBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            saveSettingsBtn.HoverTextColor = Color.White;
            saveSettingsBtn.InfoColor = Color.FromArgb(144, 147, 153);
            saveSettingsBtn.Location = new Point(30, 420);
            saveSettingsBtn.Name = "saveSettingsBtn";
            saveSettingsBtn.PrimaryColor = Color.FromArgb(64, 158, 255);
            saveSettingsBtn.Size = new Size(200, 60);
            saveSettingsBtn.SuccessColor = Color.FromArgb(103, 194, 58);
            saveSettingsBtn.TabIndex = 4;
            saveSettingsBtn.Text = "Save Settings";
            saveSettingsBtn.TextColor = Color.White;
            saveSettingsBtn.WarningColor = Color.FromArgb(230, 162, 60);
            saveSettingsBtn.Click += saveSettingsBtn_Click;
            // 
            // resetSettingsBtn
            // 
            resetSettingsBtn.BorderColor = Color.FromArgb(220, 223, 230);
            resetSettingsBtn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Danger;
            resetSettingsBtn.Cursor = Cursors.Hand;
            resetSettingsBtn.DangerColor = Color.FromArgb(245, 108, 108);
            resetSettingsBtn.DefaultColor = Color.FromArgb(255, 255, 255);
            resetSettingsBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            resetSettingsBtn.HoverTextColor = Color.White;
            resetSettingsBtn.InfoColor = Color.FromArgb(144, 147, 153);
            resetSettingsBtn.Location = new Point(250, 420);
            resetSettingsBtn.Name = "resetSettingsBtn";
            resetSettingsBtn.PrimaryColor = Color.FromArgb(64, 158, 255);
            resetSettingsBtn.Size = new Size(200, 60);
            resetSettingsBtn.SuccessColor = Color.FromArgb(103, 194, 58);
            resetSettingsBtn.TabIndex = 5;
            resetSettingsBtn.Text = "Reset to Default";
            resetSettingsBtn.TextColor = Color.White;
            resetSettingsBtn.WarningColor = Color.FromArgb(230, 162, 60);
            resetSettingsBtn.Click += resetSettingsBtn_Click;
            // 
            // UC_SystemSettings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            Controls.Add(resetSettingsBtn);
            Controls.Add(saveSettingsBtn);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(titleLabel);
            Name = "UC_SystemSettings";
            Size = new Size(1093, 701);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private GroupBox groupBox1;
        private TextBox clinicNameTextBox;
        private Label label1;
        private TextBox clinicEmailTextBox;
        private Label label4;
        private TextBox clinicPhoneTextBox;
        private Label label3;
        private TextBox clinicAddressTextBox;
        private Label label2;
        private GroupBox groupBox2;
        private CheckBox autoBackupCheckBox;
        private TextBox backupPathTextBox;
        private Label label5;
        private ReaLTaiizor.Controls.HopeRoundButton browseBtn;
        private GroupBox groupBox3;
        private CheckBox emailNotificationCheckBox;
        private CheckBox notificationCheckBox;
        private ReaLTaiizor.Controls.HopeRoundButton saveSettingsBtn;
        private ReaLTaiizor.Controls.HopeRoundButton resetSettingsBtn;
        private ReaLTaiizor.Controls.HopeRoundButton backupNowBtn;
        private ReaLTaiizor.Controls.HopeRoundButton testEmailBtn;
    }
}
