using ContactHomeWindowsFormsApp.Core.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ContactHomeWindowsFormsApp.Data.ContactHomeDataSet;

namespace ContactHomeWindowsFormsApp.Admin
{
    public partial class All_Products : Form
    {
        public All_Products()
        {
            InitializeComponent();
        }

        private void All_Products_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contactHomeDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.contactHomeDataSet.Products);
            // TODO: This line of code loads data into the 'contactHomeDataSet.SubCategories' table. You can move, or remove it, as needed.
            this.subCategoriesTableAdapter.Fill(this.contactHomeDataSet.SubCategories);   /////WHY ERROR????
            // TODO: This line of code loads data into the 'contactHomeDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.contactHomeDataSet.Categories);

        }

        private void btnAddProduct_Click(object sender, EventArgs e)  //Add Category
        {
           var price = Convert.ToInt32(numericPrice.Value);
            var subcategoryId = Convert.ToInt32(cmbSubcategoryChos.SelectedValue);
            var categoryId = Convert.ToInt32(cmbCategoryChose.SelectedValue);
            
            var buffer = Image.FromFile(openFileDialog1.FileName).GetBuffer();
            productsTableAdapter.AddProduct(txtProductAdd.Text, price, txtDescription.Text, buffer, subcategoryId);
            this.productsTableAdapter.Fill(this.contactHomeDataSet.Products);
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            //todo
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            //todo
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)   //Delete Category
        {
            if (MessageBox.Show("Are you sure delete row?") == DialogResult.OK)
            {
                var current = productsBindingSource.GetCurrentnRow<ProductsRow>();
                productsTableAdapter.DeleteProduct(current.Id);

                this.productsTableAdapter.Fill(this.contactHomeDataSet.Products);
            }
            else
                Application.Exit();
        }

        private void btnSetImage_Click(object sender, EventArgs e)   ///Set image
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var image = openFileDialog1.FileName;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)  /// Back
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
