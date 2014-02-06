// 02. Write a program that shows the sign (+ or -) of the product of 
// three real numbers without calculating it. Use a sequence of if statements.

using System;



class ProductSign
{
    static void Main()
    {
        Console.Write("Please enter the number count: ");
        int readCount = int.Parse(Console.ReadLine());
        int[] numberArray = new int[readCount];
        for (int index = 0; index < readCount; index++)
        {
            Console.Write("Number {0}: ", index + 1);
            numberArray[index] = int.Parse(Console.ReadLine());
        }


        int negativeCount = 0;
        int product = 1;
        bool zeroInArray = false;
        foreach (var number in numberArray)
        {
            if (number < 0)
            {
                negativeCount++;
            }
            product *= number;
            if (number == 0)
            {
                zeroInArray = true;
            }

        }
        if (zeroInArray)
        {
            Console.WriteLine("The product is ZERO!");
        }
        else
        {
            if (negativeCount % 2 == 0)
            {
                Console.WriteLine("The product IS POSITIVE!");
            }
            else
            {
                Console.WriteLine("The product is NEGATIVE!");
            }
        }


        Console.WriteLine("PRODUCT: {0}", product);
        Console.WriteLine("Negative Count: {0}", negativeCount);
    }
}