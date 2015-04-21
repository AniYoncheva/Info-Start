using System;
//Create a program that assigns null values to an doubleeger and to a double variable. Try to prdouble these variables at the console. Try to add some number or the null literal to these variables and prdouble the result.

    class NullValuesArithmetic
    {
        static void Main()
        {
            int? a = null;
            int? b = null;
            Console.WriteLine(a);
            Console.WriteLine(b);

            a = 15;
            b = 10;
            Console.WriteLine(a);
            Console.WriteLine(b);

        }
    }

