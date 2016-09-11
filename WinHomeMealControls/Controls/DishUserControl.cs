using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinHomeMeal.Controls
{
    public partial class DishUserControl : UserControl
    {
        public Image DishImages
        {
            get { return picImage.Image; }
            set
            {
                picImage.Image = value;
                Invalidate(picImage.Region);
            }
        }





        public DishUserControl()
        {
            InitializeComponent();
        }
    }
}
