using System;
using System.Windows.Forms;

namespace WinHomeMeal.View.Category
{
    public partial class CategoryEditForm : Form
    {
        public WinHomeMeal.Category Category { get; set; }

        public CategoryEditForm(WinHomeMeal.Category category)
        {
            Category = category;
            InitializeComponent();


            InitializeComponent();
           
            Initialize();
            txtEditProductName_TextChanged(null, null);
        }

        private void Initialize()
        {
            txtEditProductName.Text = Category.Name;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Category.Name = txtEditProductName.Text.Trim();
            this.Close();
        }

        private void txtEditProductName_TextChanged(object sender, EventArgs e)
        {
            if (txtEditProductName.Text.Trim().Length < 1)
            {
                SetBtnSaveEnable(false);
            }
            else
            {
                SetBtnSaveEnable(true);
            }
        }

        public void SetProductNameDisable(bool value)
        {
            txtEditProductName.ReadOnly = value;
        }


        public void SetBtnSaveEnable(bool value)
        {
            btnOk.Enabled = value;
        }

        public void SetBtnSaveName(string name)
        {
            btnOk.Text = name;
        }

    }
}
