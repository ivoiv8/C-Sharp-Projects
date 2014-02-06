// 01. Write an if statement that examines two integer variables and 
// exchanges their values if the first one is greater than the second one.

using System;

class ExchangeValueIfGreater
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter anotrher number:");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Original values: a={0}; b={1}", a, b);

        int c;

        if (a > b)
        {
            c = a;
            a = b;
            b = c;

            Console.WriteLine("Values of numbers after check and exchange: a={0}; b={1}", a, b);
        }
        else
            Console.WriteLine("Numbers will not be exchanged");
    }
}
