using System;

class Carpets
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int elementsOnline = n;
        int center = elementsOnline / 2;

        for (int i = 1; i <= n / 2; i++)
        {
            int elPos = 1;
            while (elPos <= elementsOnline)
            {
                if ((elPos <= center - i) || (elPos > center + i))
                {
                    Console.Write(".");
                }
                else
                {
                    Console.Write("/");
                }
                elPos++;
            }
            Console.WriteLine();
        }
        for (int i = n/2; i >= 1; i--)
        {
            int elPos = 1;
            while (elPos <= elementsOnline)
            {
                if ((elPos <= center - i) || (elPos > center + i))
                {
                    Console.Write(".");
                }
                else
                {
                    Console.Write("");
                }
                elPos++;
            }
            Console.WriteLine();
        }
    }
}
    