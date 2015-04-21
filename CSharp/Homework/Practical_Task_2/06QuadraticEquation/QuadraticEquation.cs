using System;
//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots). Examples:
//a b C roots
//2 5 -3 x1=-3; x2=0.5
//-0.5 4 -8 x1=x2=4

class QuadraticEquation
{
    static void Main()
    {
        Console.Title = "Quadratic Equation";
        Console.Write("Enter a number a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter a number b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter a number c: ");
        double c = double.Parse(Console.ReadLine());
        double d = b * b - (4 * a * c);
        //Console.WriteLine("d = {0}", d);
        if (d < 0)
        {
            Console.WriteLine("There are no real roots");
        }
        else if (d == 0)
        {
            double x = (-1 * b) / (2 * a);
            Console.WriteLine("x = {0}", x);
        }
        else
        {
            double x1 = ((-1 * b) + Math.Sqrt(d)) / (2 * a);
            double x2 = ((-1 * b) - Math.Sqrt(d)) / (2 * a);
            Console.WriteLine("x1 = {0}", x1);
            Console.WriteLine("x2= {0}", x2);
        }
    }
}
