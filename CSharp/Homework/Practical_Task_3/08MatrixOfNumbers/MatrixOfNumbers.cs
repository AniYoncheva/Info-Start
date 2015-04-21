using System;
//Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops. Examples:
//n matrix   n matrix
//2  1 2     3 1 2 3 
//   2 3       2 3 4
//             3 4 5

class MatrixOfNumbers
{
    static void Main()
    {
        Console.Write("Enter positive number: ");
        string number = Console.ReadLine();
        int newNumber = int.Parse(number);
        if (newNumber < 1 || newNumber > 20)
        {
            Console.WriteLine("Error - Invalid Number !!!"); ;
        }
        else

            for (int i = 1; i <= newNumber; i++)
            {
                for (int j = i; j < newNumber + i; j++)
                {
                    Console.Write("{0} ", j);
                }
                Console.WriteLine();
            }
    }
}
