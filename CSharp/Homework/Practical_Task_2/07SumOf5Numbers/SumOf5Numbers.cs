using System;
//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum. Examples:
//numbers sum numbers sum numbers sum
//1 2 3 4 5 15; 10 10 10 10 10 50; 1.5 3.14 8.2 -1 0 11.84

    class SumOf5Numbers
    {
        static void Main()
        {
            Console.Title = "Sum of 5 numbers";
            Console.Write("Enter five numbers: ");
            string[] numbers = Console.ReadLine().Split(' ');
            double a = double.Parse(numbers[0]);
            double b = double.Parse(numbers[1]);
            double c = double.Parse(numbers[2]);
            double d = double.Parse(numbers[3]);
            double e = double.Parse(numbers[4]);
            Console.WriteLine(a+b+c+d+e);
        }
    }
