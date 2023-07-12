using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public class TempConverter
    {
        public static double FahrenheitToCelsius(double F)
        {
            double minusThirtyTwo = F - 32;
            double c = 5*minusThirtyTwo;
            return c/9;
        }

        public static double CelsiusToFahrenheit(double C)
        {
            double cTimesNine = C * 9;
            double f = cTimesNine/5;
            return f+32;
        }
    }
}
