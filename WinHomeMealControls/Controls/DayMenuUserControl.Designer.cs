namespace WinHomeMealControls.Controls
{
    partial class DayMenuUserControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label labMorning;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label9;
            this.tableLayoutPanelDay = new System.Windows.Forms.TableLayoutPanel();
            this.dinnerLabel1 = new System.Windows.Forms.Label();
            this.dinnerSecondLabel = new System.Windows.Forms.Label();
            this.dinnerFirstLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labDayName = new System.Windows.Forms.Label();
            this.breakfastLabel = new System.Windows.Forms.Label();
            labMorning = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanelDay.SuspendLayout();
            this.SuspendLayout();
            // 
            // labMorning
            // 
            labMorning.AutoSize = true;
            labMorning.Dock = System.Windows.Forms.DockStyle.Fill;
            labMorning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            labMorning.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            labMorning.Location = new System.Drawing.Point(6, 31);
            labMorning.Name = "labMorning";
            labMorning.Size = new System.Drawing.Size(148, 25);
            labMorning.TabIndex = 1;
            labMorning.Text = "Завтрак";
            labMorning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = System.Windows.Forms.DockStyle.Fill;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label6.Location = new System.Drawing.Point(6, 143);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(148, 25);
            label6.TabIndex = 5;
            label6.Text = "Обед";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = System.Windows.Forms.DockStyle.Fill;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label9.Location = new System.Drawing.Point(6, 227);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(148, 25);
            label9.TabIndex = 8;
            label9.Text = "Ужин";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanelDay
            // 
            this.tableLayoutPanelDay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelDay.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanelDay.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanelDay.ColumnCount = 1;
            this.tableLayoutPanelDay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelDay.Controls.Add(this.dinnerLabel1, 0, 9);
            this.tableLayoutPanelDay.Controls.Add(label9, 0, 8);
            this.tableLayoutPanelDay.Controls.Add(this.dinnerSecondLabel, 0, 7);
            this.tableLayoutPanelDay.Controls.Add(this.dinnerFirstLabel, 0, 6);
            this.tableLayoutPanelDay.Controls.Add(label6, 0, 5);
            this.tableLayoutPanelDay.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanelDay.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanelDay.Controls.Add(this.labDayName, 0, 0);
            this.tableLayoutPanelDay.Controls.Add(labMorning, 0, 1);
            this.tableLayoutPanelDay.Controls.Add(this.breakfastLabel, 0, 2);
            this.tableLayoutPanelDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutPanelDay.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelDay.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelDay.Name = "tableLayoutPanelDay";
            this.tableLayoutPanelDay.RowCount = 10;
            this.tableLayoutPanelDay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.9964F));
            this.tableLayoutPanelDay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0004F));
            this.tableLayoutPanelDay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0004F));
            this.tableLayoutPanelDay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0004F));
            this.tableLayoutPanelDay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0004F));
            this.tableLayoutPanelDay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0004F));
            this.tableLayoutPanelDay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0004F));
            this.tableLayoutPanelDay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0004F));
            this.tableLayoutPanelDay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0004F));
            this.tableLayoutPanelDay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0004F));
            this.tableLayoutPanelDay.Size = new System.Drawing.Size(160, 290);
            this.tableLayoutPanelDay.TabIndex = 0;
            // 
            // dinnerLabel1
            // 
            this.dinnerLabel1.AutoSize = true;
            this.dinnerLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dinnerLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dinnerLabel1.Location = new System.Drawing.Point(6, 255);
            this.dinnerLabel1.Name = "dinnerLabel1";
            this.dinnerLabel1.Size = new System.Drawing.Size(148, 32);
            this.dinnerLabel1.TabIndex = 9;
            this.dinnerLabel1.Text = "Блюдо";
            // 
            // dinnerSecondLabel
            // 
            this.dinnerSecondLabel.AutoSize = true;
            this.dinnerSecondLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dinnerSecondLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dinnerSecondLabel.Location = new System.Drawing.Point(6, 199);
            this.dinnerSecondLabel.Name = "dinnerSecondLabel";
            this.dinnerSecondLabel.Size = new System.Drawing.Size(148, 25);
            this.dinnerSecondLabel.TabIndex = 7;
            this.dinnerSecondLabel.Text = "Второе";
            // 
            // dinnerFirstLabel
            // 
            this.dinnerFirstLabel.AutoSize = true;
            this.dinnerFirstLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dinnerFirstLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dinnerFirstLabel.Location = new System.Drawing.Point(6, 171);
            this.dinnerFirstLabel.Name = "dinnerFirstLabel";
            this.dinnerFirstLabel.Size = new System.Drawing.Size(148, 25);
            this.dinnerFirstLabel.TabIndex = 6;
            this.dinnerFirstLabel.Text = "Первое";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "-\\";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Сладкое";
            // 
            // labDayName
            // 
            this.labDayName.AutoEllipsis = true;
            this.labDayName.AutoSize = true;
            this.labDayName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labDayName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labDayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labDayName.Location = new System.Drawing.Point(6, 3);
            this.labDayName.Name = "labDayName";
            this.labDayName.Size = new System.Drawing.Size(148, 25);
            this.labDayName.TabIndex = 0;
            this.labDayName.Text = "ПН - 1 Сентября";
            this.labDayName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // breakfastLabel
            // 
            this.breakfastLabel.AutoSize = true;
            this.breakfastLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.breakfastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.breakfastLabel.Location = new System.Drawing.Point(6, 59);
            this.breakfastLabel.Name = "breakfastLabel";
            this.breakfastLabel.Size = new System.Drawing.Size(148, 25);
            this.breakfastLabel.TabIndex = 2;
            this.breakfastLabel.Text = "Блюдо";
            // 
            // DayMenuUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelDay);
            this.Name = "DayMenuUserControl";
            this.Size = new System.Drawing.Size(160, 290);
            this.tableLayoutPanelDay.ResumeLayout(false);
            this.tableLayoutPanelDay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDay;
        private System.Windows.Forms.Label dinnerLabel1;
        private System.Windows.Forms.Label dinnerSecondLabel;
        private System.Windows.Forms.Label dinnerFirstLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labDayName;
        public System.Windows.Forms.Label breakfastLabel;
    }
}
