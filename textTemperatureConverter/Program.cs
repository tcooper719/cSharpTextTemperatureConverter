//Simple program to convert temperatures back and forth
//for learning c#
using System;

namespace textTemperatureConverter
{
    class Program
    {
        //define method, return type double, pass selected user option and temperature
        static double temperatureConversion(byte optSelect, double temperature)
        {
            if (optSelect == 1)
                return ((temperature - 32d) * (5d / 9d));
            else
                return ((temperature * (9d / 5d)) + 32d);
        }

        static void Main(string[] args)
        {
            byte optSel;
            double fahrenheit, celsius;


            Console.WriteLine("Welcome to the temperature converter.");
            Console.WriteLine("\n\nPlease Select an option");
            Console.WriteLine("1. fahrenheit to celsius");
            Console.WriteLine("2. celsius to fahrenheit");

            //capture the inputted value
            optSel = Convert.ToByte(Console.ReadLine());


            //this currently does not work
            //error handling
            /*while (optSel != 1 || optSel != 2)
            {
                Console.WriteLine("Invalid selection, please select only 1 or 2: ");
                optSel = Convert.ToByte(Console.ReadLine());

                if (optSel == 1 || optSel == 2)
                    break;
            }
            */
            //display the selected option
            Console.WriteLine($"Your Selection is {optSel}");

            if (optSel == 1)
            {
                Console.WriteLine("Please input the temperature in fahrenheit: ");

                //capture the temp
                fahrenheit = Convert.ToDouble(Console.ReadLine());
                
                //assign the returned value from the method temperatureConversion to celsius
                celsius = temperatureConversion(optSel, fahrenheit);

                //write to console the value of fahrenheit to two decimal places
                Console.Write(fahrenheit.ToString("0.##"));
                Console.Write(" fahrenheit is ");

                //write to the console the value of celsius to two decimal places
                Console.Write(celsius.ToString("0.##"));
                Console.WriteLine(" celsius.");
            }
            else
            {
                Console.WriteLine("Please input the temperature in celsius: ");

                //capture the temp
                celsius = Convert.ToDouble(Console.ReadLine());

                //assign the returned value from the method temperatureConversion to fahrenheit
                fahrenheit = temperatureConversion(optSel, celsius);

                //write to the console the value of celsius to two decimal places
                Console.Write(celsius.ToString("0.##"));
                Console.Write(" celsius is ");

                //write to console the value of fahrenheit to two decimal places
                Console.Write(fahrenheit.ToString("0.##"));
                Console.WriteLine(" fahrenheit.");
            }



        }
    }
}
