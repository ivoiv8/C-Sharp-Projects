// 2. Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?

using System;

class FloatAndDouble
{
    static void Main()
    {
        // FLOAT can contain real numbers that have up to 7 digits
        // DOUBLE can contain real numbers that have up to 15 - 16 digits

        double number1 = 34.567839023d;
        float number2 = 12.345f;
        double number3 = 8923.1234857f;
        float number4 = 3456.091f;

        Console.WriteLine("DOUBLE nubers: {0} & {1}", number1, number3);
        Console.WriteLine("FLOAT nubers: {0} & {1}", number2, number4);
    }
}