using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinHomeMeal
{
    public partial class DayMenuUserControl : UserControl
    {
        public DayMenuUserControl()
        {
            InitializeComponent();
        }

        public int Id
        {
            get { return int.Parse(this.Tag.ToString()); }
            set { this.Tag = value; }
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

        public string DayFullName {
            get {  return  labDayName.Text; }
            set { labDayName.Text = value; } }

    }
}
