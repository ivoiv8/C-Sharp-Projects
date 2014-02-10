// 12. Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints the entire ASCII table of characters on the console.

using System;
using System.Text;

class ASCIITable
{
    static void Main()
    {
        for (int c = 0; c < 255; c++)  // from 0 to 255 exclusive because there are 256 symbols in ASCII table
        {
            Console.WriteLine("Character: {0} = {1}", c, (char)c);
        }
    }
}