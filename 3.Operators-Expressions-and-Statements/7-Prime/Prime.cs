// 07. Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.

using System;

class Prime
{
    static void Main()
    {
        Console.Write("Please enter positive integer number ≤ 100: ");
        byte enteredNumber = byte.Parse(Console.ReadLine());


        if (enteredNumber <= 100)
        {
            byte number = enteredNumber;

            bool isPrime = true;

            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine("The number {0} is prime", number);
            }

            else
            {
                Console.WriteLine("The number {0} is not prime", number);
            }
        }
        else
        {
            Console.WriteLine("You entered an invalid number");
            
        }

       
    }
}