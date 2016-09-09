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
            Presenter.InitializeComboDishCategories();
        
        }

        private void btnApplyFilters_Click(object sender, EventArgs e)
        {

        }

        private void btnDell_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }
    }
}
