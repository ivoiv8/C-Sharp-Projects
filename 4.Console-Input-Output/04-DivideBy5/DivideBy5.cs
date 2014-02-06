// 04. Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.

using System;

class DivideBy5
{
    static void Main()
    {
        Console.Write("First number (a): ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Second number (b): ");
        int b = int.Parse(Console.ReadLine());

        int count = 0;

        if (a < b)
        {
            for (int i = a; i <= b; i++)
            {
                if (i % 5 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("The number count is: {0}", count);
        }
        else
        {
            for (int i = b; i <= a; i++)
            {
                if (i % 5 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("The number count is: {0}", count);
        }
    }
}