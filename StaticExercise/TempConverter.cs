using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public class TempConverter
    {
        public static double FahrenheitToCelsius(double myInt)
        {
            double celcius;
            celcius = (myInt - 32) * 5 / 9;
            return celcius;
        }

        public static double CelsiusToFahrenheit(double myInt)
        {
            double fahrenheit;
            fahrenheit = myInt * 1.8 + 32;
            return fahrenheit;
        }
    }
}
