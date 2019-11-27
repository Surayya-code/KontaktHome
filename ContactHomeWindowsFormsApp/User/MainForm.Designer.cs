namespace ContactHomeWindowsFormsApp.User
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnAdd = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSelected = new System.Windows.Forms.Button();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnSetAs = new System.Windows.Forms.Button();
            this.btnSeveAs = new System.Windows.Forms.Button();
            this.btnImageToBufer = new System.Windows.Forms.Button();
            this.vwFilesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwFilesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet = new ContactHomeWindowsFormsApp.Data.ContactHomeDataSet();
            this.categoriesTableAdapter1 = new ContactHomeWindowsFormsApp.Data.ContactHomeDataSetTableAdapters.CategoriesTableAdapter();
            this.vwFilesTableAdapter = new ContactHomeWindowsFormsApp.Data.ContactHomeDataSetTableAdapters.VwFilesTableAdapter();
            this.tableAdapterManager = new ContactHomeWindowsFormsApp.Data.ContactHomeDataSetTableAdapters.TableAdapterManager();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwFilesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwFilesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(823, 285);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 38);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(823, 26);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(246, 79);
            this.checkedListBox1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(820, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnSelected
            // 
            this.btnSelected.Location = new System.Drawing.Point(948, 285);
            this.btnSelected.Name = "btnSelected";
            this.btnSelected.Size = new System.Drawing.Size(81, 38);
            this.btnSelected.TabIndex = 3;
            this.btnSelected.Text = "Add Basket";
            this.btnSelected.UseVisualStyleBackColor = true;
            this.btnSelected.Click += new System.EventHandler(this.btnSelected_Click);
            // 
            // FileDialog
            // 
            this.FileDialog.FileName = "openFileDialog1";
            // 
            // btnSetAs
            // 
            this.btnSetAs.Location = new System.Drawing.Point(823, 349);
            this.btnSetAs.Name = "btnSetAs";
            this.btnSetAs.Size = new System.Drawing.Size(85, 36);
            this.btnSetAs.TabIndex = 5;
            this.btnSetAs.Text = "Set As";
            this.btnSetAs.UseVisualStyleBackColor = true;
            this.btnSetAs.Click += new System.EventHandler(this.btnSetas_Click);
            // 
            // btnSeveAs
            // 
            this.btnSeveAs.Location = new System.Drawing.Point(914, 349);
            this.btnSeveAs.Name = "btnSeveAs";
            this.btnSeveAs.Size = new System.Drawing.Size(85, 36);
            this.btnSeveAs.TabIndex = 6;
            this.btnSeveAs.Text = "Set As";
            this.btnSeveAs.UseVisualStyleBackColor = true;
            this.btnSeveAs.Click += new System.EventHandler(this.btnSeveAs_Click);
            // 
            // btnImageToBufer
            // 
            this.btnImageToBufer.Location = new System.Drawing.Point(1005, 349);
            this.btnImageToBufer.Name = "btnImageToBufer";
            this.btnImageToBufer.Size = new System.Drawing.Size(85, 37);
            this.btnImageToBufer.TabIndex = 7;
            this.btnImageToBufer.Text = "ImageToBufer";
            this.btnImageToBufer.UseVisualStyleBackColor = true;
            this.btnImageToBufer.Click += new System.EventHandler(this.btnImageToBufer_Click);
            // 
            // vwFilesDataGridView
            // 
            this.vwFilesDataGridView.AutoGenerateColumns = false;
            this.vwFilesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vwFilesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.vwFilesDataGridView.DataSource = this.vwFilesBindingSource;
            this.vwFilesDataGridView.Location = new System.Drawing.Point(820, 401);
            this.vwFilesDataGridView.Name = "vwFilesDataGridView";
            this.vwFilesDataGridView.Size = new System.Drawing.Size(247, 51);
            this.vwFilesDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // vwFilesBindingSource
            // 
            this.vwFilesBindingSource.DataMember = "VwFiles";
            this.vwFilesBindingSource.DataSource = this.DataSet;
            // 
            // DataSet
            // 
            this.DataSet.DataSetName = "ContactHomeDataSet";
            this.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriesTableAdapter1
            // 
            this.categoriesTableAdapter1.ClearBeforeFill = true;
            // 
            // vwFilesTableAdapter
            // 
            this.vwFilesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = this.categoriesTableAdapter1;
            this.tableAdapterManager.UpdateOrder = ContactHomeWindowsFormsApp.Data.ContactHomeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(159, 329);
            this.listBox1.TabIndex = 9;
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.DataSet;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(380, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Home Form";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 523);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.vwFilesDataGridView);
            this.Controls.Add(this.btnImageToBufer);
            this.Controls.Add(this.btnSeveAs);
            this.Controls.Add(this.btnSetAs);
            this.Controls.Add(this.btnSelected);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwFilesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwFilesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private Data.ContactHomeDataSet DataSet;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Data.ContactHomeDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter1;
        private System.Windows.Forms.Button btnSelected;
        private System.Windows.Forms.OpenFileDialog FileDialog;
        private System.Windows.Forms.Button btnSetAs;
        private System.Windows.Forms.Button btnSeveAs;
        private System.Windows.Forms.Button btnImageToBufer;
        private System.Windows.Forms.BindingSource vwFilesBindingSource;
        private Data.ContactHomeDataSetTableAdapters.VwFilesTableAdapter vwFilesTableAdapter;
        private Data.ContactHomeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView vwFilesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
    }
}