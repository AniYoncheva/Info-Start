using System;
//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point). The input starts by the number n (alone in a line) followed by n lines, each holding an integer number. The output is like in the examples below. Examples:
//input output input output
//3 min = 1      2   min = -1
//2 max = 5     -1   max = 4
//5 sum = 8      4   sum = 3
//1 avg = 2.67       avg = 1.50

class MinMaxSumAverageOfNNumbers
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        int min = int.MaxValue;
        int max = int.MinValue;
        int sum = 0;
        for (int i = 0; i < number; i++)
        {
            Console.Write("Enter next: ");
            int n = int.Parse(Console.ReadLine());
            if (n < min)
            {
                min = n;
            }
            if (n > max)
            {
                max = n;
            }
            sum += n;
        }
        Console.WriteLine("min = {0}", min);
        Console.WriteLine("max = {0}", max);
        Console.WriteLine("sum = {0}", sum);

        double avg = (double)sum / number;
        Console.WriteLine("avg = {0:F2}", avg);
    }
}

