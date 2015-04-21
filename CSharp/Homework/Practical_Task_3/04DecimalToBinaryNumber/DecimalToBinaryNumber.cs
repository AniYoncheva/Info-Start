using System;

//Using loops write a program that converts an integer number to its binary representation. The input is entered as long. The output should be a variable of type string. Examples:
//decimal   binary
//0          0
//3          11
//43691      1010101010101011
//236476736  1110000110000101100101000000

class DecimalToBinaryNumber
{
    static void Main()
    {
        Console.Write("Decimal: ");
        string decimalNumber = Console.ReadLine();
        long num = long.Parse(decimalNumber);
        long remainder;
        string result = string.Empty;
        while (num > 0)
        {
            remainder = num % 2;
            num /= 2;
            result = remainder.ToString() + result;
        }
        Console.WriteLine("Binary: {0}", result);
    }
}

