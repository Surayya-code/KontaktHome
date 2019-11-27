using ContactHomeWindowsFormsApp.Core.Extensions;
using ContactHomeWindowsFormsApp.Data.Model;
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

namespace ContactHomeWindowsFormsApp.User
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            categoriesTableAdapter1.Fill(DataSet.Categories);

            checkedListBox1.Items.Clear();
            foreach (var item in DataSet.Categories)
            {
                var category = new Category();
                category.Id = item.Id;
                category.Name = item.Name;
                checkedListBox1.Items.Add(category);
            }
        }


        private void btnSelected_Click(object sender, EventArgs e)
        {
            StringBuilder builder= new StringBuilder();

            foreach (Category category in checkedListBox1.CheckedItems)
            {
                
                builder.Append($",{category.Id}");//////id niye qebul elemirsen a bala? men ki sene id teyin etmisim//
            }
            MessageBox.Show(builder.ToString().Substring(1));
        }

        private void btnSetas_Click(object sender, EventArgs e)
        {
            if (FileDialog.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.ImageLocation = FileDialog.FileName;
            }
            else
            pictureBox1.Image=null;
        }

        private void btnSeveAs_Click(object sender, EventArgs e)
        {
            if (FileDialog.ShowDialog() == DialogResult.OK)
            {
                Image image =Image.FromFile(FileDialog.FileName);
                pictureBox1.Image = image;
            }
            else
            pictureBox1.Image = null;
        }

        //private void btnImageToBufer_Click(object sender, EventArgs e)
        //{
        //    if (FileDialog.ShowDialog() == DialogResult.OK)
        //    {
        //        //Db gondermek ucun byte seklinde gormeliyik faylimizi,ona gore de:
        //        using (var stream = new MemoryStream())
        //        {
        //            Image image = Image.FromFile(FileDialog.FileName);
        //            image.Save(stream, image.RawFormat);
        //            var buffer = stream.GetBuffer();
                    
        //        }
        //    }

        
        private void btnImageToBufer_Click(object sender, EventArgs e)
        {
            if (FileDialog.ShowDialog() == DialogResult.OK)
            {
                var buff = Image.FromFile(FileDialog.FileName).GetBuffer();
                            
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet.VwFiles' table. You can move, or remove it, as needed.
            //this.vwFilesTableAdapter.Fill(this.DataSet.VwFiles);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var frm=new HomePageForm())
            {
                frm.ShowDialog();
            }
        }
    }
}
