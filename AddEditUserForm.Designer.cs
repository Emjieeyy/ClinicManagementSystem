namespace ClinicManagementSystem
{
    partial class AddEditUserForm
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            fullNameTextBox = new TextBox();
            emailTextBox = new TextBox();
            roleComboBox = new ComboBox();
            saveBtn = new ReaLTaiizor.Controls.HopeRoundButton();
            cancelBtn = new ReaLTaiizor.Controls.HopeRoundButton();
            statusComboBox = new ComboBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(30, 30);
            label1.Name = "label1";
            label1.Size = new Size(87, 23);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(30, 80);
            label2.Name = "label2";
            label2.Size = new Size(82, 23);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(30, 130);
            label3.Name = "label3";
            label3.Size = new Size(88, 23);
            label3.TabIndex = 2;
            label3.Text = "Full Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(30, 180);
            label4.Name = "label4";
            label4.Size = new Size(45, 23);
            label4.TabIndex = 3;
            label4.Text = "Role";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.Location = new Point(30, 230);
            label5.Name = "label5";
            label5.Size = new Size(51, 23);
            label5.TabIndex = 4;
            label5.Text = "Email";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Font = new Font("Segoe UI", 10F);
            usernameTextBox.Location = new Point(150, 27);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(300, 30);
            usernameTextBox.TabIndex = 5;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Segoe UI", 10F);
            passwordTextBox.Location = new Point(150, 77);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(300, 30);
            passwordTextBox.TabIndex = 6;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // fullNameTextBox
            // 
            fullNameTextBox.Font = new Font("Segoe UI", 10F);
            fullNameTextBox.Location = new Point(150, 127);
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.Size = new Size(300, 30);
            fullNameTextBox.TabIndex = 7;
            // 
            // emailTextBox
            // 
            emailTextBox.Font = new Font("Segoe UI", 10F);
            emailTextBox.Location = new Point(150, 227);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(300, 30);
            emailTextBox.TabIndex = 8;
            // 
            // roleComboBox
            // 
            roleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            roleComboBox.Font = new Font("Segoe UI", 10F);
            roleComboBox.FormattingEnabled = true;
            roleComboBox.Items.AddRange(new object[] { "Admin", "Clinic Staff", "Student" });
            roleComboBox.Location = new Point(150, 177);
            roleComboBox.Name = "roleComboBox";
            roleComboBox.Size = new Size(300, 31);
            roleComboBox.TabIndex = 9;
            // 
            // saveBtn
            // 
            saveBtn.BorderColor = Color.FromArgb(220, 223, 230);
            saveBtn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Success;
            saveBtn.Cursor = Cursors.Hand;
            saveBtn.DangerColor = Color.FromArgb(245, 108, 108);
            saveBtn.DefaultColor = Color.FromArgb(255, 255, 255);
            saveBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            saveBtn.HoverTextColor = Color.White;
            saveBtn.InfoColor = Color.FromArgb(144, 147, 153);
            saveBtn.Location = new Point(150, 330);
            saveBtn.Name = "saveBtn";
            saveBtn.PrimaryColor = Color.FromArgb(64, 158, 255);
            saveBtn.Size = new Size(140, 50);
            saveBtn.SuccessColor = Color.FromArgb(103, 194, 58);
            saveBtn.TabIndex = 10;
            saveBtn.Text = "Save";
            saveBtn.TextColor = Color.White;
            saveBtn.WarningColor = Color.FromArgb(230, 162, 60);
            saveBtn.Click += saveBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.BorderColor = Color.FromArgb(220, 223, 230);
            cancelBtn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Danger;
            cancelBtn.Cursor = Cursors.Hand;
            cancelBtn.DangerColor = Color.FromArgb(245, 108, 108);
            cancelBtn.DefaultColor = Color.FromArgb(255, 255, 255);
            cancelBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cancelBtn.HoverTextColor = Color.White;
            cancelBtn.InfoColor = Color.FromArgb(144, 147, 153);
            cancelBtn.Location = new Point(310, 330);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.PrimaryColor = Color.FromArgb(64, 158, 255);
            cancelBtn.Size = new Size(140, 50);
            cancelBtn.SuccessColor = Color.FromArgb(103, 194, 58);
            cancelBtn.TabIndex = 11;
            cancelBtn.Text = "Cancel";
            cancelBtn.TextColor = Color.White;
            cancelBtn.WarningColor = Color.FromArgb(230, 162, 60);
            cancelBtn.Click += cancelBtn_Click;
            // 
            // statusComboBox
            // 
            statusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            statusComboBox.Font = new Font("Segoe UI", 10F);
            statusComboBox.FormattingEnabled = true;
            statusComboBox.Items.AddRange(new object[] { "Active", "Inactive" });
            statusComboBox.Location = new Point(150, 277);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(300, 31);
            statusComboBox.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.Location = new Point(30, 280);
            label6.Name = "label6";
            label6.Size = new Size(58, 23);
            label6.TabIndex = 12;
            label6.Text = "Status";
            // 
            // AddEditUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 411);
            Controls.Add(statusComboBox);
            Controls.Add(label6);
            Controls.Add(cancelBtn);
            Controls.Add(saveBtn);
            Controls.Add(roleComboBox);
            Controls.Add(emailTextBox);
            Controls.Add(fullNameTextBox);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddEditUserForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add/Edit User";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private TextBox fullNameTextBox;
        private TextBox emailTextBox;
        private ComboBox roleComboBox;
        private ReaLTaiizor.Controls.HopeRoundButton saveBtn;
        private ReaLTaiizor.Controls.HopeRoundButton cancelBtn;
        private ComboBox statusComboBox;
        private Label label6;
    }
}
