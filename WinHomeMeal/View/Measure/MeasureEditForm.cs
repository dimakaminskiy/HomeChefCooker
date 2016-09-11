using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic.Repository.implementation;

namespace WinHomeMeal.View.Measure
{
    public partial class MeasureEditForm : Form
    {

        public WinHomeMeal.Measure  Measure { get; private set; }
       
        public MeasureEditForm(WinHomeMeal.Measure measure)
        {
            InitializeComponent();
            Measure = measure;

            Initialize();
            txtEditMeasureName_TextChanged(null, null);
        }

        private void Initialize()
        {
            txtEditMeasureName.Text = Measure.Name;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Measure.Name = txtEditMeasureName.Text.Trim();
            this.Close();   
        }

        private void txtEditMeasureName_TextChanged(object sender, EventArgs e)
        {
            if (txtEditMeasureName.Text.Trim().Length < 1)
            {
                SetBtnSaveEnable(false);
            }
            else
            {
                SetBtnSaveEnable(true);
            }
        }

        public void SetMeasureNameDisable(bool value)
        {
            txtEditMeasureName.ReadOnly = value;
        }


        public void SetBtnSaveEnable (bool value)
        {
            btnOk.Enabled = value;
        }

        public void SetBtnSaveName(string name)
        {
            btnOk.Text = name;
        }


    }
}
