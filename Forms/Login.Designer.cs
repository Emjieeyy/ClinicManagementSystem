namespace ClinicManagementSystem
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            loginform = new Panel();
            pictureBox5 = new PictureBox();
            pictureBox8 = new PictureBox();
            loginbt = new ReaLTaiizor.Controls.HopeRoundButton();
            txtPassword = new ReaLTaiizor.Controls.HopeTextBox();
            txtEmail = new ReaLTaiizor.Controls.HopeTextBox();
            showpasswordcb = new ReaLTaiizor.Controls.HopeCheckBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            loginform.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // loginform
            // 
            loginform.AutoSize = true;
            loginform.BackColor = Color.White;
            loginform.Controls.Add(pictureBox5);
            loginform.Controls.Add(pictureBox8);
            loginform.Controls.Add(loginbt);
            loginform.Controls.Add(txtPassword);
            loginform.Controls.Add(txtEmail);
            loginform.Controls.Add(showpasswordcb);
            loginform.Controls.Add(pictureBox4);
            loginform.Controls.Add(pictureBox3);
            loginform.Controls.Add(label1);
            loginform.Controls.Add(pictureBox2);
            loginform.Controls.Add(pictureBox1);
            loginform.Dock = DockStyle.Fill;
            loginform.Location = new Point(0, 0);
            loginform.Name = "loginform";
            loginform.Size = new Size(1077, 561);
            loginform.TabIndex = 0;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.FromArgb(189, 233, 255);
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.Location = new Point(685, 321);
            pictureBox5.Margin = new Padding(3, 3, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(40, 31);
            pictureBox5.TabIndex = 21;
            pictureBox5.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.FromArgb(189, 233, 255);
            pictureBox8.BackgroundImage = (Image)resources.GetObject("pictureBox8.BackgroundImage");
            pictureBox8.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox8.Location = new Point(683, 246);
            pictureBox8.Margin = new Padding(3, 3, 3, 2);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(40, 31);
            pictureBox8.TabIndex = 20;
            pictureBox8.TabStop = false;
            // 
            // loginbt
            // 
            loginbt.BorderColor = Color.FromArgb(220, 223, 230);
            loginbt.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            loginbt.DangerColor = Color.FromArgb(245, 108, 108);
            loginbt.DefaultColor = Color.FromArgb(255, 255, 255);
            loginbt.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginbt.HoverTextColor = Color.FromArgb(48, 49, 51);
            loginbt.InfoColor = Color.FromArgb(144, 147, 153);
            loginbt.Location = new Point(826, 424);
            loginbt.Name = "loginbt";
            loginbt.PrimaryColor = Color.FromArgb(64, 158, 255);
            loginbt.Size = new Size(137, 45);
            loginbt.SuccessColor = Color.FromArgb(103, 194, 58);
            loginbt.TabIndex = 17;
            loginbt.Text = "Login";
            loginbt.TextColor = Color.White;
            loginbt.WarningColor = Color.FromArgb(230, 162, 60);
            loginbt.Click += loginbt_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(189, 233, 255);
            txtPassword.BaseColor = Color.FromArgb(189, 233, 255);
            txtPassword.BorderColorA = Color.FromArgb(189, 233, 255);
            txtPassword.BorderColorB = Color.FromArgb(189, 233, 255);
            txtPassword.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.FromArgb(48, 49, 51);
            txtPassword.Hint = "";
            txtPassword.Location = new Point(720, 318);
            txtPassword.MaxLength = 32767;
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '\0';
            txtPassword.ScrollBars = ScrollBars.None;
            txtPassword.SelectedText = "";
            txtPassword.SelectionLength = 0;
            txtPassword.SelectionStart = 0;
            txtPassword.Size = new Size(221, 37);
            txtPassword.TabIndex = 16;
            txtPassword.TabStop = false;
            txtPassword.Text = "Please enter Password";
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(189, 233, 255);
            txtEmail.BaseColor = Color.FromArgb(189, 233, 255);
            txtEmail.BorderColorA = Color.FromArgb(189, 233, 255);
            txtEmail.BorderColorB = Color.FromArgb(189, 233, 255);
            txtEmail.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.FromArgb(48, 49, 51);
            txtEmail.Hint = "";
            txtEmail.Location = new Point(718, 242);
            txtEmail.MaxLength = 32767;
            txtEmail.Multiline = false;
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.ScrollBars = ScrollBars.None;
            txtEmail.SelectedText = "";
            txtEmail.SelectionLength = 0;
            txtEmail.SelectionStart = 0;
            txtEmail.Size = new Size(223, 37);
            txtEmail.TabIndex = 14;
            txtEmail.TabStop = false;
            txtEmail.Text = "Please enter Username";
            txtEmail.UseSystemPasswordChar = false;
            txtEmail.Enter += txtEmail_Enter;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // showpasswordcb
            // 
            showpasswordcb.AutoSize = true;
            showpasswordcb.BackgroundImage = (Image)resources.GetObject("showpasswordcb.BackgroundImage");
            showpasswordcb.CheckedColor = Color.FromArgb(64, 158, 255);
            showpasswordcb.DisabledColor = Color.FromArgb(196, 198, 202);
            showpasswordcb.DisabledStringColor = Color.FromArgb(186, 187, 189);
            showpasswordcb.Enable = true;
            showpasswordcb.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            showpasswordcb.EnabledStringColor = Color.FromArgb(153, 153, 153);
            showpasswordcb.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            showpasswordcb.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            showpasswordcb.ForeColor = Color.FromArgb(48, 49, 51);
            showpasswordcb.Location = new Point(671, 389);
            showpasswordcb.Name = "showpasswordcb";
            showpasswordcb.Size = new Size(148, 20);
            showpasswordcb.TabIndex = 13;
            showpasswordcb.Text = "Show Password";
            showpasswordcb.UseVisualStyleBackColor = true;
            showpasswordcb.CheckedChanged += showpasswordcb_CheckedChanged;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(638, 295);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(347, 83);
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(637, 218);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(347, 83);
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(646, 165);
            label1.Name = "label1";
            label1.Size = new Size(340, 21);
            label1.TabIndex = 2;
            label1.Text = "Please log in to access your account.";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(764, 76);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(114, 75);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(562, 561);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 561);
            Controls.Add(loginform);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            loginform.ResumeLayout(false);
            loginform.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel loginform;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private ReaLTaiizor.Controls.HopeCheckBox showpasswordcb;
        private ReaLTaiizor.Controls.HopeTextBox txtEmail;
        private ReaLTaiizor.Controls.HopeTextBox txtPassword;
        private ReaLTaiizor.Controls.HopeRoundButton loginbt;
        private PictureBox pictureBox8;
        private PictureBox pictureBox5;
    }
}
