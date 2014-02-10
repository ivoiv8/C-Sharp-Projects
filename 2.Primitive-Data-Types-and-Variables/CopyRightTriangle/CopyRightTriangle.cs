// 9. Write a program that prints an isosceles triangle of 9 copyright symbols ©. 
// Use Windows Character Map to find the Unicode code of the © symbol. Note: the © symbol may be displayed incorrectly.

using System;
using System.Text; // We must use this library so we can use the ENCODING property

class CopyRightTriangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;

        char copyRightSign = (char)(0x00A9);
        int numberOfSymbolsOnRow = 1;

        for (int i = 2; i >= 0; i--)
        {
            Console.WriteLine(new string(' ', i) + new string(copyRightSign, numberOfSymbolsOnRow) + new string(' ', i));

            numberOfSymbolsOnRow += 2;
        }
    }
}