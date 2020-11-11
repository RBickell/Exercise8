namespace Exercise8
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblFatGrams = new System.Windows.Forms.Label();
            this.LBLCarbGrams = new System.Windows.Forms.Label();
            this.LblFatCalories = new System.Windows.Forms.Label();
            this.LBLCarbCalories = new System.Windows.Forms.Label();
            this.LblTotalCalories = new System.Windows.Forms.Label();
            this.NUDFatGrams = new System.Windows.Forms.NumericUpDown();
            this.NUDCarbGrams = new System.Windows.Forms.NumericUpDown();
            this.TBFatCalories = new System.Windows.Forms.TextBox();
            this.TBCarbCalories = new System.Windows.Forms.TextBox();
            this.TBTotalCalories = new System.Windows.Forms.TextBox();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NUDFatGrams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCarbGrams)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // lblFatGrams
            // 
            this.lblFatGrams.AutoSize = true;
            this.lblFatGrams.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFatGrams.Location = new System.Drawing.Point(197, 63);
            this.lblFatGrams.Name = "lblFatGrams";
            this.lblFatGrams.Size = new System.Drawing.Size(188, 20);
            this.lblFatGrams.TabIndex = 1;
            this.lblFatGrams.Text = "Enter in Grams of Fat:";
            // 
            // LBLCarbGrams
            // 
            this.LBLCarbGrams.AutoSize = true;
            this.LBLCarbGrams.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLCarbGrams.Location = new System.Drawing.Point(198, 117);
            this.LBLCarbGrams.Name = "LBLCarbGrams";
            this.LBLCarbGrams.Size = new System.Drawing.Size(185, 20);
            this.LBLCarbGrams.TabIndex = 3;
            this.LBLCarbGrams.Text = "Enter grams of Carbs:";
            // 
            // LblFatCalories
            // 
            this.LblFatCalories.AutoSize = true;
            this.LblFatCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFatCalories.Location = new System.Drawing.Point(83, 174);
            this.LblFatCalories.Name = "LblFatCalories";
            this.LblFatCalories.Size = new System.Drawing.Size(152, 20);
            this.LblFatCalories.TabIndex = 5;
            this.LblFatCalories.Text = "Calories from Fat:";
            // 
            // LBLCarbCalories
            // 
            this.LBLCarbCalories.AutoSize = true;
            this.LBLCarbCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLCarbCalories.Location = new System.Drawing.Point(379, 175);
            this.LBLCarbCalories.Name = "LBLCarbCalories";
            this.LBLCarbCalories.Size = new System.Drawing.Size(172, 20);
            this.LBLCarbCalories.TabIndex = 7;
            this.LBLCarbCalories.Text = "Calories from Carbs:";
            // 
            // LblTotalCalories
            // 
            this.LblTotalCalories.AutoSize = true;
            this.LblTotalCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalCalories.Location = new System.Drawing.Point(259, 228);
            this.LblTotalCalories.Name = "LblTotalCalories";
            this.LblTotalCalories.Size = new System.Drawing.Size(124, 20);
            this.LblTotalCalories.TabIndex = 9;
            this.LblTotalCalories.Text = "Total Calories:";
            // 
            // NUDFatGrams
            // 
            this.NUDFatGrams.Location = new System.Drawing.Point(394, 63);
            this.NUDFatGrams.Name = "NUDFatGrams";
            this.NUDFatGrams.Size = new System.Drawing.Size(120, 20);
            this.NUDFatGrams.TabIndex = 11;
            this.NUDFatGrams.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NUDCarbGrams
            // 
            this.NUDCarbGrams.Location = new System.Drawing.Point(394, 117);
            this.NUDCarbGrams.Name = "NUDCarbGrams";
            this.NUDCarbGrams.Size = new System.Drawing.Size(120, 20);
            this.NUDCarbGrams.TabIndex = 12;
            this.NUDCarbGrams.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TBFatCalories
            // 
            this.TBFatCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBFatCalories.Location = new System.Drawing.Point(245, 174);
            this.TBFatCalories.Name = "TBFatCalories";
            this.TBFatCalories.ReadOnly = true;
            this.TBFatCalories.Size = new System.Drawing.Size(100, 20);
            this.TBFatCalories.TabIndex = 13;
            this.TBFatCalories.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TBCarbCalories
            // 
            this.TBCarbCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCarbCalories.Location = new System.Drawing.Point(552, 174);
            this.TBCarbCalories.Name = "TBCarbCalories";
            this.TBCarbCalories.ReadOnly = true;
            this.TBCarbCalories.Size = new System.Drawing.Size(100, 20);
            this.TBCarbCalories.TabIndex = 14;
            this.TBCarbCalories.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TBTotalCalories
            // 
            this.TBTotalCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBTotalCalories.Location = new System.Drawing.Point(394, 230);
            this.TBTotalCalories.Name = "TBTotalCalories";
            this.TBTotalCalories.ReadOnly = true;
            this.TBTotalCalories.Size = new System.Drawing.Size(100, 20);
            this.TBTotalCalories.TabIndex = 15;
            this.TBTotalCalories.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.BackColor = System.Drawing.Color.Blue;
            this.BtnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalculate.ForeColor = System.Drawing.Color.White;
            this.BtnCalculate.Location = new System.Drawing.Point(199, 306);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(146, 51);
            this.BtnCalculate.TabIndex = 16;
            this.BtnCalculate.Text = "Calculate Calories";
            this.BtnCalculate.UseVisualStyleBackColor = false;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Black;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Location = new System.Drawing.Point(430, 306);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(146, 51);
            this.BtnClose.TabIndex = 17;
            this.BtnClose.Text = "Exit";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.TBTotalCalories);
            this.Controls.Add(this.TBCarbCalories);
            this.Controls.Add(this.TBFatCalories);
            this.Controls.Add(this.NUDCarbGrams);
            this.Controls.Add(this.NUDFatGrams);
            this.Controls.Add(this.LblTotalCalories);
            this.Controls.Add(this.LBLCarbCalories);
            this.Controls.Add(this.LblFatCalories);
            this.Controls.Add(this.LBLCarbGrams);
            this.Controls.Add(this.lblFatGrams);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NUDFatGrams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCarbGrams)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFatGrams;
        private System.Windows.Forms.Label LBLCarbGrams;
        private System.Windows.Forms.Label LblFatCalories;
        private System.Windows.Forms.Label LBLCarbCalories;
        private System.Windows.Forms.Label LblTotalCalories;
        private System.Windows.Forms.NumericUpDown NUDFatGrams;
        private System.Windows.Forms.NumericUpDown NUDCarbGrams;
        private System.Windows.Forms.TextBox TBFatCalories;
        private System.Windows.Forms.TextBox TBCarbCalories;
        private System.Windows.Forms.TextBox TBTotalCalories;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.Button BtnClose;
    }
}

