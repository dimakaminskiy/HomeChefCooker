using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic.Repository.implementation;
using WinHomeMeal.Presenter;

namespace WinHomeMeal.View.Product
{
    public partial class ProductsForm : Form
    {
       
        public  ListView ListProducts { get { return listProducts; } }
        public  ProductsFormPresenter Presenter { get; private set; }
        public ProductsForm()
        {
          
            InitializeComponent();
            Presenter = new ProductsFormPresenter(this);
            Presenter.FillProducts();
        }

        private void ProductsForm_SizeChanged(object sender, EventArgs e)
        {
            this.Text = this.Size.ToString();
        }

        private void listProducts_DoubleClick(object sender, EventArgs eventArgs)
        {
            EditProduct();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Presenter.CreateProduct();
            listProducts.Select();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditProduct();
        }

        private void btnDell_Click(object sender, EventArgs e)
        {
            var element = listProducts.SelectedItems[0];
            if (element == null) return;
            
            Presenter.DeleteProduct(int.Parse(element.Tag.ToString()));
            listProducts.Select();
        }

        private void EditProduct()
        {
            var element = listProducts.SelectedItems[0];
            if (element == null) return;

            Presenter.EditProduct(int.Parse(element.Tag.ToString()));
            listProducts.Select();
        }

    }
}
