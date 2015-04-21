using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class Program
    {
        static void Main()
        {
            int celsius, faren;
            Console.Write("Enter the Temperature in Celsius(°C) : ");
            celsius = int.Parse(Console.ReadLine());
            faren = (celsius * 9) / 5 + 32;
            Console.WriteLine("Temperature in Fahrenheit is: {0}(°F)", faren);
            Console.ReadLine();
        }
    }