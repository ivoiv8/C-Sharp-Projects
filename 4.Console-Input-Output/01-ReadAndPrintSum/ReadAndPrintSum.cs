// 01. Write a program that reads 3 integer numbers from the console and prints their sum.

using System;

class ReadAndPrintSum
{
    static void Main()
    {
        Console.Write("Please enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Please enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.Write("Please enter third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());

        long sum = firstNumber + secondNumber + thirdNumber;

        Console.WriteLine("The sum of the three numbers is: {0}", sum);
    }
}