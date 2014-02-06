// 06. Write an expression that checks if given point (x,  y) is within a circle K(O, 5).

using System;

class WithinACircle
{
    static void Main()
    {
        Console.WriteLine("Please enter X & Y coordinates:");

        Console.Write("X: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Y: ");
        double y = double.Parse(Console.ReadLine());
        double circleRadius = 5;

        if ((x * x + y * y) <= (circleRadius * circleRadius))
        {
            Console.WriteLine("The given point IS within a circle with radius of 5");
        }
        else
        {
            Console.WriteLine("The given point IS NOT within a circle with radius of 5");
        }
    }
}