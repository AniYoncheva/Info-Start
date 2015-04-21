using System;
//Using loops write a program that converts an integer number to its hexadecimal representation. The input is entered as long. The output should be a variable of type string. Examples:
//decimal hexadecimal
//254            FE
//6883           1AE3
//338583669684   4ED528CBB4

class DecimalToHexadecimal
{
    static void Main()
    {
        Console.Write("Decimal: ");
        long dec = long.Parse(Console.ReadLine());
        string hex = "";
        do
        {
            switch (dec % 16)
            {
                case 10: hex = "A" + hex; break;
                case 11: hex = "B" + hex; break;
                case 12: hex = "C" + hex; break;
                case 13: hex = "D" + hex; break;
                case 14: hex = "E" + hex; break;
                case 15: hex = "F" + hex; break;
                default: hex = dec % 16 + hex; break;
            }
            dec = dec / 16;
        } while (dec > 0);
        Console.WriteLine("Hexadecimal: {0}", hex);
    }
}

