﻿using System;

class SortNumbers
{

    static int[] Sort(params int[] numbers)
    {
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[i] > numbers[j])
                {
                    int oldNum = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = oldNum;
                }

            }
        }
        return numbers;
    }
    static void PrintNumbers(params int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("{0}", numbers[i]);
            if (i < (numbers.Length - 1))
            {
                Console.Write(", ");
            }
        }
    }
    static void Main()
    {
        int[] numbers = Sort(100, 300, 45, -10, 0, -12, 8);
        PrintNumbers(numbers);
        Console.WriteLine();
    }
}