using System;
//Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line. Note that you may need to use a for-loop. Examples:
//numbers sum numbers sum
//3 1 2 3 5 1 2 3 4 5 1 1


class Numbers1ToN
{
    static void Main()
    {
        Console.Title = "Numbers 1 to N";
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}
