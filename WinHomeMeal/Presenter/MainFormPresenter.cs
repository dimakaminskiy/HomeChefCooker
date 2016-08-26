using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinHomeMeal.Presenter
{
    public class MainFormPresenter
    {
        public MainForm Form { get; private set; }

        public MainFormPresenter(MainForm form)
        {
            Form = form;
        }
    }
}
