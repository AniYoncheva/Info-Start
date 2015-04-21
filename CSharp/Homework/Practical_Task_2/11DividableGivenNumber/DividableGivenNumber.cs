using System;
//Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.
//start End p comments
//17 25 2 20, 25
//5 30 6 5, 10, 15, 20, 25, 30

    class DividableGivenNumber
    {
        static void Main()
        {
            Console.Title = "Division 5";
            Console.Write("Enter a number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter a number: ");
            int b = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = a; i <= b; i++)
            {
                if (i%5==0)
                {
                    count++;
                }
            }
            if (count>0)
            {
                Console.WriteLine(count);
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }

