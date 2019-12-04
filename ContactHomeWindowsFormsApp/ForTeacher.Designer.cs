namespace ContactHomeWindowsFormsApp
{
    partial class ForTeacher
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
            this.btnClickme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClickme
            // 
            this.btnClickme.BackColor = System.Drawing.Color.Maroon;
            this.btnClickme.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClickme.Location = new System.Drawing.Point(58, 24);
            this.btnClickme.Name = "btnClickme";
            this.btnClickme.Size = new System.Drawing.Size(161, 58);
            this.btnClickme.TabIndex = 0;
            this.btnClickme.Text = "Massage for dear  teacher";
            this.btnClickme.UseVisualStyleBackColor = false;
            this.btnClickme.Click += new System.EventHandler(this.btnClickme_Click);
            // 
            // ForTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 108);
            this.Controls.Add(this.btnClickme);
            this.Name = "ForTeacher";
            this.Text = "ForTeacher";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClickme;
    }
}