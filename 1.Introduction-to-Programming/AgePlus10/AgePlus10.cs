using System;
class AgePlus10
{
    static void Main()
    {
        Console.Write("My age now:");
        int Age = int.Parse(Console.ReadLine());
        Age += 10;
        Console.WriteLine("My age after ten years:" + Age);
    }
}
