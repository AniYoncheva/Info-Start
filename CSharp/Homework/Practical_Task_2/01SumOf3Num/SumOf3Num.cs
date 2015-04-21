using System;
//Write a program that reads 3 real numbers from the console and prints their sum. Examples:
//a b C sum
//3 4 11 18
//-2 0 3 1
//5.5 4.5 20.1 30.1

class SumOf3Num
{
    static void Main()
    {
        Console.Title = "Sum of 3 numbers";
        Console.Write("Enter a number a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter a number b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter a number c: ");
        double c = double.Parse(Console.ReadLine());

        double sum = a + b + c;
        Console.WriteLine("Their sum is {0}: ", sum);

    }
}

