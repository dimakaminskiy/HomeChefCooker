namespace WinHomeMeal.Controls
{
    partial class IngredientUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.comboProduct = new System.Windows.Forms.ComboBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.comboMeasure = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.checkBox1);
            this.flowLayoutPanel1.Controls.Add(this.comboProduct);
            this.flowLayoutPanel1.Controls.Add(this.txtValue);
            this.flowLayoutPanel1.Controls.Add(this.comboMeasure);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(462, 25);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // comboProduct
            // 
            this.comboProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboProduct.FormattingEnabled = true;
            this.comboProduct.Location = new System.Drawing.Point(78, 0);
            this.comboProduct.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.comboProduct.MaxDropDownItems = 6;
            this.comboProduct.Name = "comboProduct";
            this.comboProduct.Size = new System.Drawing.Size(250, 25);
            this.comboProduct.TabIndex = 0;
            // 
            // txtValue
            // 
            this.txtValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtValue.Location = new System.Drawing.Point(338, 1);
            this.txtValue.Margin = new System.Windows.Forms.Padding(10, 1, 0, 0);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(53, 23);
            this.txtValue.TabIndex = 2;
            this.txtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboMeasure
            // 
            this.comboMeasure.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboMeasure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboMeasure.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboMeasure.FormattingEnabled = true;
            this.comboMeasure.Location = new System.Drawing.Point(401, 0);
            this.comboMeasure.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.comboMeasure.Name = "comboMeasure";
            this.comboMeasure.Size = new System.Drawing.Size(60, 25);
            this.comboMeasure.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(0, 4);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(68, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Активно";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // IngredientUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "IngredientUserControl";
            this.Size = new System.Drawing.Size(462, 25);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.ComboBox comboProduct;
        public System.Windows.Forms.ComboBox comboMeasure;
        public System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
