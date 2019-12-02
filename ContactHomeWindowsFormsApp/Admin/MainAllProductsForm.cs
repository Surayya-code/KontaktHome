using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactHomeWindowsFormsApp.Admin
{
    public partial class MainAllProductsForm : Form
    {
        public MainAllProductsForm()
        {
            InitializeComponent();
        }

        private void MainAllProductsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contactHomeDataSet1.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.contactHomeDataSet1.Products);
            // TODO: This line of code loads data into the 'contactHomeDataSet1.SubCategories' table. You can move, or remove it, as needed.
            this.subCategoriesTableAdapter.Fill(this.contactHomeDataSet1.SubCategories);
            // TODO: This line of code loads data into the 'contactHomeDataSet1.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.contactHomeDataSet1.Categories);
            // TODO: This line of code loads data into the 'contactHomeDataSet.AllProducts' table. You can move, or remove it, as needed.
            this.allProductsTableAdapter.Fill(this.contactHomeDataSet.AllProducts);
            // TODO: This line of code loads data into the 'contactHomeDataSet.AllProducts' table. You can move, or remove it, as needed.
            this.allProductsTableAdapter.Fill(this.contactHomeDataSet.AllProducts);

        }

        //private void btnAdd_Click(object sender, EventArgs e)
        ////{
        ////  allProductsTableAdapter.Addpro()
        //}
    } 
}
