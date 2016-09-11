using System;
using System.Windows.Forms;
using WinHomeMeal.Presenter;

namespace WinHomeMeal.View.Measure
{
    public partial class MeasuresForm : Form
    {
       
        public MeasuresFormPresenter Presenter { get; }

        public MeasuresForm()
        {
            InitializeComponent();
            Presenter = new MeasuresFormPresenter(this);
            Presenter.FillListView();
        }

        private void MeasuresForm_SizeChanged(object sender, EventArgs e)
        {
            Text = Size.ToString();
        }

        private void listMeasures_DoubleClick(object sender, EventArgs eventArgs)
        {
            EditMeasure();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Presenter.CreateMeasure();
            ListMeasures.Select();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditMeasure();
        }

        private void btnDell_Click(object sender, EventArgs e)
        {
            var element = ListMeasures.SelectedItems[0];
            if (element == null) return;

            Presenter.DeleteMeasure(int.Parse(element.Tag.ToString()));
            ListMeasures.Select();
        }

        private void EditMeasure()
        {
            var element = ListMeasures.SelectedItems[0];
            if (element == null) return;

            Presenter.EditMeasure(int.Parse(element.Tag.ToString()));
            ListMeasures.Select();
        }
    }
}
