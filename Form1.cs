using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise8
{
    
public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            int Fatgrams;
            int Carbgrams;
            int TCalories;

            Calories fC = new Calories();
            Fatgrams = Decimal.ToInt32(NUDFatGrams.Value);
            int FatCalories = fC.FatCaloriesCal(Fatgrams);
            TBFatCalories.Text = FatCalories.ToString();

            Calories CC = new Calories();
            Carbgrams = Decimal.ToInt32(NUDCarbGrams.Value);
            int CarbCalories = CC.CarbCaloriesCal(Carbgrams);
            TBCarbCalories.Text = CarbCalories.ToString();

            TCalories = FatCalories + CarbCalories;
            TBTotalCalories.Text = TCalories.ToString();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
