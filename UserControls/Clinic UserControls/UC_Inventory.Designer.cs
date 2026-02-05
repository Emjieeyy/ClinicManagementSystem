namespace ClinicManagementSystem
{
    partial class UC_Inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Inventory));
            pictureBox9 = new PictureBox();
            hopeButton2 = new ReaLTaiizor.Controls.HopeButton();
            SaveBtn = new ReaLTaiizor.Controls.HopeRoundButton();
            DeductStockBtn = new ReaLTaiizor.Controls.HopeRoundButton();
            UpdateStockBtn = new ReaLTaiizor.Controls.HopeRoundButton();
            AddItemBtn = new ReaLTaiizor.Controls.HopeRoundButton();
            SearchBtn = new ReaLTaiizor.Controls.HopeRoundButton();
            dtgInventory = new DataGridView();
            ItemID = new DataGridViewTextBoxColumn();
            ItemName = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            ExpiryDate = new DataGridViewTextBoxColumn();
            SearchTxt = new ReaLTaiizor.Controls.HopeTextBox();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            bigLabel3 = new ReaLTaiizor.Controls.BigLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgInventory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.FromArgb(64, 158, 255);
            pictureBox9.BackgroundImage = (Image)resources.GetObject("pictureBox9.BackgroundImage");
            pictureBox9.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox9.Location = new Point(318, 152);
            pictureBox9.Margin = new Padding(3, 3, 3, 2);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(44, 30);
            pictureBox9.TabIndex = 40;
            pictureBox9.TabStop = false;
            // 
            // hopeButton2
            // 
            hopeButton2.BorderColor = Color.FromArgb(220, 223, 230);
            hopeButton2.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            hopeButton2.DangerColor = Color.FromArgb(245, 108, 108);
            hopeButton2.DefaultColor = Color.FromArgb(255, 255, 255);
            hopeButton2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hopeButton2.HoverTextColor = Color.FromArgb(48, 49, 51);
            hopeButton2.InfoColor = Color.FromArgb(144, 147, 153);
            hopeButton2.Location = new Point(311, 141);
            hopeButton2.Name = "hopeButton2";
            hopeButton2.PrimaryColor = Color.FromArgb(64, 158, 255);
            hopeButton2.Size = new Size(247, 50);
            hopeButton2.SuccessColor = Color.FromArgb(103, 194, 58);
            hopeButton2.TabIndex = 39;
            hopeButton2.Text = "     Low inventory alert";
            hopeButton2.TextColor = Color.White;
            hopeButton2.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.FromArgb(64, 158, 255);
            SaveBtn.BorderColor = Color.FromArgb(64, 158, 255);
            SaveBtn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            SaveBtn.DangerColor = Color.FromArgb(245, 108, 108);
            SaveBtn.DefaultColor = Color.FromArgb(255, 255, 255);
            SaveBtn.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveBtn.ForeColor = Color.White;
            SaveBtn.HoverTextColor = Color.FromArgb(48, 49, 51);
            SaveBtn.InfoColor = Color.FromArgb(144, 147, 153);
            SaveBtn.Location = new Point(628, 632);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.PrimaryColor = Color.FromArgb(96, 125, 139);
            SaveBtn.Size = new Size(171, 50);
            SaveBtn.SuccessColor = Color.FromArgb(103, 194, 58);
            SaveBtn.TabIndex = 35;
            SaveBtn.Text = "Save";
            SaveBtn.TextColor = Color.White;
            SaveBtn.WarningColor = Color.FromArgb(230, 162, 60);
            SaveBtn.Click += SaveBtn_Click;
            // 
            // DeductStockBtn
            // 
            DeductStockBtn.BackColor = Color.FromArgb(255, 152, 0);
            DeductStockBtn.BorderColor = Color.FromArgb(255, 152, 0);
            DeductStockBtn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            DeductStockBtn.DangerColor = Color.FromArgb(245, 108, 108);
            DeductStockBtn.DefaultColor = Color.FromArgb(255, 255, 255);
            DeductStockBtn.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeductStockBtn.ForeColor = Color.White;
            DeductStockBtn.HoverTextColor = Color.FromArgb(48, 49, 51);
            DeductStockBtn.InfoColor = Color.FromArgb(144, 147, 153);
            DeductStockBtn.Location = new Point(432, 632);
            DeductStockBtn.Name = "DeductStockBtn";
            DeductStockBtn.PrimaryColor = Color.FromArgb(255, 152, 0);
            DeductStockBtn.Size = new Size(170, 50);
            DeductStockBtn.SuccessColor = Color.FromArgb(103, 194, 58);
            DeductStockBtn.TabIndex = 34;
            DeductStockBtn.Text = "Deduct Stock";
            DeductStockBtn.TextColor = Color.White;
            DeductStockBtn.WarningColor = Color.FromArgb(230, 162, 60);
            DeductStockBtn.Click += DeductStockBtn_Click;
            // 
            // UpdateStockBtn
            // 
            UpdateStockBtn.BackColor = Color.FromArgb(64, 158, 255);
            UpdateStockBtn.BorderColor = Color.FromArgb(64, 158, 255);
            UpdateStockBtn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            UpdateStockBtn.DangerColor = Color.FromArgb(245, 108, 108);
            UpdateStockBtn.DefaultColor = Color.FromArgb(255, 255, 255);
            UpdateStockBtn.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateStockBtn.ForeColor = Color.White;
            UpdateStockBtn.HoverTextColor = Color.FromArgb(48, 49, 51);
            UpdateStockBtn.InfoColor = Color.FromArgb(144, 147, 153);
            UpdateStockBtn.Location = new Point(235, 632);
            UpdateStockBtn.Name = "UpdateStockBtn";
            UpdateStockBtn.PrimaryColor = Color.FromArgb(33, 150, 243);
            UpdateStockBtn.Size = new Size(170, 50);
            UpdateStockBtn.SuccessColor = Color.FromArgb(103, 194, 58);
            UpdateStockBtn.TabIndex = 33;
            UpdateStockBtn.Text = "Update Stock";
            UpdateStockBtn.TextColor = Color.White;
            UpdateStockBtn.WarningColor = Color.FromArgb(230, 162, 60);
            UpdateStockBtn.Click += UpdateStockBtn_Click;
            // 
            // AddItemBtn
            // 
            AddItemBtn.BackColor = Color.FromArgb(76, 175, 80);
            AddItemBtn.BorderColor = Color.FromArgb(76, 175, 80);
            AddItemBtn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            AddItemBtn.DangerColor = Color.FromArgb(245, 108, 108);
            AddItemBtn.DefaultColor = Color.FromArgb(255, 255, 255);
            AddItemBtn.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddItemBtn.ForeColor = Color.White;
            AddItemBtn.HoverTextColor = Color.FromArgb(48, 49, 51);
            AddItemBtn.InfoColor = Color.FromArgb(144, 147, 153);
            AddItemBtn.Location = new Point(31, 632);
            AddItemBtn.Name = "AddItemBtn";
            AddItemBtn.PrimaryColor = Color.FromArgb(76, 175, 80);
            AddItemBtn.Size = new Size(170, 50);
            AddItemBtn.SuccessColor = Color.FromArgb(103, 194, 58);
            AddItemBtn.TabIndex = 32;
            AddItemBtn.Text = "Add Item";
            AddItemBtn.TextColor = Color.White;
            AddItemBtn.WarningColor = Color.FromArgb(230, 162, 60);
            AddItemBtn.Click += AddItemBtn_Click;
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = Color.FromArgb(64, 158, 255);
            SearchBtn.BorderColor = Color.FromArgb(64, 158, 255);
            SearchBtn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            SearchBtn.DangerColor = Color.FromArgb(245, 108, 108);
            SearchBtn.DefaultColor = Color.FromArgb(255, 255, 255);
            SearchBtn.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchBtn.ForeColor = Color.White;
            SearchBtn.HoverTextColor = Color.FromArgb(48, 49, 51);
            SearchBtn.InfoColor = Color.FromArgb(144, 147, 153);
            SearchBtn.Location = new Point(625, 34);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.PrimaryColor = Color.FromArgb(64, 158, 255);
            SearchBtn.Size = new Size(106, 41);
            SearchBtn.SuccessColor = Color.FromArgb(103, 194, 58);
            SearchBtn.TabIndex = 30;
            SearchBtn.Text = "Search";
            SearchBtn.TextColor = Color.White;
            SearchBtn.WarningColor = Color.FromArgb(230, 162, 60);
            SearchBtn.Click += hopeRoundButton9_Click;
            // 
            // dtgInventory
            // 
            dtgInventory.AllowUserToOrderColumns = true;
            dtgInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgInventory.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgInventory.BackgroundColor = SystemColors.ControlLightLight;
            dtgInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgInventory.Columns.AddRange(new DataGridViewColumn[] { ItemID, ItemName, Quantity, ExpiryDate });
            dtgInventory.GridColor = SystemColors.InactiveCaptionText;
            dtgInventory.Location = new Point(26, 212);
            dtgInventory.MultiSelect = false;
            dtgInventory.Name = "dtgInventory";
            dtgInventory.RowHeadersVisible = false;
            dtgInventory.RowHeadersWidth = 51;
            dtgInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgInventory.Size = new Size(773, 396);
            dtgInventory.TabIndex = 31;
            dtgInventory.DataError += dtgInventory_DataError;
            // 
            // ItemID
            // 
            ItemID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ItemID.DataPropertyName = "ItemID";
            ItemID.HeaderText = "ItemID";
            ItemID.MinimumWidth = 6;
            ItemID.Name = "ItemID";
            ItemID.Width = 83;
            // 
            // ItemName
            // 
            ItemName.DataPropertyName = "ItemName";
            ItemName.HeaderText = "ItemName";
            ItemName.MinimumWidth = 6;
            ItemName.Name = "ItemName";
            // 
            // Quantity
            // 
            Quantity.DataPropertyName = "Quantity";
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            // 
            // ExpiryDate
            // 
            ExpiryDate.DataPropertyName = "ExpiryDate";
            ExpiryDate.HeaderText = "ExpiryDate";
            ExpiryDate.MinimumWidth = 6;
            ExpiryDate.Name = "ExpiryDate";
            // 
            // SearchTxt
            // 
            SearchTxt.BackColor = Color.White;
            SearchTxt.BaseColor = Color.White;
            SearchTxt.BorderColorA = Color.FromArgb(64, 158, 255);
            SearchTxt.BorderColorB = Color.FromArgb(220, 223, 230);
            SearchTxt.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            SearchTxt.ForeColor = Color.FromArgb(48, 49, 51);
            SearchTxt.Hint = "";
            SearchTxt.Location = new Point(403, 37);
            SearchTxt.MaxLength = 32767;
            SearchTxt.Multiline = false;
            SearchTxt.Name = "SearchTxt";
            SearchTxt.PasswordChar = '\0';
            SearchTxt.ScrollBars = ScrollBars.None;
            SearchTxt.SelectedText = "";
            SearchTxt.SelectionLength = 0;
            SearchTxt.SelectionStart = 0;
            SearchTxt.Size = new Size(217, 35);
            SearchTxt.TabIndex = 29;
            SearchTxt.TabStop = false;
            SearchTxt.Text = "Search Records...";
            SearchTxt.UseSystemPasswordChar = false;
            SearchTxt.Click += SearchTxt_Click;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Century Gothic", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.DodgerBlue;
            bigLabel1.Location = new Point(15, 26);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(235, 56);
            bigLabel1.TabIndex = 27;
            bigLabel1.Text = "Inventory";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(721, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 62);
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(74, 155, 250);
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(77, 153);
            label2.Name = "label2";
            label2.Size = new Size(209, 19);
            label2.TabIndex = 64;
            label2.Text = "Total consultations today";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(64, 158, 255);
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(32, 146);
            pictureBox2.Margin = new Padding(3, 3, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 31);
            pictureBox2.TabIndex = 62;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(15, 112);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(290, 87);
            pictureBox3.TabIndex = 63;
            pictureBox3.TabStop = false;
            // 
            // bigLabel3
            // 
            bigLabel3.AutoSize = true;
            bigLabel3.BackColor = Color.Transparent;
            bigLabel3.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            bigLabel3.ForeColor = SystemColors.ActiveCaptionText;
            bigLabel3.Location = new Point(28, 86);
            bigLabel3.Name = "bigLabel3";
            bigLabel3.Size = new Size(352, 18);
            bigLabel3.TabIndex = 65;
            bigLabel3.Text = "Ensuring Availability of Essential Clinic Supplies.";
            // 
            // UC_Inventory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(bigLabel3);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox9);
            Controls.Add(hopeButton2);
            Controls.Add(SaveBtn);
            Controls.Add(DeductStockBtn);
            Controls.Add(UpdateStockBtn);
            Controls.Add(AddItemBtn);
            Controls.Add(SearchBtn);
            Controls.Add(dtgInventory);
            Controls.Add(SearchTxt);
            Controls.Add(bigLabel1);
            Controls.Add(pictureBox1);
            Name = "UC_Inventory";
            Size = new Size(828, 705);
            Load += UC_Inventory_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgInventory).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox9;
        private ReaLTaiizor.Controls.HopeButton hopeButton2;
        private ReaLTaiizor.Controls.HopeRoundButton SaveBtn;
        private ReaLTaiizor.Controls.HopeRoundButton DeductStockBtn;
        private ReaLTaiizor.Controls.HopeRoundButton UpdateStockBtn;
        private ReaLTaiizor.Controls.HopeRoundButton AddItemBtn;
        private ReaLTaiizor.Controls.HopeRoundButton SearchBtn;
        private DataGridView dtgInventory;
        private ReaLTaiizor.Controls.HopeTextBox SearchTxt;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private PictureBox pictureBox1;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private ReaLTaiizor.Controls.BigLabel bigLabel3;
        private DataGridViewTextBoxColumn ItemID;
        private DataGridViewTextBoxColumn ItemName;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn ExpiryDate;
    }
}
