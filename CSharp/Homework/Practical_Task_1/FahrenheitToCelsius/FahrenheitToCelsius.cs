using System;
using System.Collections.Generic;
using System.Text;

//Rewrite “Feet to Inches” example in such way that to transform Fahrenheit to Celsius temperature. 

class FahrenheitToCelsius
{
    static void Main()
    {
        Console.Title = "Fahrenheit and Celsius Converter";
        System.Console.WriteLine("Fahrenheit and Celsius Converter");
        {
            Console.Write("Enter a temperature: ");
            string input = Console.ReadLine();
            double val = Convert.ToDouble(input);
            double Celsius = (val - 32.0) * 5.0 / 9.0;
            double Fahrenheit = (val * (9.0 / 5.0) + 32);

            Console.WriteLine("{0} °F = {1} °C", val.ToString("F02"), Celsius.ToString("F02"));
            Console.WriteLine("{0} °C = {1} °F", val.ToString("F02"), Fahrenheit.ToString("F02"));
        }

    }

}
