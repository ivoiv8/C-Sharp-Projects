﻿// 07. Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 

using System;

class NSum
{
    static void Main()
    {
        Console.Write("Please enter how many numbers do you want to get: ");
        int n = int.Parse(Console.ReadLine());

        long sum = 0;

        Console.WriteLine("Please enter {0} numbers:", n);

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());

            sum += number;
        }

        Console.WriteLine("The sum of the {0} numbers is {1}: ", n, sum);
    }
}