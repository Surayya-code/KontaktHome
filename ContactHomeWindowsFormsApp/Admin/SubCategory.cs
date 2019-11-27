using ContactHomeWindowsFormsApp.Core.Extensions;
using System;
using System.Windows.Forms;

namespace ContactHomeWindowsFormsApp.Admin
{
    public partial class SubCategory : Form
    {
        public SubCategory()
        {
            InitializeComponent();
            dataGridViewSubCategory.InitGrid();
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

        private void btnAddSbCateg_Click(object sender, EventArgs e)
        {
            var categoryId = Convert.ToInt32(cmbCategory.SelectedValue);
            subCategoriesTableAdapter.AddSubCategory(txtSubcategory.Text, categoryId,Program.UserId);
            this.subCategoriesTableAdapter.Fill(this.contactHomeDataSet.SubCategories);
        }

        private void btnEditSbCategory_Click(object sender, EventArgs e)
        {
            //todo
        }

        private void btnSearchSubCategory_Click(object sender, EventArgs e)
        {
            //todo
        }

        private void btnDeleteSubCategory_Click(object sender, EventArgs e)
        {
            //todo
        }
    }
}
