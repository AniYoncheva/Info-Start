using System;
//You are given n integers (given in a single line, separated by a space). Write a program that checks whether the product of the odd elements is equal to the product of the even elements. Elements are counted from 1 to n, so the first element is odd, the second is even, etc. Examples:
//numbers result
//2 1 1 6 3     yes product = 6
//3 10 4 6 5 1  yes product = 60
//4 3 2 5 2     no  odd_product = 16 even_product = 15

class OddAndEven
{
    static void Main()
    {
        Console.Write("Enter n integers: ");
        string input = Console.ReadLine();
        string[] splitedNumbers = input.Split(' ');
        int oddProduct = 1;
        int evenProduct = 1;

        for (int i = 0; i < splitedNumbers.Length; i++)
        {
            int tempNumber = int.Parse(splitedNumbers[i]);
            bool isOdd = (i + 1) % 2 != 0;
            bool isEven = (i + 1) % 2 == 0;

            if (isOdd)
            {
                oddProduct *= tempNumber;
            }
            if (isEven)
            {
                evenProduct *= tempNumber;
            }
        }
        if (oddProduct == evenProduct)
        {
            Console.WriteLine("yes");
            Console.WriteLine("The product is {0}", oddProduct);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("Odd product is {0}", oddProduct);
            Console.WriteLine("Even product is {0}", evenProduct);
        }

    }
}