using ContactHomeWindowsFormsApp.Admin;
using ContactHomeWindowsFormsApp.Core.Controls;
using ContactHomeWindowsFormsApp.Core.Extensions;
using ContactHomeWindowsFormsApp.Data.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ContactHomeWindowsFormsApp.User
{
    public partial class UserMainForm : Form
    {
        public UserMainForm()
        {
            InitializeComponent();

            btnSearchh.RoundControl(btnSearchh.Width, btnSearchh.Height, 10, 10);
            btnDelete.RoundControl(btnDelete.Width, btnDelete.Height, 10, 10);


            //        for (int i = 0; i<20; i++)
            //{
            //             Random rnd = new Random();

            //             //biz sekilleri dbo-dan cekib gotureceyik
            //             Image img = Image.FromFile(@"C:\Users\suray\Desktop\ContactHomeWinProject\Mi Band 4");

            //             Product product = new Product();
            //             product.Id = i + 1;
            //             product.NameProduct = $"Product-{i + 1}";
            //             product.Price =(decimal)rnd.NextDouble()*1000M;

            //             product.Picture = img;

            //             product.Click += product1_Click;
            //             flowLayoutPanel1.Controls.Add(product);

            //         }
        }


        private void product1_Click(object sender, System.EventArgs e)
        {
            Product product = sender as Product;
            MessageBox.Show($"{product.Id}/{product.NameProduct}/{product.Price}");
        }

        private void lblWriteUs_Click(object sender, EventArgs e)
        {
            using (var frm = new WriteUsForm())
            {
                frm.ShowDialog();
            }
        }



        private void btnSearchh_Click(object sender, EventArgs e)
        {

        }

        private void product9_Load(object sender, EventArgs e)
        {
        }

        private void HomePageForm_Load(object sender, EventArgs e)
        {

        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            categoriesTableAdapter1.Fill(dataSet.Categories);
           

            //checkedListCategories.Items.Clear();
            foreach (var item in dataSet.Categories)
            {
                var category = new Category();
                category.Id = item.Id;
                category.Name = item.Name;
                checkedListCategories.Items.Add(category);
            }

            subCategoriesTableAdapter1.Fill(dataSet.SubCategories);
            foreach (var item in dataSet.SubCategories)
            {
                var subcategory = new SubCategory();
                subcategory.Id = item.Id;
                subcategory.Name = item.Name;
                checkedListSubCategories.Items.Add(subcategory);
            }
        }
    }
}
