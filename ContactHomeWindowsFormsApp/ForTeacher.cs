using ContactHomeWindowsFormsApp.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactHomeWindowsFormsApp
{
    public partial class ForTeacher : Form
    {
        public ForTeacher()
        {
            InitializeComponent();
        }

        private void btnClickme_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dear teacher, I am sorry that I could not give you a decent job", "Apoligize", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            using (var frm=new AdminMainForm())
            {
                frm.ShowDialog();
            }
        }
    }
}
