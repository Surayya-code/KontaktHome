using ContactHomeWindowsFormsApp.Core.Extensions;
using System;
using System.Data;
using System.Windows.Forms;
using static ContactHomeWindowsFormsApp.Data.ContactHomeDataSet;

namespace ContactHomeWindowsFormsApp.Admin
{
    public partial class CategoriesForm : Form
    {
        public CategoriesForm()
        {
            InitializeComponent();
            dataGridViewCategory.InitGrid();


        }

        private void Categories_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contactHomeDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.contactHomeDataSet.Categories);

        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            
            categoriesTableAdapter.AddCategory(txtBNameCategory.Text,Program.UserId);
            this.categoriesTableAdapter.Fill(this.contactHomeDataSet.Categories);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            categoriesTableAdapter.FillBySearchCategory(this.contactHomeDataSet.Categories,txtBNameCategory.Text);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var current = categoriesBindingSource.GetCurrentnRow<CategoriesRow>();
            categoriesTableAdapter.EditCategory(txtBNameCategory.Text, current.Id);
             btnEdit.Enabled = btnDelete.Enabled = false;
            this.Tag = null;
            this.categoriesTableAdapter.Fill(this.contactHomeDataSet.Categories);


            MessageBox.Show(this.Tag?.ToString());

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure delete row?")==DialogResult.OK)
            {
                var current = categoriesBindingSource.GetCurrentnRow<CategoriesRow>();
                categoriesTableAdapter.DeleteCategory(current.Id);

                this.categoriesTableAdapter.Fill(this.contactHomeDataSet.Categories);
            }
            else
                Application.Exit();


        }

        private void dataGridViewCategory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Tag = dataGridViewCategory.Rows[e.RowIndex].Cells[0].Value?.ToString();
            txtBNameCategory.Text= dataGridViewCategory.Rows[e.RowIndex].Cells[1].Value?.ToString();
            btnEdit.Enabled = btnDelete.Enabled = true;
        }
    }
}
