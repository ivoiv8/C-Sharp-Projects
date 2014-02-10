// 11. Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.

using System;

class IntegerExchange
{
    static void Main()
    {
        // Using 3th variable
        int a = 5;
        int b = 10;
        int c;

        c = a;
        a = b;
        b = c;

        Console.WriteLine("Original Values:\na = 5\nb = 10");
        Console.WriteLine("New Values:\na = {0}\nb = {1}", a, b);
    }
}