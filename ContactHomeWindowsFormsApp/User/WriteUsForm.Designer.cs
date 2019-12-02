namespace ContactHomeWindowsFormsApp.User
{
    partial class WriteUsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WriteUsForm));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnExitWtritForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmailAdres = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblTeklif = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblKod = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSafeCodeBox = new System.Windows.Forms.TextBox();
            this.btnSendMail = new System.Windows.Forms.Button();
            this.errPrSendMail = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.panelHeader.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPrSendMail)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelHeader.Controls.Add(this.btnExitWtritForm);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(361, 69);
            this.panelHeader.TabIndex = 0;
            // 
            // btnExitWtritForm
            // 
            this.btnExitWtritForm.BackColor = System.Drawing.Color.White;
            this.btnExitWtritForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExitWtritForm.BackgroundImage")));
            this.btnExitWtritForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExitWtritForm.Location = new System.Drawing.Point(328, 6);
            this.btnExitWtritForm.Name = "btnExitWtritForm";
            this.btnExitWtritForm.Size = new System.Drawing.Size(28, 26);
            this.btnExitWtritForm.TabIndex = 1;
            this.btnExitWtritForm.UseVisualStyleBackColor = false;
            this.btnExitWtritForm.Click += new System.EventHandler(this.btnExitWtritForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bizə yazın";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(14, 46);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(335, 26);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "Sureyya";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblName.Location = new System.Drawing.Point(14, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 24);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Adınız";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Location = new System.Drawing.Point(0, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 85);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblEmail);
            this.groupBox2.Controls.Add(this.txtEmailAdres);
            this.groupBox2.Location = new System.Drawing.Point(0, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 95);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblEmail.Location = new System.Drawing.Point(14, 20);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(133, 20);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email ünvanınız";
            // 
            // txtEmailAdres
            // 
            this.txtEmailAdres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmailAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailAdres.Location = new System.Drawing.Point(14, 46);
            this.txtEmailAdres.Name = "txtEmailAdres";
            this.txtEmailAdres.Size = new System.Drawing.Size(335, 26);
            this.txtEmailAdres.TabIndex = 1;
            this.txtEmailAdres.Text = "sureyyahesenova@mail.ru";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSubject);
            this.groupBox3.Controls.Add(this.lblTeklif);
            this.groupBox3.Location = new System.Drawing.Point(0, 228);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(361, 143);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // lblTeklif
            // 
            this.lblTeklif.AutoSize = true;
            this.lblTeklif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTeklif.Location = new System.Drawing.Point(14, 20);
            this.lblTeklif.Name = "lblTeklif";
            this.lblTeklif.Size = new System.Drawing.Size(144, 20);
            this.lblTeklif.TabIndex = 2;
            this.lblTeklif.Text = "Təklif və istəyiniz";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblKod);
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtSafeCodeBox);
            this.groupBox4.Location = new System.Drawing.Point(0, 362);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(361, 175);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            // 
            // lblKod
            // 
            this.lblKod.AutoSize = true;
            this.lblKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKod.Location = new System.Drawing.Point(70, 36);
            this.lblKod.Name = "lblKod";
            this.lblKod.Size = new System.Drawing.Size(74, 15);
            this.lblKod.TabIndex = 4;
            this.lblKod.Text = "KAPÇAKOD ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(17, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 33);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(14, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şəkildəki təhlükəsizlik kodunu\r\naşağıda yazın";
            // 
            // txtSafeCodeBox
            // 
            this.txtSafeCodeBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSafeCodeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSafeCodeBox.Location = new System.Drawing.Point(14, 103);
            this.txtSafeCodeBox.Multiline = true;
            this.txtSafeCodeBox.Name = "txtSafeCodeBox";
            this.txtSafeCodeBox.Size = new System.Drawing.Size(329, 44);
            this.txtSafeCodeBox.TabIndex = 1;
            this.txtSafeCodeBox.Text = "?/?/?";
            // 
            // btnSendMail
            // 
            this.btnSendMail.BackColor = System.Drawing.Color.White;
            this.btnSendMail.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSendMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnSendMail.Location = new System.Drawing.Point(13, 556);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(131, 42);
            this.btnSendMail.TabIndex = 7;
            this.btnSendMail.Text = "Göndərin";
            this.btnSendMail.UseVisualStyleBackColor = false;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // errPrSendMail
            // 
            this.errPrSendMail.ContainerControl = this;
            // 
            // txtSubject
            // 
            this.txtSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubject.Location = new System.Drawing.Point(13, 44);
            this.txtSubject.Multiline = true;
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(336, 84);
            this.txtSubject.TabIndex = 3;
            this.txtSubject.Text = "Kontakt Home";
            // 
            // WriteUsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(364, 629);
            this.Controls.Add(this.btnSendMail);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WriteUsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WriteUsForm";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPrSendMail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmailAdres;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblTeklif;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblKod;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSafeCodeBox;
        private System.Windows.Forms.Button btnSendMail;
        private System.Windows.Forms.Button btnExitWtritForm;
        private System.Windows.Forms.ErrorProvider errPrSendMail;
        private System.Windows.Forms.TextBox txtSubject;
    }
}