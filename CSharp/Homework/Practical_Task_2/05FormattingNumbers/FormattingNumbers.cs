using System;

//Write a program that reads 3 numbers: an integer a (0 ≤ a ≤ 500), a floating-point b and a floating-point c and prints them in 4 virtual columns on the console. Each column should have a width of 10 characters. The number a should be printed in hexadecimal, left aligned; then the number a should be printed in binary form, padded with zeroes, then the number b should be printed with 2 digits after the decimal point, right aligned; the number c should be printed with 3 digits after the decimal point, left aligned. Examples:
//a B c result
//254 - 11.6 - 0.5 - |FE |0011111110| 11.60|0.500 |

    class FormattingNumbers
    {
        static void Main()
        {
            Console.Title = "Formatting numbers";
            Console.Write("Enter a number a:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter a number b:");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter a number c:");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("|{0}|{1,10}|{2,10:F2}|{3,-10:F3}|", (a.ToString("X").PadRight(10,' ')),(Convert.ToString(a,2).PadLeft(10,'0')), b, c);

        }
    }

