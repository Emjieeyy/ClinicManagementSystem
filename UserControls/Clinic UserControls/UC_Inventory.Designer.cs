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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Inventory));
            LowInvAlertBtn = new ReaLTaiizor.Controls.HopeButton();
            SaveBtn = new ReaLTaiizor.Controls.HopeRoundButton();
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
            pictureBox3 = new PictureBox();
            bigLabel3 = new ReaLTaiizor.Controls.BigLabel();
            DeleteItembtn = new ReaLTaiizor.Controls.HopeRoundButton();
            Inventory_label_0 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgInventory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // LowInvAlertBtn
            // 
            LowInvAlertBtn.BorderColor = Color.FromArgb(220, 223, 230);
            LowInvAlertBtn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            LowInvAlertBtn.DangerColor = Color.FromArgb(245, 108, 108);
            LowInvAlertBtn.DefaultColor = Color.FromArgb(255, 255, 255);
            LowInvAlertBtn.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LowInvAlertBtn.HoverTextColor = Color.FromArgb(48, 49, 51);
            LowInvAlertBtn.InfoColor = Color.FromArgb(144, 147, 153);
            LowInvAlertBtn.Location = new Point(323, 157);
            LowInvAlertBtn.Name = "LowInvAlertBtn";
            LowInvAlertBtn.PrimaryColor = Color.FromArgb(64, 158, 255);
            LowInvAlertBtn.Size = new Size(246, 50);
            LowInvAlertBtn.SuccessColor = Color.FromArgb(103, 194, 58);
            LowInvAlertBtn.TabIndex = 39;
            LowInvAlertBtn.Text = "Low inventory alert       ";
            LowInvAlertBtn.TextColor = Color.White;
            LowInvAlertBtn.WarningColor = Color.FromArgb(230, 162, 60);
            LowInvAlertBtn.Click += LowInvAlertBtn_Click;
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
            SaveBtn.Location = new Point(638, 645);
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
            UpdateStockBtn.Location = new Point(237, 645);
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
            AddItemBtn.Location = new Point(32, 645);
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
            SearchBtn.Location = new Point(636, 40);
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
            dtgInventory.AllowUserToAddRows = false;
            dtgInventory.AllowUserToOrderColumns = true;
            dtgInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgInventory.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgInventory.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgInventory.Columns.AddRange(new DataGridViewColumn[] { ItemID, ItemName, Quantity, ExpiryDate });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dtgInventory.DefaultCellStyle = dataGridViewCellStyle6;
            dtgInventory.GridColor = Color.White;
            dtgInventory.Location = new Point(31, 228);
            dtgInventory.MultiSelect = false;
            dtgInventory.Name = "dtgInventory";
            dtgInventory.RowHeadersVisible = false;
            dtgInventory.RowHeadersWidth = 51;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = Color.Blue;
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dtgInventory.RowsDefaultCellStyle = dataGridViewCellStyle7;
            dtgInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgInventory.Size = new Size(779, 396);
            dtgInventory.TabIndex = 31;
            dtgInventory.CellContentClick += dtgInventory_CellContentClick;
            // 
            // ItemID
            // 
            ItemID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ItemID.DataPropertyName = "ItemId";
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            ItemID.DefaultCellStyle = dataGridViewCellStyle2;
            ItemID.HeaderText = "ItemID";
            ItemID.MinimumWidth = 6;
            ItemID.Name = "ItemID";
            ItemID.Width = 83;
            // 
            // ItemName
            // 
            ItemName.DataPropertyName = "ItemName";
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.Blue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            ItemName.DefaultCellStyle = dataGridViewCellStyle3;
            ItemName.HeaderText = "ItemName";
            ItemName.MinimumWidth = 6;
            ItemName.Name = "ItemName";
            // 
            // Quantity
            // 
            Quantity.DataPropertyName = "Quantity";
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.Blue;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            Quantity.DefaultCellStyle = dataGridViewCellStyle4;
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            // 
            // ExpiryDate
            // 
            ExpiryDate.DataPropertyName = "ExpiryDate";
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.Blue;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            ExpiryDate.DefaultCellStyle = dataGridViewCellStyle5;
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
            SearchTxt.Location = new Point(414, 43);
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
            SearchTxt.UseSystemPasswordChar = false;
            SearchTxt.Click += SearchTxt_Click;
            SearchTxt.TextChanged += SearchTxt_TextChanged;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Century Gothic", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.DodgerBlue;
            bigLabel1.Location = new Point(20, 29);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(235, 56);
            bigLabel1.TabIndex = 27;
            bigLabel1.Text = "Inventory";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(732, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 62);
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(74, 155, 250);
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(49, 169);
            label2.Name = "label2";
            label2.Size = new Size(214, 19);
            label2.TabIndex = 64;
            label2.Text = "Total consultations today:";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(20, 128);
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
            bigLabel3.Location = new Point(33, 91);
            bigLabel3.Name = "bigLabel3";
            bigLabel3.Size = new Size(352, 18);
            bigLabel3.TabIndex = 65;
            bigLabel3.Text = "Ensuring Availability of Essential Clinic Supplies.";
            // 
            // DeleteItembtn
            // 
            DeleteItembtn.BackColor = Color.FromArgb(64, 158, 255);
            DeleteItembtn.BorderColor = Color.FromArgb(64, 158, 255);
            DeleteItembtn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            DeleteItembtn.DangerColor = Color.FromArgb(245, 108, 108);
            DeleteItembtn.DefaultColor = Color.FromArgb(255, 255, 255);
            DeleteItembtn.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteItembtn.ForeColor = Color.White;
            DeleteItembtn.HoverTextColor = Color.Red;
            DeleteItembtn.InfoColor = Color.FromArgb(144, 147, 153);
            DeleteItembtn.Location = new Point(437, 645);
            DeleteItembtn.Name = "DeleteItembtn";
            DeleteItembtn.PrimaryColor = Color.Red;
            DeleteItembtn.Size = new Size(171, 50);
            DeleteItembtn.SuccessColor = Color.FromArgb(103, 194, 58);
            DeleteItembtn.TabIndex = 66;
            DeleteItembtn.Text = "Delete Item";
            DeleteItembtn.TextColor = Color.White;
            DeleteItembtn.WarningColor = Color.FromArgb(230, 162, 60);
            DeleteItembtn.Click += DeleteItembtn_Click;
            // 
            // Inventory_label_0
            // 
            Inventory_label_0.AutoSize = true;
            Inventory_label_0.BackColor = Color.FromArgb(74, 155, 250);
            Inventory_label_0.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Inventory_label_0.ForeColor = Color.White;
            Inventory_label_0.Location = new Point(269, 169);
            Inventory_label_0.Name = "Inventory_label_0";
            Inventory_label_0.Size = new Size(19, 19);
            Inventory_label_0.TabIndex = 67;
            Inventory_label_0.Text = "0";
            // 
            // UC_Inventory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(Inventory_label_0);
            Controls.Add(DeleteItembtn);
            Controls.Add(bigLabel3);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(LowInvAlertBtn);
            Controls.Add(SaveBtn);
            Controls.Add(UpdateStockBtn);
            Controls.Add(AddItemBtn);
            Controls.Add(SearchBtn);
            Controls.Add(dtgInventory);
            Controls.Add(SearchTxt);
            Controls.Add(bigLabel1);
            Controls.Add(pictureBox1);
            Name = "UC_Inventory";
            Size = new Size(828, 705);
            ((System.ComponentModel.ISupportInitialize)dtgInventory).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ReaLTaiizor.Controls.HopeButton LowInvAlertBtn;
        private ReaLTaiizor.Controls.HopeRoundButton SaveBtn;
        private ReaLTaiizor.Controls.HopeRoundButton UpdateStockBtn;
        private ReaLTaiizor.Controls.HopeRoundButton AddItemBtn;
        private ReaLTaiizor.Controls.HopeRoundButton SearchBtn;
        private DataGridView dtgInventory;
        private ReaLTaiizor.Controls.HopeTextBox SearchTxt;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private PictureBox pictureBox1;
        private Label label2;
        private PictureBox pictureBox3;
        private ReaLTaiizor.Controls.BigLabel bigLabel3;
        private ReaLTaiizor.Controls.HopeRoundButton DeleteItembtn;
        private Label Inventory_label_0;
        private DataGridViewTextBoxColumn ItemID;
        private DataGridViewTextBoxColumn ItemName;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn ExpiryDate;
    }
}
