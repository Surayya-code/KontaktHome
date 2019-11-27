using ContactHomeWindowsFormsApp.Core.Controls;
using ContactHomeWindowsFormsApp.Core.Extensions;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ContactHomeWindowsFormsApp.User
{
    public partial class HomePageForm : Form
    {
        public HomePageForm()
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

        private void HomePageForm_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void usbToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tabProduct_Click(object sender, EventArgs e)
        {

        }

        private void smartwatchToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void telefonlarVəSaatlarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
