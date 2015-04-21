using System;

//Create a console application that calculates and prdoubles the square root of the number 12345. Find in doubleernet “how to calculate square root in C#”.


    class SquareRoot
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            double result = Math.Sqrt(number);
            Console.WriteLine(result);
        }
    }

