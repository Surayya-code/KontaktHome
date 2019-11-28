namespace ContactHomeWindowsFormsApp.Admin
{
    partial class All_Products
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(All_Products));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSetImage = new System.Windows.Forms.Button();
            this.numericPrice = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.pictureProducts = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblSubcategory = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtProductAdd = new System.Windows.Forms.TextBox();
            this.cmbSubcategoryChos = new System.Windows.Forms.ComboBox();
            this.subCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactHomeDataSet = new ContactHomeWindowsFormsApp.Data.ContactHomeDataSet();
            this.cmbCategoryChose = new System.Windows.Forms.ComboBox();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesTableAdapter = new ContactHomeWindowsFormsApp.Data.ContactHomeDataSetTableAdapters.CategoriesTableAdapter();
            this.subCategoriesTableAdapter = new ContactHomeWindowsFormsApp.Data.ContactHomeDataSetTableAdapters.SubCategoriesTableAdapter();
            this.productsTableAdapter = new ContactHomeWindowsFormsApp.Data.ContactHomeDataSetTableAdapters.ProductsTableAdapter();
            this.fKProductsSubCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnBack = new System.Windows.Forms.Button();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ımageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subCategoryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subCategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactHomeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKProductsSubCategoriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.btnSetImage);
            this.groupBox1.Controls.Add(this.numericPrice);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnAddProduct);
            this.groupBox1.Controls.Add(this.btnDeleteProduct);
            this.groupBox1.Controls.Add(this.btnSearchProduct);
            this.groupBox1.Controls.Add(this.btnEditProduct);
            this.groupBox1.Controls.Add(this.pictureProducts);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblProduct);
            this.groupBox1.Controls.Add(this.lblSubcategory);
            this.groupBox1.Controls.Add(this.lblCategory);
            this.groupBox1.Controls.Add(this.txtProductAdd);
            this.groupBox1.Controls.Add(this.cmbSubcategoryChos);
            this.groupBox1.Controls.Add(this.cmbCategoryChose);
            this.groupBox1.Location = new System.Drawing.Point(27, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 418);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnSetImage
            // 
            this.btnSetImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetImage.Location = new System.Drawing.Point(198, 202);
            this.btnSetImage.Name = "btnSetImage";
            this.btnSetImage.Size = new System.Drawing.Size(104, 33);
            this.btnSetImage.TabIndex = 24;
            this.btnSetImage.Text = "Set Image";
            this.btnSetImage.UseVisualStyleBackColor = true;
            this.btnSetImage.Click += new System.EventHandler(this.btnSetImage_Click);
            // 
            // numericPrice
            // 
            this.numericPrice.DecimalPlaces = 2;
            this.numericPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericPrice.Location = new System.Drawing.Point(13, 258);
            this.numericPrice.Maximum = new decimal(new int[] {
            8000,
            0,
            0,
            0});
            this.numericPrice.Name = "numericPrice";
            this.numericPrice.Size = new System.Drawing.Size(160, 23);
            this.numericPrice.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 28);
            this.label4.TabIndex = 22;
            this.label4.Text = "Products";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.Location = new System.Drawing.Point(198, 245);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(104, 32);
            this.btnAddProduct.TabIndex = 21;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.Location = new System.Drawing.Point(198, 360);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(104, 32);
            this.btnDeleteProduct.TabIndex = 18;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchProduct.Location = new System.Drawing.Point(198, 322);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(104, 32);
            this.btnSearchProduct.TabIndex = 19;
            this.btnSearchProduct.Text = "Search";
            this.btnSearchProduct.UseVisualStyleBackColor = true;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProduct.Location = new System.Drawing.Point(198, 284);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(104, 32);
            this.btnEditProduct.TabIndex = 20;
            this.btnEditProduct.Text = "Edit";
            this.btnEditProduct.UseVisualStyleBackColor = true;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // pictureProducts
            // 
            this.pictureProducts.Location = new System.Drawing.Point(191, 59);
            this.pictureProducts.Name = "pictureProducts";
            this.pictureProducts.Size = new System.Drawing.Size(120, 137);
            this.pictureProducts.TabIndex = 17;
            this.pictureProducts.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(224, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Image:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(13, 316);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(160, 23);
            this.txtDescription.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Price:";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(10, 178);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(61, 17);
            this.lblProduct.TabIndex = 5;
            this.lblProduct.Text = "Product:";
            // 
            // lblSubcategory
            // 
            this.lblSubcategory.AutoSize = true;
            this.lblSubcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubcategory.Location = new System.Drawing.Point(8, 115);
            this.lblSubcategory.Name = "lblSubcategory";
            this.lblSubcategory.Size = new System.Drawing.Size(144, 17);
            this.lblSubcategory.TabIndex = 4;
            this.lblSubcategory.Text = "Choose Subcategory:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(10, 51);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(121, 17);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Choose Category:";
            // 
            // txtProductAdd
            // 
            this.txtProductAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductAdd.Location = new System.Drawing.Point(13, 198);
            this.txtProductAdd.Name = "txtProductAdd";
            this.txtProductAdd.Size = new System.Drawing.Size(160, 23);
            this.txtProductAdd.TabIndex = 2;
            // 
            // cmbSubcategoryChos
            // 
            this.cmbSubcategoryChos.DataSource = this.subCategoriesBindingSource;
            this.cmbSubcategoryChos.DisplayMember = "Name";
            this.cmbSubcategoryChos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubcategoryChos.FormattingEnabled = true;
            this.cmbSubcategoryChos.Location = new System.Drawing.Point(13, 138);
            this.cmbSubcategoryChos.Name = "cmbSubcategoryChos";
            this.cmbSubcategoryChos.Size = new System.Drawing.Size(160, 24);
            this.cmbSubcategoryChos.TabIndex = 1;
            this.cmbSubcategoryChos.ValueMember = "Id";
            // 
            // subCategoriesBindingSource
            // 
            this.subCategoriesBindingSource.DataMember = "SubCategories";
            this.subCategoriesBindingSource.DataSource = this.contactHomeDataSet;
            // 
            // contactHomeDataSet
            // 
            this.contactHomeDataSet.DataSetName = "ContactHomeDataSet";
            this.contactHomeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbCategoryChose
            // 
            this.cmbCategoryChose.DataSource = this.categoriesBindingSource;
            this.cmbCategoryChose.DisplayMember = "Name";
            this.cmbCategoryChose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoryChose.FormattingEnabled = true;
            this.cmbCategoryChose.Location = new System.Drawing.Point(13, 77);
            this.cmbCategoryChose.Name = "cmbCategoryChose";
            this.cmbCategoryChose.Size = new System.Drawing.Size(160, 24);
            this.cmbCategoryChose.TabIndex = 0;
            this.cmbCategoryChose.ValueMember = "Id";
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.contactHomeDataSet;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AutoGenerateColumns = false;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.ımageDataGridViewTextBoxColumn,
            this.subCategoryIdDataGridViewTextBoxColumn,
            this.categoryIdDataGridViewTextBoxColumn,
            this.categoryNameDataGridViewTextBoxColumn});
            this.dgvProducts.DataSource = this.productsBindingSource;
            this.dgvProducts.Location = new System.Drawing.Point(376, 27);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(558, 349);
            this.dgvProducts.TabIndex = 1;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.contactHomeDataSet;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // subCategoriesTableAdapter
            // 
            this.subCategoriesTableAdapter.ClearBeforeFill = true;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // fKProductsSubCategoriesBindingSource
            // 
            this.fKProductsSubCategoriesBindingSource.DataMember = "FK_Products_SubCategories";
            this.fKProductsSubCategoriesBindingSource.DataSource = this.subCategoriesBindingSource;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(13, 368);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(69, 24);
            this.btnBack.TabIndex = 25;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıdDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // ımageDataGridViewTextBoxColumn
            // 
            this.ımageDataGridViewTextBoxColumn.DataPropertyName = "Image";
            this.ımageDataGridViewTextBoxColumn.HeaderText = "Image";
            this.ımageDataGridViewTextBoxColumn.Name = "ımageDataGridViewTextBoxColumn";
            // 
            // subCategoryIdDataGridViewTextBoxColumn
            // 
            this.subCategoryIdDataGridViewTextBoxColumn.DataPropertyName = "SubCategoryId";
            this.subCategoryIdDataGridViewTextBoxColumn.HeaderText = "SubCategoryId";
            this.subCategoryIdDataGridViewTextBoxColumn.Name = "subCategoryIdDataGridViewTextBoxColumn";
            this.subCategoryIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // categoryIdDataGridViewTextBoxColumn
            // 
            this.categoryIdDataGridViewTextBoxColumn.DataPropertyName = "CategoryId";
            this.categoryIdDataGridViewTextBoxColumn.HeaderText = "CategoryId";
            this.categoryIdDataGridViewTextBoxColumn.Name = "categoryIdDataGridViewTextBoxColumn";
            this.categoryIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // categoryNameDataGridViewTextBoxColumn
            // 
            this.categoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName";
            this.categoryNameDataGridViewTextBoxColumn.HeaderText = "CategoryName";
            this.categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
            // 
            // All_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1263, 455);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.groupBox1);
            this.Name = "All_Products";
            this.Text = "All_Products";
            this.Load += new System.EventHandler(this.All_Products_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subCategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactHomeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKProductsSubCategoriesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblSubcategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtProductAdd;
        private System.Windows.Forms.ComboBox cmbSubcategoryChos;
        private System.Windows.Forms.ComboBox cmbCategoryChose;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnSearchProduct;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.PictureBox pictureProducts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericPrice;
        private Data.ContactHomeDataSet contactHomeDataSet;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private Data.ContactHomeDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.BindingSource subCategoriesBindingSource;
        private Data.ContactHomeDataSetTableAdapters.SubCategoriesTableAdapter subCategoriesTableAdapter;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private Data.ContactHomeDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn subCategoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSetImage;
        private System.Windows.Forms.BindingSource fKProductsSubCategoriesBindingSource;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ımageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subCategoryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
    }
}