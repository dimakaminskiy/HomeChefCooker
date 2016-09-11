using System.Windows.Forms;

namespace WinHomeMeal.Controls
{
    public partial class IngredientUserControl : UserControl
    {
        public IngredientUserControl()
        {
            InitializeComponent();
            txtValue.KeyPress += TxtValue_KeyPress;
        }

        private void TxtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }
    }
}
