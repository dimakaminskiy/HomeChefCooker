namespace WinHomeMeal.View.Dish
{
    partial class DishEditForm
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
            this.btnNew = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dishUserControl1 = new WinHomeMeal.Controls.DishUserControl();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.AutoSize = true;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNew.Location = new System.Drawing.Point(770, 656);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(104, 27);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "Отмена";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(612, 656);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dishUserControl1
            // 
            this.dishUserControl1.DishImages = null;
            this.dishUserControl1.Location = new System.Drawing.Point(0, 0);
            this.dishUserControl1.Name = "dishUserControl1";
            this.dishUserControl1.Size = new System.Drawing.Size(970, 653);
            this.dishUserControl1.TabIndex = 0;
            // 
            // DishEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 686);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dishUserControl1);
            this.Name = "DishEditForm";
            this.Text = "DishEditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.DishUserControl dishUserControl1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button button1;
    }
}