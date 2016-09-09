using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Repository.implementation;
using WinHomeMeal.View.Dish;

namespace WinHomeMeal.Presenter
{
    public class DishesFormPresenter
    {

        public DishesForm Form { get; set; }
        public List<Dish> Dishes { get; set; }
        public UnitOfWork DataManager { get; }
        public DishesFormPresenter(DishesForm form)
        {
           Form = form;
           DataManager = UnitOfWork.GetInstance();
        }
       public void InitializeComboDishCategories()
        {
            var result = new List<Category>();
            result.Add(new Category { Id = 0, Name = "Все категории" });
            var types = DataManager.CategoryRepository.Get().OrderBy(t => t.Name);
            result.AddRange(types);

            Form.combDishCategory.DataSource = result;
            Form.combDishCategory.DisplayMember = "Name";
            Form.combDishCategory.ValueMember = "Id";
        }

    }
}
