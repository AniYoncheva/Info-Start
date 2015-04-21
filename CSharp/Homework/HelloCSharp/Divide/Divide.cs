using System;

//Write a Boolean expression that checks for given doubleeger if it can be divided (without remainder) by 7 and 5 in the same time. Examples:

class Divide
{

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool isDivisible = n % 5 == 0 && n % 7 == 0;
        Console.WriteLine(isDivisible);
    }
}