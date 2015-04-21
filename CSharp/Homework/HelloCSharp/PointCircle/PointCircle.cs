using System;
//Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2). Examples:
//x	y	inside
//0	1	true
//-2	0	true
//-1	2	false
//1.5	-1	true
//-1.5	-1.5	false
//100	-30	false
//0	0	true
//0.2	-0.8	true
//0.9	-1.93	false

    class PointCircle
    {
        static void Main()
        {
            Console.Write("enter x:");
            double x = double.Parse(Console.ReadLine());
            Console.Write("enter y:");
            double y = double.Parse(Console.ReadLine());
            bool isCircle = (((x * x) + (y * y)) <= 1.5 * 1.5);
            Console.WriteLine(isCircle);
        }
    }
