using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop
{
    public class Work
    {
//        To the Util Class add temperaturConversion static function, given the temperature
//in fahrenheit as input outputs the temperature in Celsius or viceversa using the
//formula
//Celsius to Fahrenheit: (°C × 9/5) + 32 = °F
//Fahrenheit to Celsius: (°F − 32) x 5/9 = °C


        public void  temperaturConversion()
        {
            double Fahrenheit;
            double Celsius;
            Console.WriteLine(" Please enter the input forFahrenheit ");
            double Data = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Please enter the input Celsius ");
            double Data2 = Convert.ToDouble(Console.ReadLine());
           

            Fahrenheit = (Data * 9/5) + 32;
            Celsius = Math.Floor((Data2 - 32) * 5 / 9);

            Console.WriteLine(Fahrenheit+"F \n"+Celsius+" C"  );




        }
}
}
