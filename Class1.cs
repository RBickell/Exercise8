using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    public class Calories
    {
        int Fatgrams;
        int Carbgrams;
        int TCalories;
        int FatCalories;
        int CarbCalories;

        public int FatCaloriesCal(int Fatgrams)
        {
            FatCalories = Fatgrams * 9;
            return FatCalories;
        }
        public int CarbCaloriesCal(int Carbgrams)
        {
            CarbCalories = Carbgrams * 4;
            return CarbCalories;
        }
    }
}
