﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic.Repository.implementation;

namespace WinHomeMeal.View.Product
{
    public partial class ProductEditForm : Form
    {

        public WinHomeMeal.Product  Product { get; private set; }
       
        public ProductEditForm(WinHomeMeal.Product product)
        {
            InitializeComponent();
            Product = product;

            Initialize();
            txtEditProductName_TextChanged(null, null);
        }

        private void Initialize()
        {
            txtEditProductName.Text = Product.Name;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Product.Name = txtEditProductName.Text.Trim();
            this.Close();   
        }

        private void txtEditProductName_TextChanged(object sender, EventArgs e)
        {
            if (txtEditProductName.Text.Trim().Length < 1)
            {
                SetBtnSaveEnable(false);
            }
            else
            {
                SetBtnSaveEnable(true);
            }
        }

        public void SetProductNameDisable(bool value)
        {
            txtEditProductName.ReadOnly = value;
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
