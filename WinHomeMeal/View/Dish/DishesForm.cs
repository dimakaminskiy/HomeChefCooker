using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinHomeMeal.Presenter;

namespace WinHomeMeal.View.Dish
{
    public partial class DishesForm : Form
    {
        DishesFormPresenter Presenter { get; set; }
        public DishesForm()
        {
            InitializeComponent();
            Presenter = new DishesFormPresenter(this);
            Initialize();
        }

        public void Initialize()
        {
            Presenter.Initialize();
        }

        private void btnApplyFilters_Click(object sender, EventArgs e)
        {

        }

        private void btnDell_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {


            var element = ListDishes.SelectedItems[0];
            if (element == null) return;

            Presenter.Edit(int.Parse(element.Tag.ToString()));
            ListDishes.Select();
            
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //var dish = new WinHomeMeal.Dish();
            //dish.Ingredients = new List<Ingredient>();
            //dish.DishImages = new List<DishImage>();
            //var f = new DishEditForm(dish);
            //f.ShowDialog();
        }
    }
}
