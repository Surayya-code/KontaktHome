using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactHomeWindowsFormsApp.Core.Controls
{
    public partial class Product : UserControl
    {
        public Product()
        {
            InitializeComponent();
        }

       public string NameProduct
        { get 
            {
                return label1.Text;
            }
            set
            {
                label1.Text = value;
            }
        }
        decimal price;

        public int Id { get; set; }

        public decimal Price { 
            set 
            {
                price = value;
                lblPrice.Text = $"{value:0.00}₼";
            }
            get
            { 
                return price;
            }
        }
        public Image Picture { get 
            {
                return picture.Image;
            } set
            {
                picture.Image = value;
            }
        }

        new public event EventHandler Click;

        private void btnSifaris_Click(object sender, EventArgs e)
        {
            if (Click!=null)
            {
                Click.Invoke(this,e);
            }
        }

        private void Product_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#1289A7");
        }

        private void Product_MouseLeave(object sender, EventArgs e)
        {

            this.BackColor = ColorTranslator.FromHtml("buttonface");
        }
    }
}
