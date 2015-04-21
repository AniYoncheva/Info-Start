using System;
//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point. Examples:
//r perimeter area
//2 12.57 12.57
//3.5 21.99 38.48

    class CirclePerimeterArea
    {
        static void Main()
        {
            Console.Title = "Circle Perimeter and Area";
            Console.Write("Enter the radius r:");
            double r = double.Parse(Console.ReadLine());
            double perimeter = 2 * Math.PI * r;
            double area = Math.PI * Math.Pow(r, 2);
            Console.WriteLine("Perimeter is: {0:F2} ", perimeter);
            Console.WriteLine("Area is: {0:F2}", area);
        }
    }

