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

        private void btnAddCategory_Click(object sender, EventArgs e)  //Add Category
        {
            categoriesTableAdapter.AddCategory(txtBNameCategory.Text,Program.UserId);
            this.categoriesTableAdapter.Fill(this.contactHomeDataSet.Categories);

        }


        private void btnEdit_Click(object sender, EventArgs e)  ///Edit Category
        {
            var current = categoriesBindingSource.GetCurrentnRow<CategoriesRow>();
            categoriesTableAdapter.EditCategory(txtBNameCategory.Text, current.Id);
            btnEdit.Enabled = btnDelete.Enabled = false;
            //this.Tag = null;
            MessageBox.Show(this.Tag?.ToString());
            this.categoriesTableAdapter.Fill(this.contactHomeDataSet.Categories);

        }


        private void btnSearch_Click(object sender, EventArgs e)       //Search Category
        { 
            categoriesTableAdapter.FillBySearchCategory(this.contactHomeDataSet.Categories,txtBNameCategory.Text);
        }

       

        private void btnDelete_Click(object sender, EventArgs e)         //Delete Category
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
                                                                                    ///Double Click
        private void dataGridViewCategory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Tag = dataGridViewCategory.Rows[e.RowIndex].Cells[0].Value?.ToString();
            txtBNameCategory.Text= dataGridViewCategory.Rows[e.RowIndex].Cells[1].Value?.ToString();
            btnEdit.Enabled = btnDelete.Enabled = true;
        }
                       
        private void btnBack_Click(object sender, EventArgs e)     ///Back button
        {
            this.DialogResult = DialogResult.OK;
        }

        private void dataGridViewCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
