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
        public ListView ListView => Form.ListDishes;

        public DishesFormPresenter(DishesForm form)
        {
           Form = form;
           DataManager = UnitOfWork.GetInstance();
           Dishes = DataManager.DishRepository.Get().OrderBy(t => t.Name).ToList();
        }

        public void Initialize()
        {
            InitializeComboDishCategories();
            FillListView();
        }


       private void InitializeComboDishCategories()
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
            ListView.Items.Clear();
            ListView.Items.AddRange(
                Dishes.Select(p => new ListViewItem(p.Name?.ToString()) { Tag = p.Id }).ToArray());
        }


        public void Create()
        {
            //var measure = new Measure();
            //var f = new MeasureEditForm(measure) { Text = @"Новая упаковка" };
            //if (f.ShowDialog() == DialogResult.OK)
            //{
            //    DataManager.MeasureRepository.Insert(measure);
            //    DataManager.Save();

            //    Measures.Add(measure);
            //    Measures = Measures.OrderBy(t => t.Name).ToList();

            //    FillListView();

            //    foreach (ListViewItem lv in Form.ListMeasures.Items)
            //    {
            //        if (lv.Text == measure.Name)
            //        {
            //            lv.Selected = true;
            //            lv.Focused = true;
            //            lv.EnsureVisible();
            //        }
            //        else
            //        {
            //            lv.Selected = false;
            //        }
            //    }
            //}
        }

        public void Delete(int id)
        {
            //var measure = Measures.FirstOrDefault(t => t.Id == id);
            //if (measure == null) return;

            //var f = new MeasureEditForm(measure);
            //f.Text = @"Удалить упаковку";

            //f.SetMeasureNameDisable(true);
            //f.SetBtnSaveName("Удалить");

            //if (f.ShowDialog() == DialogResult.OK)
            //{
            //    var index = Measures.IndexOf(measure);

            //    DataManager.MeasureRepository.Delete(measure);
            //    DataManager.Save();

            //    Measures.Remove(measure);
            //    Measures = Measures.OrderBy(t => t.Name).ToList();


            //    FillListView();

            //    if (Measures.Count != 1)
            //    {
            //        var newSelectedIndex = index - 1;
            //        if (newSelectedIndex < 0)
            //            newSelectedIndex = index;


            //        var lv = ListMeasures.Items[newSelectedIndex];
            //        lv.Selected = true;
            //        lv.Focused = true;
            //        lv.EnsureVisible();
            //    }
            //}
        }

        public void Edit(int id)
        {
            var item = Dishes.FirstOrDefault(t => t.Id == id);
            if (item == null) return;

            DishEditForm f = new DishEditForm(item){ Text = @"Редактировать упаковку" };

            if (f.ShowDialog() == DialogResult.OK)
            {
                DataManager.DishRepository.Update(item);
                DataManager.Save();

                FillListView();

                foreach (ListViewItem lv in Form.ListDishes.Items)
                {
                    if (lv.Text == item.Name)
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
    }
    
}
