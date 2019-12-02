using ContactHomeWindowsFormsApp.Core.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactHomeWindowsFormsApp.User
{
    public partial class WriteUsForm : Form
    {
        public WriteUsForm()
        {
            InitializeComponent();
            this.RoundControl(this.Width, this.Height, 20, 20);
        }

        private void btnExitWtritForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            #region Validate Mail inputs
            errPrSendMail.Clear();

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errPrSendMail.SetError(txtName, "Boş buraxıla bilməz!");
                txtName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtEmailAdres.Text))
            {
                errPrSendMail.SetError(txtEmailAdres, "Boş buraxıla bilməz!");
                txtEmailAdres.Focus();
                return;
            }
            #endregion

            MailMessage message = new MailMessage();
            message.To.Add(txtEmailAdres.Text);
            message.Subject =txtSubject.Text;
            //message.Body =;
            message.From =new MailAddress("fullstackstaff@mail.ru","KontaktHome Client");
            SmtpClient smptclient= new SmtpClient("smpt.mail.ru",587);
            smptclient.EnableSsl = true;
            smptclient.UseDefaultCredentials = false;
            smptclient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smptclient.Credentials = new NetworkCredential("fullstackstaff", "!sysStudent@0!9#win");
            smptclient.Send(message);

        }
    }
}
