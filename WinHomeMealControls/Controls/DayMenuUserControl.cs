using System.Windows.Forms;

namespace WinHomeMealControls.Controls
{
    public partial class DayMenuUserControl : UserControl
    {
        public DayMenuUserControl()
        {
            InitializeComponent();
            Tag = "0";
        }

        public int? Id
        {
            get
            {
                int result = 0;
                if (string.IsNullOrEmpty(Tag.ToString())) return result;
                return int.Parse(Tag.ToString());
            }
            set { Tag = value; }
        }


        public string Breakfast
        {
            get { return breakfastLabel.Text; }
            set { breakfastLabel.Text = value; }
        }

        public string DinnerFistDish
        {
            get { return dinnerFirstLabel.Text; }
            set { dinnerFirstLabel.Text = value; }
        }

        public string DinnerSecondDish
        {
            get { return dinnerSecondLabel.Text; }
            set { dinnerSecondLabel.Text = value; }
        }

        public string DayFullName
        {
            get { return labDayName.Text; }
            set { labDayName.Text = value; }
        }
    }
}
