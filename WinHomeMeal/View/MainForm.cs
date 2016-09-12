using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BusinessLogic.Logic;
using BusinessLogic.Repository.implementation;
using WinHomeMeal.View.Category;
using WinHomeMeal.View.Dish;
using WinHomeMeal.View.Measure;
using WinHomeMeal.View.Product;
using WinHomeMealControls.Controls;

namespace WinHomeMeal
{
    public partial class MainForm : Form
    {
        public UnitOfWork DataManager { get; private set; }
        public ChiefCooker Cooker { get; set; }
        public InitializerDb Initializer { get; set; }
        IEnumerable<DayMenuUserControl> DayMenuControls { get; set; }

        public int GetMealCountDay { get; set; }


        public MainForm()
        {
            InitializeComponent();
            DayMenuControls = flowLayoutPanel1.Controls.OfType<DayMenuUserControl>().ToArray();

            DataManager = UnitOfWork.GetInstance();
            Initializer = new InitializerDb(DataManager);
            InitializeComponents();

        }
        public void InitializeComponents()
        {
            InitializeDataBase();
            InitializeDessertCombobox();
            InitializeCooker();
        }
        private void InitializeDataBase()
        {
           // if (!DataManager.CategoryRepository.Get().Any())
                Initializer.Run();
        }
        private void InitializeDessertCombobox()
        {
            var days = DataManager.ScheduleDayRepository.Get();
            comboDessert.DataSource = days;
            comboDessert.ValueMember = "Id";
            comboDessert.DisplayMember = "FullName";
        }

        void InitializeCooker()
        {
            Cooker = new ChiefCooker();
            var days =  Cooker.Days;

            foreach (CookingDay day in days)
            {
                var control = GetDayMenuUserControlById(day.Id);
                control.DayFullName = day.FullName;
             
            }

        }



        private  DayMenuUserControl GetDayMenuUserControlById(int id)
        {
            return DayMenuControls.Single(t => t.Id == id);
        }

        private void productsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var f = new ProductsForm();
            f.ShowDialog();
        }

        private void categoriesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var f = new CategorisForm();
            f.ShowDialog();
        }

        private void recipesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var f = new DishesForm();
            f.Show();
        }

        private void measureToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var f = new MeasuresForm();
            f.ShowDialog();
        }
    }
}
