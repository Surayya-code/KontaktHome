using System;
using System.Windows.Forms;

namespace ContactHomeWindowsFormsApp.Admin
{
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contactHomeDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.contactHomeDataSet.Categories);

        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            
            categoriesTableAdapter.AddCategory(txtBNameCategory.Text,Program.UserId);
            this.categoriesTableAdapter.Fill(this.contactHomeDataSet.Categories);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
