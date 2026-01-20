namespace ClinicManagementSystem
{
    partial class AddInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddInformation));
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            exit = new Label();
            pictureBox1 = new PictureBox();
            addbt = new ReaLTaiizor.Controls.HopeRoundButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Location = new Point(225, 182);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(268, 27);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(115, 188);
            label1.Name = "label1";
            label1.Size = new Size(81, 18);
            label1.TabIndex = 1;
            label1.Text = "StudentID:";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.Location = new Point(225, 229);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(268, 27);
            textBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(109, 238);
            label2.Name = "label2";
            label2.Size = new Size(115, 18);
            label2.TabIndex = 3;
            label2.Text = " StudentName:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(115, 282);
            label3.Name = "label3";
            label3.Size = new Size(64, 18);
            label3.TabIndex = 4;
            label3.Text = "Course:";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.White;
            textBox3.Location = new Point(225, 275);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(268, 27);
            textBox3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(111, 325);
            label4.Name = "label4";
            label4.Size = new Size(91, 18);
            label4.TabIndex = 6;
            label4.Text = " Symptoms:";
            label4.Click += label4_Click;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.White;
            textBox4.Location = new Point(225, 318);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(268, 27);
            textBox4.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(115, 369);
            label6.Name = "label6";
            label6.Size = new Size(96, 18);
            label6.TabIndex = 10;
            label6.Text = "DateVisited:";
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.White;
            textBox6.Location = new Point(225, 366);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(268, 27);
            textBox6.TabIndex = 11;
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exit.ForeColor = Color.Red;
            exit.Location = new Point(604, 9);
            exit.Name = "exit";
            exit.Size = new Size(21, 23);
            exit.TabIndex = 20;
            exit.Text = "x";
            exit.Click += exit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(139, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(355, 126);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // addbt
            // 
            addbt.BorderColor = Color.FromArgb(220, 223, 230);
            addbt.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            addbt.DangerColor = Color.FromArgb(245, 108, 108);
            addbt.DefaultColor = Color.FromArgb(255, 255, 255);
            addbt.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addbt.HoverTextColor = Color.FromArgb(48, 49, 51);
            addbt.InfoColor = Color.FromArgb(144, 147, 153);
            addbt.Location = new Point(377, 420);
            addbt.Name = "addbt";
            addbt.PrimaryColor = Color.FromArgb(76, 175, 80);
            addbt.Size = new Size(118, 39);
            addbt.SuccessColor = Color.FromArgb(103, 194, 58);
            addbt.TabIndex = 23;
            addbt.Text = "Add";
            addbt.TextColor = Color.White;
            addbt.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // AddInformation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(637, 509);
            Controls.Add(addbt);
            Controls.Add(pictureBox1);
            Controls.Add(exit);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddInformation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddInformation";
            Load += AddInformation_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox6;
        private Label exit;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.HopeRoundButton addbt;
    }
}