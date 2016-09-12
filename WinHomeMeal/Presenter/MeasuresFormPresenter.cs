using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BusinessLogic.Repository.implementation;
using WinHomeMeal.View.Measure;

namespace WinHomeMeal.Presenter
{
    public class MeasuresFormPresenter
    {
        public MeasuresFormPresenter(MeasuresForm form)
        {
            Form = form;
            DataManager = UnitOfWork.GetInstance();
            Measures = DataManager.MeasureRepository.Get(t => t.Id != 1).OrderBy(t => t.Name).ToList();
        }

        public MeasuresForm Form { get; }
        public List<Measure> Measures { get; set; }
        public UnitOfWork DataManager { get; }
        public ListView ListMeasures => Form.ListMeasures;

        public void FillListView()
        {
            ListMeasures.Items.Clear();
            ListMeasures.Items.AddRange(
                Measures.Select(p => new ListViewItem(p.Name?.ToString()) {Tag = p.Id}).ToArray());
        }


        public void CreateMeasure()
        {
            var measure = new Measure();
            var f = new MeasureEditForm(measure) {Text = @"Новая упаковка"};
            if (f.ShowDialog() == DialogResult.OK)
            {
                DataManager.MeasureRepository.Insert(measure);
                DataManager.Save();

                Measures.Add(measure);
                Measures = Measures.OrderBy(t => t.Name).ToList();

                FillListView();

                foreach (ListViewItem lv in Form.ListMeasures.Items)
                {
                    if (lv.Text == measure.Name)
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

        public void DeleteMeasure(int id)
        {
            var measure = Measures.FirstOrDefault(t => t.Id == id);
            if (measure == null) return;

            var f = new MeasureEditForm(measure);
            f.Text = @"Удалить упаковку";

            f.SetMeasureNameDisable(true);
            f.SetBtnSaveName("Удалить");

            if (f.ShowDialog() == DialogResult.OK)
            {
                var index = Measures.IndexOf(measure);

                DataManager.MeasureRepository.Delete(measure);
                DataManager.Save();

                Measures.Remove(measure);
                Measures = Measures.OrderBy(t => t.Name).ToList();


                FillListView();

                if (Measures.Count != 1)
                {
                    var newSelectedIndex = index - 1;
                    if (newSelectedIndex < 0)
                        newSelectedIndex = index;


                    var lv = ListMeasures.Items[newSelectedIndex];
                    lv.Selected = true;
                    lv.Focused = true;
                    lv.EnsureVisible();
                }
            }
        }

        public void EditMeasure(int id)
        {
            var item = Measures.FirstOrDefault(t => t.Id == id);
            if (item == null) return;

            var f = new MeasureEditForm(item) {Text = @"Редактировать упаковку"};

            if (f.ShowDialog() == DialogResult.OK)
            {
                DataManager.MeasureRepository.Update(item);
                DataManager.Save();

                FillListView();

                foreach (ListViewItem lv in Form.ListMeasures.Items)
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