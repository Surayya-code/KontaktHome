using CryptoManager.Core;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace CryptoManager
{
    public partial class CryptoForm : Form
    {
        public CryptoForm()
        {
            InitializeComponent();

            //her hansi yerde error olsa 1 noqteden idare etmek ucun asagidaki iki eventi aktivleshdiririk
            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
        }

        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.ToString(), "Error!", 0, MessageBoxIcon.Error);
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            MessageBox.Show((e.ExceptionObject as Exception).Message, "Error!", 0, MessageBoxIcon.Error);
        }

        private void BtnReverse_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInput.Text))
                return;

            txtInput.Text = string.Join("", txtInput.Text.Reverse());
            Clipboard.SetText(txtInput.Text);//melumati bufer yaddasa kopyalayir
        }

        private void BtnUpper_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInput.Text))
                return;

            txtInput.Text = txtInput.Text.ToUpper();
            Clipboard.SetText(txtInput.Text);//melumati bufer yaddasa kopyalayir
        }

        private void BtnLower_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInput.Text))
                return;

            txtInput.Text = txtInput.Text.ToLower();
            Clipboard.SetText(txtInput.Text);//melumati bufer yaddasa kopyalayir
        }

        private void BtnEncrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInput.Text))
                return;

            txtOutput.Text = txtInput.Text.Encrypt();
            Clipboard.SetText(txtOutput.Text);
        }

        private void BtnDecrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInput.Text))
                return;

            txtOutput.Text = txtInput.Text.Decrypt();
            Clipboard.SetText(txtOutput.Text);
        }

        private void BtnSerialNumber_Click(object sender, EventArgs e)
        {
            txtInput.Text = Crypto.GetRandomString(25);
            txtOutput.Text = Regex.Replace(txtInput.Text.ToUpper(), @"(\w{5})(\w{5})(\w{5})(\w{5})(\w{5})", "$1-$2-$3-$4-$5");
            Clipboard.SetText(txtOutput.Text);
        }
    }
}
