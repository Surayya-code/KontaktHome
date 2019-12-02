using ContactHomeWindowsFormsApp.Core.Extensions;
using System;
using System.Windows.Forms;
using static ContactHomeWindowsFormsApp.Data.ContactHomeDataSet;

namespace ContactHomeWindowsFormsApp.Admin
{
    public partial class SubCategory : Form
    {
        public int Id { get; internal set; }

        public SubCategory()
        {
            InitializeComponent();
            dgvSubCategory.InitGrid();
        }

        private void SubCategory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contactHomeDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.contactHomeDataSet.Categories);
            // TODO: This line of code loads data into the 'contactHomeDataSet.SubCategories' table. You can move, or remove it, as needed.
            this.subCategoriesTableAdapter.Fill(this.contactHomeDataSet.SubCategories);
           

        }

        private void btnBackSubcateg_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnAddSbCateg_Click(object sender, EventArgs e) ////ADD SubCategory
        {
            var categoryId = Convert.ToInt32(cmbCategory.SelectedValue);
            subCategoriesTableAdapter.AddSubCategory(txtSubcategory.Text, categoryId,Program.UserId);
            this.subCategoriesTableAdapter.Fill(this.contactHomeDataSet.SubCategories);
        }

        private void btnEditSbCategory_Click(object sender, EventArgs e) //Edit Subcategory
        {
            var current = categoriesBindingSource.GetCurrentnRow<CategoriesRow>();
            subCategoriesTableAdapter.EditSubCategory(txtSubcategory.Text, current.Id);
            btnEditSbCategory.Enabled = btnDeleteSubCategory.Enabled = false;
            //this.Tag = null;
            MessageBox.Show(this.Tag?.ToString());
            this.subCategoriesTableAdapter.Fill(this.contactHomeDataSet.SubCategories);
        }

        private void btnDeleteSubCategory_Click(object sender, EventArgs e)  ///Delete SubCategory
        {

            if (MessageBox.Show("Are you sure delete row?") == DialogResult.OK)
            {
                var current =subCategoriesBindingSource.GetCurrentnRow<SubCategoriesRow>();
                subCategoriesTableAdapter.DeleteSubCategory(current.Id);

                this.subCategoriesTableAdapter.Fill(this.contactHomeDataSet.SubCategories);
            }
            else
                Application.Exit();
        }


        private void btnSearchSubCategory_Click(object sender, EventArgs e)  ///Search SubCategory
        {
            subCategoriesTableAdapter.FillBySearchSubC(this.contactHomeDataSet.SubCategories, txtSubcategory.Text);
        }

       
                                                                                  ///Double click
        private void dgvSubCategory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Tag = dgvSubCategory.Rows[e.RowIndex].Cells[0].Value?.ToString();
            txtSubcategory.Text = dgvSubCategory.Rows[e.RowIndex].Cells[1].Value?.ToString();
            cmbCategory.SelectedValue = dgvSubCategory.Rows[e.RowIndex].Cells[2].Value?.ToString();
            btnEditSbCategory.Enabled = btnDeleteSubCategory.Enabled = true;
        }

       
    }
}
