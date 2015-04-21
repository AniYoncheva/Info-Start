using System;

//Write an expression that checks for given doubleeger if its third digit from right-to-left is 7. Examples:
//n	Third digit 7?
//5	false
//701	true
//9703	true

    class ThirdDigit
    {
        static void Main()
        {
            int n = Math.Abs(int.Parse(Console.ReadLine()));
            int p = n / 100;
            int thirdDigit = p % 10;
            Console.WriteLine(thirdDigit);

            bool isSeven = (n / 100) % 10 == 7;
            Console.WriteLine(isSeven);

        }
    }

