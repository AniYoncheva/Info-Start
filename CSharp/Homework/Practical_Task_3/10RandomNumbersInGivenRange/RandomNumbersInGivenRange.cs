using System;
//Write a program that enters 3 integers n, min and max (min ≤ max) and prints n random numbers in the range [min...max]. Examples:
//n min max random numbers
//5  0  1    1 0 0 1 1
//10 10 15   12 14 12 15 10 12 14 13 13 11


class RandomNumbersInGivenRange
{
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter min: ");
        int min = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter max: ");
        int max = int.Parse(Console.ReadLine());

        if (min > max)
        {
            Console.WriteLine("Invalid input!");
            return;
        }
        else
        {
            Random num = new Random();
            for (int i = 0; i < number; i++)
            {
                Console.Write(num.Next(min, max + 1) + " ");
            }
        }
        Console.WriteLine();
    }
}

