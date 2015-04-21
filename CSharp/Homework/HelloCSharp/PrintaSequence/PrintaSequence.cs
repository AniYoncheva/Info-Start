using System;

//Write a program that prdoubles the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

    class PrdoubleaSequence
    {
        static void Main()
        {
            for (int i = 2; i <= 11; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i+",");
                }
                else
                {
                    Console.Write(-i+ "," );
                }
            }
            Console.WriteLine();
        }
    }

