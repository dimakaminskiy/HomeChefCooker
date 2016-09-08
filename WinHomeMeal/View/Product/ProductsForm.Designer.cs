using System;
using System.Windows.Forms;

namespace WinHomeMeal.View.Product
{
    partial class ProductsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsForm));
            this.listProducts = new System.Windows.Forms.ListView();
            this.ColumnProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDell = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listProducts
            // 
            this.listProducts.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnProductName});
            this.listProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.listProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listProducts.FullRowSelect = true;
            this.listProducts.GridLines = true;
            this.listProducts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listProducts.Location = new System.Drawing.Point(0, 0);
            this.listProducts.Name = "listProducts";
            this.listProducts.Size = new System.Drawing.Size(377, 397);
            this.listProducts.TabIndex = 0;
            this.listProducts.UseCompatibleStateImageBehavior = false;
            this.listProducts.View = System.Windows.Forms.View.Details;
            this.listProducts.VirtualListSize = 10;
            this.listProducts.DoubleClick += new System.EventHandler(this.listProducts_DoubleClick);
            // 
            // ColumnProductName
            // 
            this.ColumnProductName.Text = "Продукты";
            this.ColumnProductName.Width = 360;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDell);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 403);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 58);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управление";
            // 
            // btnDell
            // 
            this.btnDell.AutoSize = true;
            this.btnDell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDell.Location = new System.Drawing.Point(265, 19);
            this.btnDell.Name = "btnDell";
            this.btnDell.Size = new System.Drawing.Size(104, 27);
            this.btnDell.TabIndex = 2;
            this.btnDell.Text = "Удалить";
            this.btnDell.UseVisualStyleBackColor = true;
            this.btnDell.Click += new System.EventHandler(this.btnDell_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = true;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEdit.Location = new System.Drawing.Point(130, 19);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(118, 27);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Редактировать";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.AutoSize = true;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNew.Location = new System.Drawing.Point(10, 19);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(104, 27);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "Новый";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listProducts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Продукты";
            this.SizeChanged += new System.EventHandler(this.ProductsForm_SizeChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listProducts;
        public System.Windows.Forms.ColumnHeader ColumnProductName;
        private GroupBox groupBox1;
        private Button btnDell;
        private Button btnEdit;
        private Button btnNew;
    }
}