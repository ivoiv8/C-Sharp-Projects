// 08. Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.

using System;

class PrintNumbersFrom1ToN
{
    static void Main()
    {
        Console.Write("Please enter the last number you want to print, starting from 1: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}