using System;
using System.Windows.Forms;
using WinHomeMeal.Presenter;

namespace WinHomeMeal.View.Category
{
    public partial class CategorisForm : Form
    {
        public CategorisFormPresenter Presenter { get; }

        public CategorisForm()
        {
            InitializeComponent();

            Presenter = new CategorisFormPresenter(this);
            Presenter.FillCategoris();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditCategory();
        }

        private void btnDell_Click(object sender, EventArgs e)
        {
            var element = ListCategories.SelectedItems[0];
            if (element == null) return;

            Presenter.Deletecategory(int.Parse(element.Tag.ToString()));
            ListCategories.Select();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Presenter.Createcategory();
        }

        private void EditCategory()
        {
            var element = ListCategories.SelectedItems[0];
            if (element == null) return;

            Presenter.Editcategory(int.Parse(element.Tag.ToString()));
            ListCategories.Select();
        }

        private void ListCategories_DoubleClick(object sender, EventArgs e)
        {
            EditCategory();
        }
    }
}
