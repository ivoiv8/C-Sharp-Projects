// 12. We are given integer number n, value v (v=0 or 1) and a position p. Write a sequence of operators that modifies n to hold the value v at the position p from the binary representation of n.
//           Example: n = 5 (00000101), p=3, v=1  13 (00001101)
//           n = 5 (00000101), p=2, v=0  1 (00000001)

using System;

class BitChange
{
    static void Main()
    {
        Console.Write("Please enter number: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Please enter bit value: ");
        int bitValue = int.Parse(Console.ReadLine());

        Console.Write("Please enter position: ");
        int position = int.Parse(Console.ReadLine());

        if (bitValue == 1)
        {
            number |= (1 << position);
        }
        else
        {
            number = (~(1 << position) & number);
        }

        Console.WriteLine("The number you entered after modifying is {0}", number);
    }
}