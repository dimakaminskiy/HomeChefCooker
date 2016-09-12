using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic.Repository.implementation;
using WinHomeMeal.View.Dish;

namespace WinHomeMeal.Presenter
{
    public class DishesFormPresenter
    {

        public DishesForm Form { get; set; }
        public List<Dish> Dishes { get; set; }
        public UnitOfWork DataManager { get; }
        public ListView ListMeasures => Form.ListDishes;

        public DishesFormPresenter(DishesForm form)
        {
           Form = form;
           DataManager = UnitOfWork.GetInstance();
           Dishes = DataManager.DishRepository.Get().OrderBy(t => t.Name).ToList();
        }
       public void InitializeComboDishCategories()
       {
            var result = new List<Category>();
            var types = DataManager.CategoryRepository.Get().OrderBy(t => t.Name);
            result.AddRange(types);

            Form.combDishCategory.DataSource = result;
            Form.combDishCategory.DisplayMember = "Name";
            Form.combDishCategory.ValueMember = "Id";
       }

        public void FillListView()
        {
            ListMeasures.Items.Clear();
            ListMeasures.Items.AddRange(
                Dishes.Select(p => new ListViewItem(p.Name?.ToString()) { Tag = p.Id }).ToArray());
        }

      


    }
}
