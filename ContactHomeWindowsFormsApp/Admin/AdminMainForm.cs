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
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if ((MessageBox.Show("Close Program?", "Request", 0, MessageBoxIcon.Question)==DialogResult.OK)
            //{
            //    Admin.MainForm.Closed();
            //}
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            using (var frm =new CategoriesForm())
            {
                frm.ShowDialog();
            }
        }

         private void btnAddSubCtg_Click(object sender, EventArgs e)
        {
            using (var frm = new SubCategory())
            {
                frm.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var frm = new All_Products())
            {
                frm.ShowDialog();
            }
        }

        //private void MainForm_Load(object sender, EventArgs e)
        //{

        //}
    }
}
