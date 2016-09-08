using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BusinessLogic.Logic;
using BusinessLogic.Repository.implementation;
using WinHomeMeal.View.Product;

namespace WinHomeMeal
{
    public partial class MainForm : Form
    {
        public UnitOfWork DataManager { get; private set; }
        public ChiefCooker Cooker { get; set; }
        public InitializerDb Initializer { get; set; }
        IEnumerable<DayMenuUserControl> DayMenuControls { get; set; }

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

        //private void CookingDay_OnFullNameChangeEventHandler(object sender, string fullName)
        //{
        //    var day = sender as CookingDay;
        //    if (day == null) return;

        //    int id = day.Id;
        //    var control = GetDayMenuUserControlById(id);
        //    control.DayFullName = fullName;
        //}

        //private void CookingDay_OnDinnerDishChange(object sender)
        //{
        //    var day = sender as CookingDay;
        //    if (day==null) return;

        //    int id = day.Id;
        //    var control = GetDayMenuUserControlById(id);
        //    control.DinnerFistDish = day.Dinner.FirstDish.Name;
        //    control.DinnerSecondDish = day.Dinner.SecondDish.Name;
        //}

        //private void CookingDay_OnBreakfastDishChange(object sender)
        //{
        //    var day = sender as CookingDay;
        //    if (day == null) return;
        //    int id = day.Id;
        //    var control = GetDayMenuUserControlById(id);
        //    control.Breakfast = day.Breakfast.BreakfastDish.Name;
        //}

        private  DayMenuUserControl GetDayMenuUserControlById(int id)
        {
            return DayMenuControls.Single(t => t.Id == id);
        }

        private void productsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var f = new ProductsForm();
            f.ShowDialog();
        }
    }
}
