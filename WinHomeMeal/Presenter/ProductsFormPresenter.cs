using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BusinessLogic.Repository.implementation;
using WinHomeMeal.View.Product;

namespace WinHomeMeal.Presenter
{
    public class ProductsFormPresenter
    {
        public ProductsForm Form { get; set; }
        public List<Product> Products { get; set; }
        public UnitOfWork DataManager { get; }

        public ListView ListProcucts
        {
            get { return Form.ListProducts; }
        }
        
        public ProductsFormPresenter(ProductsForm form)
        {
            Form = form;
            DataManager = UnitOfWork.GetInstance();
            Products = DataManager.ProductRepository.Get().OrderBy(t => t.Name).ToList();
        }

        public void FillProducts()
        {
            ListProcucts.Items.Clear();
            ListProcucts.Items.AddRange(
                Products.Select(p => new ListViewItem(p.Name?.ToString()) {Tag = p.Id}).ToArray());
        }

        public void EditProduct(int id)
        {
            var product = Products.FirstOrDefault(t => t.Id == id);
            if (product == null) return;

            var f = new ProductEditForm(product) {Text = "Редактировать продукт"};

            if (f.ShowDialog() == DialogResult.OK)
            {
                DataManager.ProductRepository.Update(product);
                DataManager.Save();

                FillProducts();

                foreach (ListViewItem lv in Form.ListProducts.Items)
                {
                    if (lv.Text == product.Name)
                    {
                        lv.Selected = true;
                        lv.Focused = true;
                        lv.EnsureVisible();
                    }
                    else
                    {
                        lv.Selected = false;
                    }
                }
            }
        }

        public void CreateProduct()
        {
            var product = new Product();
            var f = new ProductEditForm(product) {Text = "Новый продукт"};
            if (f.ShowDialog() == DialogResult.OK)
            {
                DataManager.ProductRepository.Insert(product);
                DataManager.Save();
                Products.Add(product);
                Products = Products.OrderBy(t => t.Name).ToList();

                FillProducts();

                foreach (ListViewItem lv in Form.ListProducts.Items)
                {
                    if (lv.Text == product.Name)
                    {
                        lv.Selected = true;
                        lv.Focused = true;
                        lv.EnsureVisible();
                    }
                    else
                    {
                        lv.Selected = false;
                    }
                }
            }
        }

        public void DeleteProduct(int id)
        {
            var product = Products.FirstOrDefault(t => t.Id == id);
            if (product == null) return;


            var f = new ProductEditForm(product) {Text = "Удалить продукт"};
            f.SetProductNameDisable(true);
            f.SetBtnSaveName("Удалить");

            if (f.ShowDialog() == DialogResult.OK)
            {
                DataManager.ProductRepository.Delete(product);
                DataManager.Save();

                var index = Products.IndexOf(product);

                Products.Remove(product);
                Products = Products.OrderBy(t => t.Name).ToList();
                FillProducts();

                if (Products.Count != 1)
                {
                    var newSelectedIndex = index - 1;
                    if (newSelectedIndex < 0)
                        newSelectedIndex = index;


                    var lv = ListProcucts.Items[newSelectedIndex];
                    lv.Selected = true;
                    lv.Focused = true;
                    lv.EnsureVisible();
                }
            }
        }
    }
}
