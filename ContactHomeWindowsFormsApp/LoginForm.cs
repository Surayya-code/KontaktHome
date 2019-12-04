using ContactHomeWindowsFormsApp.Core.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ContactHomeWindowsFormsApp.Data.ContactHomeDataSet;

namespace ContactHomeWindowsFormsApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.RoundControl(this.Width,this.Height,20,20);
        }

        
private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Close Program?", "Request", 0, MessageBoxIcon.Question) == DialogResult.OK) ;
            {
                Application.Exit();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        Point mousedownpoint = Point.Empty;

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            mousedownpoint = new Point(e.X, e.Y);
        }

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedownpoint.IsEmpty)
                return;
            //Form f = this as Form;
            this.Location = new Point(this.Location.X + (e.X - mousedownpoint.X), this.Location.Y + (e.Y - mousedownpoint.Y));

        }

        private void panelHeader_MouseUp(object sender, MouseEventArgs e)
        {
            mousedownpoint = Point.Empty;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (var frm = new ForTeacher())
            {
                frm.ShowDialog();
            }
            try
            {
                string hashPassword = txtPassword.Text.Hash();
                spCheckUserTableAdapter1.Fill(DataSet.spCheckUser, txtEmail.Text, hashPassword);
                
                if (DataSet.spCheckUser.Count<1)
                {
                    MessageBox.Show("Dont found user", "Error!", 0, MessageBoxIcon.Error);
                    return;
                }

                spCheckUserRow user = DataSet.spCheckUser.FirstOrDefault();

                Program.UserId = user.Id;
                //Program.CategoryId =Category.Id;

                switch (user.RoleId)
                {
                    case 1:
                        //admin
                       
                        using (var frm=new Admin.AdminMainForm())
                        {
                            frm.ShowDialog();
                        }
                        break;
                    case 2:
                        //admin
                        using (var frm = new User.UserMainForm())
                        {
                            frm.ShowDialog();
                        }
                        break;
                    default:
                        MessageBox.Show("This role is not considered", "Error!", 0, MessageBoxIcon.Error);
                        return;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.spCheckUserTableAdapter1.Fill(this.DataSet.spCheckUser, txtEmail.Text, txtPassword.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
