using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Kata
{
    public class BMI
    {
        public static string Bmi(double weight, double height)
        {
            var calculateBMI = weight / Math.Pow(height, 2);

            if (calculateBMI <= 18.5) { return "Underweight"; }

            else if (calculateBMI <= 25.0) { return "Normal"; }

            else if (calculateBMI <= 30.0) { return "Overweight"; }

            else { return "Obese"; }

        }
            
            
    }
}
