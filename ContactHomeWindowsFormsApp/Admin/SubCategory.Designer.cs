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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubCategory));
            this.grpAddSubCategory = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactHomeDataSet = new ContactHomeWindowsFormsApp.Data.ContactHomeDataSet();
            this.txtSubcategory = new System.Windows.Forms.TextBox();
            this.btnDeleteSubCategory = new System.Windows.Forms.Button();
            this.btnSearchSubCategory = new System.Windows.Forms.Button();
            this.btnEditSbCategory = new System.Windows.Forms.Button();
            this.btnAddSbCateg = new System.Windows.Forms.Button();
            this.dgvSubCategory = new System.Windows.Forms.DataGridView();
            this.subCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBackSubcateg = new System.Windows.Forms.Button();
            this.subCategoriesTableAdapter = new ContactHomeWindowsFormsApp.Data.ContactHomeDataSetTableAdapters.SubCategoriesTableAdapter();
            this.categoriesTableAdapter = new ContactHomeWindowsFormsApp.Data.ContactHomeDataSetTableAdapters.CategoriesTableAdapter();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createUserIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpAddSubCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactHomeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subCategoriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grpAddSubCategory
            // 
            this.grpAddSubCategory.BackColor = System.Drawing.Color.Transparent;
            this.grpAddSubCategory.Controls.Add(this.label2);
            this.grpAddSubCategory.Controls.Add(this.label1);
            this.grpAddSubCategory.Controls.Add(this.cmbCategory);
            this.grpAddSubCategory.Controls.Add(this.txtSubcategory);
            this.grpAddSubCategory.Controls.Add(this.btnDeleteSubCategory);
            this.grpAddSubCategory.Controls.Add(this.btnSearchSubCategory);
            this.grpAddSubCategory.Controls.Add(this.btnEditSbCategory);
            this.grpAddSubCategory.Controls.Add(this.btnAddSbCateg);
            this.grpAddSubCategory.Location = new System.Drawing.Point(65, 67);
            this.grpAddSubCategory.Name = "grpAddSubCategory";
            this.grpAddSubCategory.Size = new System.Drawing.Size(777, 77);
            this.grpAddSubCategory.TabIndex = 1;
            this.grpAddSubCategory.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(17, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Choose Category:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(208, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Subcategory:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DataSource = this.categoriesBindingSource;
            this.cmbCategory.DisplayMember = "Name";
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(21, 32);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(155, 24);
            this.cmbCategory.TabIndex = 6;
            this.cmbCategory.ValueMember = "Id";
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.contactHomeDataSet;
            // 
            // contactHomeDataSet
            // 
            this.contactHomeDataSet.DataSetName = "ContactHomeDataSet";
            this.contactHomeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtSubcategory
            // 
            this.txtSubcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubcategory.Location = new System.Drawing.Point(198, 34);
            this.txtSubcategory.Name = "txtSubcategory";
            this.txtSubcategory.Size = new System.Drawing.Size(135, 23);
            this.txtSubcategory.TabIndex = 5;
            // 
            // btnDeleteSubCategory
            // 
            this.btnDeleteSubCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSubCategory.Location = new System.Drawing.Point(664, 28);
            this.btnDeleteSubCategory.Name = "btnDeleteSubCategory";
            this.btnDeleteSubCategory.Size = new System.Drawing.Size(95, 34);
            this.btnDeleteSubCategory.TabIndex = 4;
            this.btnDeleteSubCategory.Text = "Delete";
            this.btnDeleteSubCategory.UseVisualStyleBackColor = true;
            this.btnDeleteSubCategory.Click += new System.EventHandler(this.btnDeleteSubCategory_Click);
            // 
            // btnSearchSubCategory
            // 
            this.btnSearchSubCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchSubCategory.Location = new System.Drawing.Point(556, 28);
            this.btnSearchSubCategory.Name = "btnSearchSubCategory";
            this.btnSearchSubCategory.Size = new System.Drawing.Size(95, 34);
            this.btnSearchSubCategory.TabIndex = 3;
            this.btnSearchSubCategory.Text = "Search";
            this.btnSearchSubCategory.UseVisualStyleBackColor = true;
            this.btnSearchSubCategory.Click += new System.EventHandler(this.btnSearchSubCategory_Click);
            // 
            // btnEditSbCategory
            // 
            this.btnEditSbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSbCategory.Location = new System.Drawing.Point(455, 29);
            this.btnEditSbCategory.Name = "btnEditSbCategory";
            this.btnEditSbCategory.Size = new System.Drawing.Size(95, 34);
            this.btnEditSbCategory.TabIndex = 2;
            this.btnEditSbCategory.Text = "Edit";
            this.btnEditSbCategory.UseVisualStyleBackColor = true;
            this.btnEditSbCategory.Click += new System.EventHandler(this.btnEditSbCategory_Click);
            // 
            // btnAddSbCateg
            // 
            this.btnAddSbCateg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSbCateg.Location = new System.Drawing.Point(352, 28);
            this.btnAddSbCateg.Name = "btnAddSbCateg";
            this.btnAddSbCateg.Size = new System.Drawing.Size(95, 34);
            this.btnAddSbCateg.TabIndex = 1;
            this.btnAddSbCateg.Text = "Add";
            this.btnAddSbCateg.UseVisualStyleBackColor = true;
            this.btnAddSbCateg.Click += new System.EventHandler(this.btnAddSbCateg_Click);
            // 
            // dgvSubCategory
            // 
            this.dgvSubCategory.AutoGenerateColumns = false;
            this.dgvSubCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.categoryIdDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.createUserIdDataGridViewTextBoxColumn,
            this.userDataGridViewTextBoxColumn,
            this.createDateDataGridViewTextBoxColumn,
            this.deleteDateDataGridViewTextBoxColumn});
            this.dgvSubCategory.DataSource = this.subCategoriesBindingSource;
            this.dgvSubCategory.Location = new System.Drawing.Point(30, 166);
            this.dgvSubCategory.Name = "dgvSubCategory";
            this.dgvSubCategory.Size = new System.Drawing.Size(843, 192);
            this.dgvSubCategory.TabIndex = 2;
            this.dgvSubCategory.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubCategory_CellDoubleClick);
            // 
            // subCategoriesBindingSource
            // 
            this.subCategoriesBindingSource.DataMember = "SubCategories";
            this.subCategoriesBindingSource.DataSource = this.contactHomeDataSet;
            // 
            // btnBackSubcateg
            // 
            this.btnBackSubcateg.BackColor = System.Drawing.Color.Indigo;
            this.btnBackSubcateg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBackSubcateg.BackgroundImage")));
            this.btnBackSubcateg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBackSubcateg.Location = new System.Drawing.Point(30, 380);
            this.btnBackSubcateg.Name = "btnBackSubcateg";
            this.btnBackSubcateg.Size = new System.Drawing.Size(64, 33);
            this.btnBackSubcateg.TabIndex = 3;
            this.btnBackSubcateg.UseVisualStyleBackColor = false;
            this.btnBackSubcateg.Click += new System.EventHandler(this.btnBackSubcateg_Click);
            // 
            // subCategoriesTableAdapter
            // 
            this.subCategoriesTableAdapter.ClearBeforeFill = true;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
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
            // categoryIdDataGridViewTextBoxColumn
            // 
            this.categoryIdDataGridViewTextBoxColumn.DataPropertyName = "CategoryId";
            this.categoryIdDataGridViewTextBoxColumn.HeaderText = "CategoryId";
            this.categoryIdDataGridViewTextBoxColumn.Name = "categoryIdDataGridViewTextBoxColumn";
            this.categoryIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // createUserIdDataGridViewTextBoxColumn
            // 
            this.createUserIdDataGridViewTextBoxColumn.DataPropertyName = "CreateUserId";
            this.createUserIdDataGridViewTextBoxColumn.HeaderText = "CreateUserId";
            this.createUserIdDataGridViewTextBoxColumn.Name = "createUserIdDataGridViewTextBoxColumn";
            this.createUserIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // userDataGridViewTextBoxColumn
            // 
            this.userDataGridViewTextBoxColumn.DataPropertyName = "User";
            this.userDataGridViewTextBoxColumn.HeaderText = "User";
            this.userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
            this.userDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createDateDataGridViewTextBoxColumn
            // 
            this.createDateDataGridViewTextBoxColumn.DataPropertyName = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.HeaderText = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.Name = "createDateDataGridViewTextBoxColumn";
            // 
            // deleteDateDataGridViewTextBoxColumn
            // 
            this.deleteDateDataGridViewTextBoxColumn.DataPropertyName = "DeleteDate";
            this.deleteDateDataGridViewTextBoxColumn.HeaderText = "DeleteDate";
            this.deleteDateDataGridViewTextBoxColumn.Name = "deleteDateDataGridViewTextBoxColumn";
            // 
            // SubCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(903, 450);
            this.Controls.Add(this.btnBackSubcateg);
            this.Controls.Add(this.dgvSubCategory);
            this.Controls.Add(this.grpAddSubCategory);
            this.Name = "SubCategory";
            this.Text = "SubCategory";
            this.Load += new System.EventHandler(this.SubCategory_Load);
            this.grpAddSubCategory.ResumeLayout(false);
            this.grpAddSubCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactHomeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subCategoriesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpAddSubCategory;
        private System.Windows.Forms.Button btnDeleteSubCategory;
        private System.Windows.Forms.Button btnSearchSubCategory;
        private System.Windows.Forms.Button btnEditSbCategory;
        private System.Windows.Forms.Button btnAddSbCateg;
        private System.Windows.Forms.DataGridView dgvSubCategory;
        private System.Windows.Forms.TextBox txtSubcategory;
        private System.Windows.Forms.Button btnBackSubcateg;
        private System.Windows.Forms.ComboBox cmbCategory;
        private Data.ContactHomeDataSet contactHomeDataSet;
        private Data.ContactHomeDataSetTableAdapters.SubCategoriesTableAdapter subCategoriesTableAdapter;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private Data.ContactHomeDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource subCategoriesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createUserIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deleteDateDataGridViewTextBoxColumn;
    }
}