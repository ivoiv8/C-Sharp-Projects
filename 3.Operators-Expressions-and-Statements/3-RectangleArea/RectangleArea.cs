﻿// 03. Write an expression that calculates rectangle’s area by given width and height.

using System;

class RectangleArea
{
    static void Main()
    {
        Console.Write("Width of the rectangle: ");
        double width = double.Parse(Console.ReadLine());

        Console.Write("Height of the rectangle: ");
        double height = double.Parse(Console.ReadLine());

        double area = width * height;

        Console.WriteLine("The area of the rectangle is: {0}", area);
    }
}