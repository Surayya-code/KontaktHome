using ContactHomeWindowsFormsApp.Core.Extensions;
using ContactHomeWindowsFormsApp.Data.ContactHomeDataSetTableAdapters;
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
    public partial class All_ProductsForm : Form
    {
        public All_ProductsForm()
        {
            InitializeComponent();
            dgvProducts.InitGrid();
        }

        //private void btnSetImage_Click(object sender, EventArgs e)   ///Set image
        //{
        //    if (FileDialog.ShowDialog() == DialogResult.OK)
        //    {
        //        var image = FileDialog.FileName;
        //    }
        //}
        //private void btnAddProduct_Click(object sender, EventArgs e) /////error yes dont add
        //{
        //    var price = Convert.ToInt32(numericPrice.Value);
        //    var subcategoryId = Convert.ToInt32(cmbSubcategoryChos.SelectedValue);
        //    var buffer = Image.FromFile(FileDialog.FileName).GetBuffer();

        //    productsTableAdapter.AddProduct(txtProductAdd.Text, price, txtDescription.Text, buffer, subcategoryId);
        //    this.productsTableAdapter.Fill(this.contactHomeDataSet.Products);
        //}

        //private void All_ProductsForm_Load(object sender, EventArgs e)
        //{
        //    // TODO: This line of code loads data into the 'contactHomeDataSet.Products' table. You can move, or remove it, as needed.
        //    this.productsTableAdapter.Fill(this.contactHomeDataSet.Products);
        //    // TODO: This line of code loads data into the 'contactHomeDataSet.SubCategories' table. You can move, or remove it, as needed.
        //    this.subCategoriesTableAdapter.Fill(this.contactHomeDataSet.SubCategories);
        //    // TODO: This line of code loads data into the 'contactHomeDataSet.Categories' table. You can move, or remove it, as needed.
        //    this.categoriesTableAdapter.Fill(this.contactHomeDataSet.Categories);

        //}

        //private void btnEditProduct_Click(object sender, EventArgs e)   ////todoooo
        //{
        //    //var current = categoriesBindingSource.GetCurrentnRow<CategoriesRow>();
        //    //productsTableAdapter.EditProduct(txtProductAdd.Text,current.Id);
        //    //btnEditProduct.Enabled = btnDeleteProduct.Enabled = false;
        //    //MessageBox.Show(this.Tag?.ToString());
        //    //this.productsTableAdapter.Fill(this.contactHomeDataSet.Products);
        //}

        //private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    this.Tag = dgvProducts.Rows[e.RowIndex].Cells[0].Value?.ToString();
        //    txtProductAdd.Text = dgvProducts.Rows[e.RowIndex].Cells[1].Value?.ToString();
        //    btnEditProduct.Enabled = btnDeleteProduct.Enabled = true;
        //}

        //private void btnSearchProduct_Click(object sender, EventArgs e)
        //{
        //    //productsTableAdapter.FillBySearchProduct(contactHomeDataSet.Products, txtProductAdd.Text);
        //    //this.productsTableAdapter.Fill(this.contactHomeDataSet.Products);
        //}

        //private void btnDeleteProduct_Click(object sender, EventArgs e)
        //{
        //    //if (MessageBox.Show("Are you sure delete row?") == DialogResult.OK)
        //    //{
        //    //    var current = categoriesBindingSource.GetCurrentnRow<CategoriesRow>();
        //    //    productsTableAdapter.DeleteProduct(current.Id);
        //    //    this.productsTableAdapter.Fill(this.contactHomeDataSet.Products);
        //    //}
        //    //else
        //    //    Application.Exit();
        //}

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void All_ProductsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contactHomeDataSet1.SubCategories' table. You can move, or remove it, as needed.
            this.subCategoriesTableAdapter.Fill(this.contactHomeDataSet1.SubCategories);
            // TODO: This line of code loads data into the 'contactHomeDataSet1.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.contactHomeDataSet1.Categories);
            // TODO: This line of code loads data into the 'contactHomeDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.contactHomeDataSet.Products);
            // TODO: This line of code loads data into the 'contactHomeDataSet.VwFiles' table. You can move, or remove it, as needed.
            this.vwFilesTableAdapter.Fill(this.contactHomeDataSet.VwFiles);

        }

        private void btnSetImage_Click(object sender, EventArgs e)
        {

            if (fileDialog.ShowDialog()==DialogResult.OK)
            {
                var buff = Image.FromFile(fileDialog.FileName).GetBuffer();
                using (var adp= new CommonAdapter())
                {
                    string fileName = Path.GetFileName(fileDialog.FileName);
                    adp.spAddImage(fileName, buff, 1);  //todo add userid
                    this.productsTableAdapter.Fill(this.contactHomeDataSet.Products);
                    this.vwFilesTableAdapter.Fill(this.contactHomeDataSet.VwFiles);
                }
            }

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            var price = Convert.ToInt32(numericPrice.Value);
            productsTableAdapter.AddProducts(txtProductAdd.Text, price, txtDescription.Text);
            this.productsTableAdapter.Fill(this.contactHomeDataSet.Products);
        }






        //private void All_ProductsForm_Load(object sender, EventArgs e)
        //{   
        //    this.productsTableAdapter.Fill(this.contactHomeDataSet.Products);
        //}

        //private void All_Products_Load(object sender, EventArgs e)
        //{


        //}

        //private void btnAddProduct_Click(object sender, EventArgs e)  //Add Product
        //{

        ////   var price = Convert.ToInt32(numericPrice.Value);
        ////    var subcategoryId = Convert.ToInt32(cmbSubcategoryChos.SelectedValue);
        ////    var categoryId = Convert.ToInt32(cmbCategoryChose.SelectedValue);

        ////    var buffer = Image.FromFile(openFileDialog1.FileName).GetBuffer();
        ////    productsTableAdapter.AddProduct(txtProductAdd.Text, price, txtDescription.Text, buffer, subcategoryId);
        ////    this.productsTableAdapter.Fill(this.contactHomeDataSet.Products);
        //}

        //private void btnEditProduct_Click(object sender, EventArgs e) /// Edit Product
        //{
        ////    var current = categoriesBindingSource.GetCurrentnRow<CategoriesRow>();
        ////    productsTableAdapter.EditProduct(txtProductAdd.Text, current.Id);
        ////    btnEditProduct.Enabled = btnDeleteProduct.Enabled = false;
        ////    //this.Tag = null;
        ////    MessageBox.Show(this.Tag?.ToString());
        ////    this.productsTableAdapter.Fill(this.contactHomeDataSet.Products);

        //}

        //private void btnSearchProduct_Click(object sender, EventArgs e)
        //{
        ////    productsTableAdapter.FillBySearchProduct(this.contactHomeDataSet.Products,txtProductAdd.Text);
        //}

        //private void btnDeleteProduct_Click(object sender, EventArgs e)   //Delete Products
        //{
        //    //if (MessageBox.Show("Are you sure delete row?") == DialogResult.OK)
        //    //{
        //    //    var current = productsBindingSource.GetCurrentnRow<ProductsRow>();
        //    //    productsTableAdapter.DeleteProduct(current.Id);

        //    //    this.productsTableAdapter.Fill(this.contactHomeDataSet.Products);
        //    //}
        //    //else
        //    //    Application.Exit();
        //}

        //private void btnSetImage_Click(object sender, EventArgs e)   ///Set image
        //{
        //    //if (openFileDialog1.ShowDialog() == DialogResult.OK)
        //    //{
        //    //    var image = openFileDialog1.FileName;
        //    //}
        //}

        //private void btnBack_Click(object sender, EventArgs e)  /// Back
        //{
        ////    this.DialogResult = DialogResult.OK;
        //}

        //private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        ////    this.Tag = dgvProducts.Rows[e.RowIndex].Cells[0].Value?.ToString();
        ////    txtProductAdd.Text = dgvProducts.Rows[e.RowIndex].Cells[1].Value?.ToString();
        ////    btnEditProduct.Enabled = btnDeleteProduct.Enabled = true;
        //}

        //private void btnAddProduct_Click_1(object sender, EventArgs e)
        //{

        //}

    }
}
