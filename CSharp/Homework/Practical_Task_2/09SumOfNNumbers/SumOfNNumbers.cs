using System;
//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note that you may need to use a for-loop. Examples:
//numbers sum numbers sum numbers sum
//3 20 60 10 90

    class SumOfNNumbers
    {
        static void Main()
        {
            Console.Title = "Sum of N numbers";
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum+= double.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
    }
