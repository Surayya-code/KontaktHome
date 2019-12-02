namespace ContactHomeWindowsFormsApp.User
{
    partial class UserMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMainForm));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWriteUs = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabProduct = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearchh = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.dataSet = new ContactHomeWindowsFormsApp.Data.ContactHomeDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.categoriesTableAdapter1 = new ContactHomeWindowsFormsApp.Data.ContactHomeDataSetTableAdapters.CategoriesTableAdapter();
            this.checkedListCategories = new System.Windows.Forms.CheckedListBox();
            this.checkedListSubCategories = new System.Windows.Forms.CheckedListBox();
            this.btnChoose = new System.Windows.Forms.Button();
            this.product2 = new ContactHomeWindowsFormsApp.Core.Controls.Product();
            this.product3 = new ContactHomeWindowsFormsApp.Core.Controls.Product();
            this.product4 = new ContactHomeWindowsFormsApp.Core.Controls.Product();
            this.product5 = new ContactHomeWindowsFormsApp.Core.Controls.Product();
            this.product6 = new ContactHomeWindowsFormsApp.Core.Controls.Product();
            this.product10 = new ContactHomeWindowsFormsApp.Core.Controls.Product();
            this.subCategoriesTableAdapter1 = new ContactHomeWindowsFormsApp.Data.ContactHomeDataSetTableAdapters.SubCategoriesTableAdapter();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.product2);
            this.flowLayoutPanel1.Controls.Add(this.product3);
            this.flowLayoutPanel1.Controls.Add(this.product4);
            this.flowLayoutPanel1.Controls.Add(this.product5);
            this.flowLayoutPanel1.Controls.Add(this.product6);
            this.flowLayoutPanel1.Controls.Add(this.product10);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(271, 90);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(802, 494);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(754, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Haqqımızda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(856, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kampaniyalar";
            // 
            // lblWriteUs
            // 
            this.lblWriteUs.AutoSize = true;
            this.lblWriteUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWriteUs.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblWriteUs.Location = new System.Drawing.Point(966, 6);
            this.lblWriteUs.Name = "lblWriteUs";
            this.lblWriteUs.Size = new System.Drawing.Size(74, 17);
            this.lblWriteUs.TabIndex = 3;
            this.lblWriteUs.Text = "Bizə Yazın";
            this.lblWriteUs.Click += new System.EventHandler(this.lblWriteUs_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panel2.Controls.Add(this.lblWriteUs);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1298, 84);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(47)))), ((int)(((byte)(6)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabProduct);
            this.tabControl1.Controls.Add(this.tabSearch);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 93);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(216, 432);
            this.tabControl1.TabIndex = 6;
            // 
            // tabProduct
            // 
            this.tabProduct.Controls.Add(this.btnChoose);
            this.tabProduct.Controls.Add(this.splitContainer1);
            this.tabProduct.Location = new System.Drawing.Point(4, 25);
            this.tabProduct.Name = "tabProduct";
            this.tabProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabProduct.Size = new System.Drawing.Size(208, 403);
            this.tabProduct.TabIndex = 0;
            this.tabProduct.Text = "Məhsullar";
            this.tabProduct.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(2, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.checkedListCategories);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.checkedListSubCategories);
            this.splitContainer1.Size = new System.Drawing.Size(191, 257);
            this.splitContainer1.SplitterDistance = 209;
            this.splitContainer1.TabIndex = 5;
            // 
            // tabSearch
            // 
            this.tabSearch.Controls.Add(this.btnDelete);
            this.tabSearch.Controls.Add(this.btnSearchh);
            this.tabSearch.Controls.Add(this.checkedListBox1);
            this.tabSearch.Controls.Add(this.groupBox1);
            this.tabSearch.Location = new System.Drawing.Point(4, 25);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearch.Size = new System.Drawing.Size(208, 403);
            this.tabSearch.TabIndex = 1;
            this.tabSearch.Text = "Axtarış";
            this.tabSearch.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(88, 353);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 32);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnSearchh
            // 
            this.btnSearchh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnSearchh.FlatAppearance.BorderSize = 0;
            this.btnSearchh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearchh.Location = new System.Drawing.Point(6, 353);
            this.btnSearchh.Name = "btnSearchh";
            this.btnSearchh.Size = new System.Drawing.Size(75, 32);
            this.btnSearchh.TabIndex = 0;
            this.btnSearchh.Text = "Axtar";
            this.btnSearchh.UseVisualStyleBackColor = false;
            this.btnSearchh.Click += new System.EventHandler(this.btnSearchh_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(2, 66);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(177, 256);
            this.checkedListBox1.TabIndex = 1;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "ContactHomeDataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 56);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Qiymətə görə";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 2;
            this.numericUpDown2.Location = new System.Drawing.Point(84, 20);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            8000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(78, 23);
            this.numericUpDown2.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(1, 20);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            8000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(81, 23);
            this.numericUpDown1.TabIndex = 0;
            // 
            // categoriesTableAdapter1
            // 
            this.categoriesTableAdapter1.ClearBeforeFill = true;
            // 
            // checkedListCategories
            // 
            this.checkedListCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListCategories.FormattingEnabled = true;
            this.checkedListCategories.Location = new System.Drawing.Point(0, 0);
            this.checkedListCategories.Name = "checkedListCategories";
            this.checkedListCategories.Size = new System.Drawing.Size(191, 209);
            this.checkedListCategories.TabIndex = 0;
            // 
            // checkedListSubCategories
            // 
            this.checkedListSubCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListSubCategories.FormattingEnabled = true;
            this.checkedListSubCategories.Location = new System.Drawing.Point(0, 0);
            this.checkedListSubCategories.Name = "checkedListSubCategories";
            this.checkedListSubCategories.Size = new System.Drawing.Size(191, 44);
            this.checkedListSubCategories.TabIndex = 6;
            // 
            // btnChoose
            // 
            this.btnChoose.BackColor = System.Drawing.Color.DarkRed;
            this.btnChoose.ForeColor = System.Drawing.SystemColors.Control;
            this.btnChoose.Location = new System.Drawing.Point(6, 352);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(81, 34);
            this.btnChoose.TabIndex = 6;
            this.btnChoose.Text = "Seçin";
            this.btnChoose.UseVisualStyleBackColor = false;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // product2
            // 
            this.product2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.product2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.product2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.product2.Id = 2;
            this.product2.Location = new System.Drawing.Point(3, 3);
            this.product2.Name = "product2";
            this.product2.NameProduct = "Televizor";
            this.product2.Picture = ((System.Drawing.Image)(resources.GetObject("product2.Picture")));
            this.product2.Price = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.product2.Size = new System.Drawing.Size(215, 238);
            this.product2.TabIndex = 1;
            this.product2.Click += new System.EventHandler(this.product1_Click);
            // 
            // product3
            // 
            this.product3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.product3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.product3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.product3.Id = 0;
            this.product3.Location = new System.Drawing.Point(224, 3);
            this.product3.Name = "product3";
            this.product3.NameProduct = "label1";
            this.product3.Picture = ((System.Drawing.Image)(resources.GetObject("product3.Picture")));
            this.product3.Price = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.product3.Size = new System.Drawing.Size(215, 238);
            this.product3.TabIndex = 2;
            this.product3.Click += new System.EventHandler(this.product1_Click);
            // 
            // product4
            // 
            this.product4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.product4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.product4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.product4.Id = 0;
            this.product4.Location = new System.Drawing.Point(445, 3);
            this.product4.Name = "product4";
            this.product4.NameProduct = "label1";
            this.product4.Picture = ((System.Drawing.Image)(resources.GetObject("product4.Picture")));
            this.product4.Price = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.product4.Size = new System.Drawing.Size(215, 238);
            this.product4.TabIndex = 3;
            this.product4.Click += new System.EventHandler(this.product1_Click);
            // 
            // product5
            // 
            this.product5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.product5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.product5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.product5.Id = 0;
            this.product5.Location = new System.Drawing.Point(3, 247);
            this.product5.Name = "product5";
            this.product5.NameProduct = "label1";
            this.product5.Picture = ((System.Drawing.Image)(resources.GetObject("product5.Picture")));
            this.product5.Price = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.product5.Size = new System.Drawing.Size(215, 239);
            this.product5.TabIndex = 4;
            this.product5.Click += new System.EventHandler(this.product1_Click);
            // 
            // product6
            // 
            this.product6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.product6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.product6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.product6.Id = 0;
            this.product6.Location = new System.Drawing.Point(224, 247);
            this.product6.Name = "product6";
            this.product6.NameProduct = "label1";
            this.product6.Picture = ((System.Drawing.Image)(resources.GetObject("product6.Picture")));
            this.product6.Price = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.product6.Size = new System.Drawing.Size(215, 239);
            this.product6.TabIndex = 5;
            this.product6.Click += new System.EventHandler(this.product1_Click);
            // 
            // product10
            // 
            this.product10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.product10.Id = 0;
            this.product10.Location = new System.Drawing.Point(445, 247);
            this.product10.Name = "product10";
            this.product10.NameProduct = "label1";
            this.product10.Picture = ((System.Drawing.Image)(resources.GetObject("product10.Picture")));
            this.product10.Price = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.product10.Size = new System.Drawing.Size(227, 256);
            this.product10.TabIndex = 9;
            // 
            // subCategoriesTableAdapter1
            // 
            this.subCategoriesTableAdapter1.ClearBeforeFill = true;
            // 
            // HomePageForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1298, 590);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Name = "HomePageForm";
            this.Text = "HomePageForm";
            this.Load += new System.EventHandler(this.HomePageForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabProduct.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWriteUs;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Core.Controls.Product product2;
        private Core.Controls.Product product3;
        private Core.Controls.Product product4;
        private Core.Controls.Product product5;
        private Core.Controls.Product product6;
        private Core.Controls.Product product10;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearchh;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TabPage tabProduct;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Data.ContactHomeDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter1;
        private Data.ContactHomeDataSet dataSet;
        private System.Windows.Forms.CheckedListBox checkedListCategories;
        private System.Windows.Forms.CheckedListBox checkedListSubCategories;
        private System.Windows.Forms.Button btnChoose;
        private Data.ContactHomeDataSetTableAdapters.SubCategoriesTableAdapter subCategoriesTableAdapter1;
    }
}