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
using WinHomeMeal.Controls;
using WinHomeMeal;

namespace WinHomeMeal.View.Dish
{
    public partial class DishEditForm : Form
    {
        public WinHomeMeal.Dish Dish { get; set; }
        public UnitOfWork DataManager { get; }
        public List<WinHomeMeal.Product> Products { get; set; }
        public List<WinHomeMeal.Measure> Measures { get; set; }

        public List<Ingredient> Ingredients;

        IEnumerable<IngredientUserControl> IngredientUserControls { get; set; }

        
        public DishEditForm( WinHomeMeal.Dish dish)
        {
            Dish = dish;

            Ingredients = new List<Ingredient>();

            if (dish.IngredientS != null)
            {
                Ingredients.AddRange(dish.IngredientS.ToArray());
            }

            

            DataManager = UnitOfWork.GetInstance();
            InitializeComponent();
            Initialize();
        }

        void Initialize()
        {
            Products = DataManager.ProductRepository.Get().OrderBy(t => t.Name).ToList();
            Measures = DataManager.MeasureRepository.Get().OrderBy(t => t.Name).ToList();
            IngredientUserControls = dishUserControl1.Controls.OfType<IngredientUserControl>().ToArray();
        }

        void FillIngredientUserControls()
        {

            //var count = IngredientUserControls.Count();
            //var dishCount = Ingredients.Count;


            //while (count != dishCount)
            //{
            //    Ingredients.Add( new Ingredient() { Id =0, new WinHomeMeal.Measure(),0, new Pre)});
            //}



        }






        public void InitializeComboDishCategories(IngredientUserControl control, Ingredient ingredient)
        {
            InitializeProductCombobox(control.comboProduct, Products, ingredient.ProductId);
            InitializeMeasureCombobox(control.comboMeasure, Measures, ingredient.MeasureId);
            control.txtValue.Text = ingredient.Value.ToString();
        }

        private void InitializeProductCombobox(ComboBox control, List<WinHomeMeal.Product> products, int selected)
        {
            products.Insert(0, new WinHomeMeal.Product() {Id=0, Name ="--------------"});
            control.DataSource = products;
            control.DisplayMember = "Name";
            control.ValueMember = "Id";
            control.SelectedValue = selected;

        }

        private void InitializeMeasureCombobox(ComboBox control, List<WinHomeMeal.Measure> measures, int selected)
        {
            measures.Insert(0, new WinHomeMeal.Measure() { Id = 0, Name = "--------------" });
            control.DataSource = measures;
            control.DisplayMember = "Name";
            control.ValueMember = "Id";
            control.SelectedValue = selected;

        }



    }
}
