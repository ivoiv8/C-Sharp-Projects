// 10. Write a boolean expression that returns if the bit at position p (counting from 0) in a given integer number v has value of 1. Example: v=5; p=1  false.

using System;

class BitPosition
{
    static void Main()

    {
        Console.Write("Please enter number: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Please enter on which position to determine the bit: ");
        int position = int.Parse(Console.ReadLine());

        bool isOne = ((number >> position) & 1) == 1;

        Console.WriteLine("Is the bit 1 -> {0}", isOne);
    }
}
