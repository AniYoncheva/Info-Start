using System;

class RecursiveFactorial
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        decimal factorial = Factorial(n);
        Console.WriteLine("{0}! = {1}", n, factorial);
    }
    static decimal Factorial(int n)
    {
        // The bottom of the recursion
        if (n == 0)
        {
            return 1;
        }
        // Recursive call: the method calls itself
        else
        {
            return n * Factorial(n - 1);
        }
    }
    //static decimal Factorial(int n)
    //{
    //    decimal result = 1;
    //    for (int i = 1; i <= n; i++)
    //    {
    //        result = result * i;
    //    }
    //    return result;
    //}
}