using System;

class SimpleLoop
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number N: ");
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <=number; i++)
        {
            Console.WriteLine(i);
        }
    }
}
