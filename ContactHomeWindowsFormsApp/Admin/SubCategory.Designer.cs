namespace ContactHomeWindowsFormsApp.Admin
{
    partial class SubCategory
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
            this.grpAddSubCategory = new System.Windows.Forms.GroupBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtSubcategory = new System.Windows.Forms.TextBox();
            this.btnDeleteSubCategory = new System.Windows.Forms.Button();
            this.btnSearchSubCategory = new System.Windows.Forms.Button();
            this.btnEditSbCategory = new System.Windows.Forms.Button();
            this.btnAddSbCateg = new System.Windows.Forms.Button();
            this.dataGridViewSubCategory = new System.Windows.Forms.DataGridView();
            this.btnBackSubcateg = new System.Windows.Forms.Button();
            this.contactHomeDataSet = new ContactHomeWindowsFormsApp.Data.ContactHomeDataSet();
            this.subCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subCategoriesTableAdapter = new ContactHomeWindowsFormsApp.Data.ContactHomeDataSetTableAdapters.SubCategoriesTableAdapter();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createUserIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesTableAdapter = new ContactHomeWindowsFormsApp.Data.ContactHomeDataSetTableAdapters.CategoriesTableAdapter();
            this.grpAddSubCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactHomeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subCategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grpAddSubCategory
            // 
            this.grpAddSubCategory.Controls.Add(this.cmbCategory);
            this.grpAddSubCategory.Controls.Add(this.txtSubcategory);
            this.grpAddSubCategory.Controls.Add(this.btnDeleteSubCategory);
            this.grpAddSubCategory.Controls.Add(this.btnSearchSubCategory);
            this.grpAddSubCategory.Controls.Add(this.btnEditSbCategory);
            this.grpAddSubCategory.Controls.Add(this.btnAddSbCateg);
            this.grpAddSubCategory.Location = new System.Drawing.Point(66, 30);
            this.grpAddSubCategory.Name = "grpAddSubCategory";
            this.grpAddSubCategory.Size = new System.Drawing.Size(656, 59);
            this.grpAddSubCategory.TabIndex = 1;
            this.grpAddSubCategory.TabStop = false;
            this.grpAddSubCategory.Text = "Add SubCategory";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DataSource = this.categoriesBindingSource;
            this.cmbCategory.DisplayMember = "Name";
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(17, 21);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(121, 21);
            this.cmbCategory.TabIndex = 6;
            this.cmbCategory.ValueMember = "Id";
            // 
            // txtSubcategory
            // 
            this.txtSubcategory.Location = new System.Drawing.Point(167, 22);
            this.txtSubcategory.Name = "txtSubcategory";
            this.txtSubcategory.Size = new System.Drawing.Size(119, 20);
            this.txtSubcategory.TabIndex = 5;
            // 
            // btnDeleteSubCategory
            // 
            this.btnDeleteSubCategory.Location = new System.Drawing.Point(572, 19);
            this.btnDeleteSubCategory.Name = "btnDeleteSubCategory";
            this.btnDeleteSubCategory.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteSubCategory.TabIndex = 4;
            this.btnDeleteSubCategory.Text = "Delete";
            this.btnDeleteSubCategory.UseVisualStyleBackColor = true;
            this.btnDeleteSubCategory.Click += new System.EventHandler(this.btnDeleteSubCategory_Click);
            // 
            // btnSearchSubCategory
            // 
            this.btnSearchSubCategory.Location = new System.Drawing.Point(491, 19);
            this.btnSearchSubCategory.Name = "btnSearchSubCategory";
            this.btnSearchSubCategory.Size = new System.Drawing.Size(75, 23);
            this.btnSearchSubCategory.TabIndex = 3;
            this.btnSearchSubCategory.Text = "Search";
            this.btnSearchSubCategory.UseVisualStyleBackColor = true;
            this.btnSearchSubCategory.Click += new System.EventHandler(this.btnSearchSubCategory_Click);
            // 
            // btnEditSbCategory
            // 
            this.btnEditSbCategory.Location = new System.Drawing.Point(408, 18);
            this.btnEditSbCategory.Name = "btnEditSbCategory";
            this.btnEditSbCategory.Size = new System.Drawing.Size(75, 23);
            this.btnEditSbCategory.TabIndex = 2;
            this.btnEditSbCategory.Text = "Edit";
            this.btnEditSbCategory.UseVisualStyleBackColor = true;
            this.btnEditSbCategory.Click += new System.EventHandler(this.btnEditSbCategory_Click);
            // 
            // btnAddSbCateg
            // 
            this.btnAddSbCateg.Location = new System.Drawing.Point(325, 18);
            this.btnAddSbCateg.Name = "btnAddSbCateg";
            this.btnAddSbCateg.Size = new System.Drawing.Size(75, 23);
            this.btnAddSbCateg.TabIndex = 1;
            this.btnAddSbCateg.Text = "Add";
            this.btnAddSbCateg.UseVisualStyleBackColor = true;
            this.btnAddSbCateg.Click += new System.EventHandler(this.btnAddSbCateg_Click);
            // 
            // dataGridViewSubCategory
            // 
            this.dataGridViewSubCategory.AutoGenerateColumns = false;
            this.dataGridViewSubCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.categoryIdDataGridViewTextBoxColumn,
            this.createUserIdDataGridViewTextBoxColumn,
            this.createDateDataGridViewTextBoxColumn,
            this.categoryNameDataGridViewTextBoxColumn});
            this.dataGridViewSubCategory.DataSource = this.subCategoriesBindingSource;
            this.dataGridViewSubCategory.Location = new System.Drawing.Point(66, 95);
            this.dataGridViewSubCategory.Name = "dataGridViewSubCategory";
            this.dataGridViewSubCategory.Size = new System.Drawing.Size(656, 192);
            this.dataGridViewSubCategory.TabIndex = 2;
            // 
            // btnBackSubcateg
            // 
            this.btnBackSubcateg.Location = new System.Drawing.Point(72, 377);
            this.btnBackSubcateg.Name = "btnBackSubcateg";
            this.btnBackSubcateg.Size = new System.Drawing.Size(75, 23);
            this.btnBackSubcateg.TabIndex = 3;
            this.btnBackSubcateg.Text = "Geri";
            this.btnBackSubcateg.UseVisualStyleBackColor = true;
            this.btnBackSubcateg.Click += new System.EventHandler(this.btnBackSubcateg_Click);
            // 
            // contactHomeDataSet
            // 
            this.contactHomeDataSet.DataSetName = "ContactHomeDataSet";
            this.contactHomeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subCategoriesBindingSource
            // 
            this.subCategoriesBindingSource.DataMember = "SubCategories";
            this.subCategoriesBindingSource.DataSource = this.contactHomeDataSet;
            // 
            // subCategoriesTableAdapter
            // 
            this.subCategoriesTableAdapter.ClearBeforeFill = true;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // categoryIdDataGridViewTextBoxColumn
            // 
            this.categoryIdDataGridViewTextBoxColumn.DataPropertyName = "CategoryId";
            this.categoryIdDataGridViewTextBoxColumn.HeaderText = "CategoryId";
            this.categoryIdDataGridViewTextBoxColumn.Name = "categoryIdDataGridViewTextBoxColumn";
            // 
            // createUserIdDataGridViewTextBoxColumn
            // 
            this.createUserIdDataGridViewTextBoxColumn.DataPropertyName = "CreateUserId";
            this.createUserIdDataGridViewTextBoxColumn.HeaderText = "CreateUserId";
            this.createUserIdDataGridViewTextBoxColumn.Name = "createUserIdDataGridViewTextBoxColumn";
            // 
            // createDateDataGridViewTextBoxColumn
            // 
            this.createDateDataGridViewTextBoxColumn.DataPropertyName = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.HeaderText = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.Name = "createDateDataGridViewTextBoxColumn";
            // 
            // categoryNameDataGridViewTextBoxColumn
            // 
            this.categoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName";
            this.categoryNameDataGridViewTextBoxColumn.HeaderText = "CategoryName";
            this.categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.contactHomeDataSet;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // SubCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBackSubcateg);
            this.Controls.Add(this.dataGridViewSubCategory);
            this.Controls.Add(this.grpAddSubCategory);
            this.Name = "SubCategory";
            this.Text = "SubCategory";
            this.Load += new System.EventHandler(this.SubCategory_Load);
            this.grpAddSubCategory.ResumeLayout(false);
            this.grpAddSubCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactHomeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subCategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpAddSubCategory;
        private System.Windows.Forms.Button btnDeleteSubCategory;
        private System.Windows.Forms.Button btnSearchSubCategory;
        private System.Windows.Forms.Button btnEditSbCategory;
        private System.Windows.Forms.Button btnAddSbCateg;
        private System.Windows.Forms.DataGridView dataGridViewSubCategory;
        private System.Windows.Forms.TextBox txtSubcategory;
        private System.Windows.Forms.Button btnBackSubcateg;
        private System.Windows.Forms.ComboBox cmbCategory;
        private Data.ContactHomeDataSet contactHomeDataSet;
        private System.Windows.Forms.BindingSource subCategoriesBindingSource;
        private Data.ContactHomeDataSetTableAdapters.SubCategoriesTableAdapter subCategoriesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createUserIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private Data.ContactHomeDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
    }
}