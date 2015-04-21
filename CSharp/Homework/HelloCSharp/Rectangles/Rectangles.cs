using System;

//Write an expression that calculates rectangle’s perimeter and area by given width and height. Examples:
//width	height	perimeter	area
//3	4	14	12
//2.5	3	11	7.5


    class Rectangles
    {
        static void Main()
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int perimeter = 2 * width + 2 * height;
            int area = width * height;
            Console.WriteLine("Perimeter: " + perimeter);
            Console.WriteLine("Area: " + area);
        }
    }

