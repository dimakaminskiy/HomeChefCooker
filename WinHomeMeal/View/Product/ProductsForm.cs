using System;
using System.Windows.Forms;
using WinHomeMeal.Presenter;

namespace WinHomeMeal.View.Product
{
    public partial class ProductsForm : Form
    {
       
        public ProductsFormPresenter Presenter { get; }

        public ProductsForm()
        {
            InitializeComponent();
            Presenter = new ProductsFormPresenter(this);
            Presenter.FillProducts();
        }

        private void ProductsForm_SizeChanged(object sender, EventArgs e)
        {
            Text = Size.ToString();
        }

        private void listProducts_DoubleClick(object sender, EventArgs eventArgs)
        {
            EditProduct();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Presenter.CreateProduct();
            ListProducts.Select();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditProduct();
        }

        private void btnDell_Click(object sender, EventArgs e)
        {
            var element = ListProducts.SelectedItems[0];
            if (element == null) return;

            Presenter.DeleteProduct(int.Parse(element.Tag.ToString()));
            ListProducts.Select();
        }

        private void EditProduct()
        {
            var element = ListProducts.SelectedItems[0];
            if (element == null) return;

            Presenter.EditProduct(int.Parse(element.Tag.ToString()));
            ListProducts.Select();
        }
    }
}
