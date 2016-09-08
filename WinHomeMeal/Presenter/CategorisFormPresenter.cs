using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BusinessLogic.Repository.implementation;
using WinHomeMeal.View.Category;


namespace WinHomeMeal.Presenter
{
    public class CategorisFormPresenter
    {
        public CategorisForm Form { get; set; }
        public List<Category> Categoris { get; set; }
        public UnitOfWork DataManager { get; }

        public ListView ListCategoris
        {
            get { return Form.ListCategories; }
        }
        
        public CategorisFormPresenter(CategorisForm form)
        {
            Form = form;
            DataManager = UnitOfWork.GetInstance();
            Categoris = DataManager.CategoryRepository.Get().OrderBy(t => t.Name).ToList();
        }

        public void FillCategoris()
        {
            ListCategoris.Items.Clear();
            ListCategoris.Items.AddRange(
                Categoris.Select(p => new ListViewItem(p.Name?.ToString()) {Tag = p.Id}).ToArray());
        }

        public void Editcategory(int id)
        {
            var category = Categoris.FirstOrDefault(t => t.Id == id);
            if (category == null) return;

            var f = new CategoryEditForm(category) {Text = "Редактировать продукт"};

            if (f.ShowDialog() == DialogResult.OK)
            {
                DataManager.CategoryRepository.Update(category);
                DataManager.Save();

                FillCategoris();

                foreach (ListViewItem lv in ListCategoris.Items)
                {
                    if (lv.Text == category.Name)
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

        public void Createcategory()
        {
            var category = new Category();
            var f = new CategoryEditForm(category) {Text = "Новый продукт"};
            if (f.ShowDialog() == DialogResult.OK)
            {
                DataManager.CategoryRepository.Insert(category);
                DataManager.Save();
                Categoris.Add(category);
                Categoris = Categoris.OrderBy(t => t.Name).ToList();

                FillCategoris();

                foreach (ListViewItem lv in ListCategoris.Items)
                {
                    if (lv.Text == category.Name)
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

        public void Deletecategory(int id)
        {
            var category = Categoris.FirstOrDefault(t => t.Id == id);
            if (category == null) return;


            var f = new CategoryEditForm(category) {Text = "Удалить категорию"};
            f.SetProductNameDisable(true);
            f.SetBtnSaveName("Удалить");

            if (f.ShowDialog() == DialogResult.OK)
            {
                DataManager.CategoryRepository.Delete(category);
                DataManager.Save();

                var index = Categoris.IndexOf(category);

                Categoris.Remove(category);
                Categoris = Categoris.OrderBy(t => t.Name).ToList();
                FillCategoris();

                if (Categoris.Count != 1)
                {
                    var newSelectedIndex = index - 1;
                    if (newSelectedIndex < 0)
                        newSelectedIndex = index;


                    var lv = ListCategoris.Items[newSelectedIndex];
                    lv.Selected = true;
                    lv.Focused = true;
                    lv.EnsureVisible();
                }
            }
        }
    }
}
