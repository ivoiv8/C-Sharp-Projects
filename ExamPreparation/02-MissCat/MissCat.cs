using System;
using System.Linq;


class MissCat
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] cats = new int[10];
        int vote;

        for (int i = 0; i < N; i++)
        {
            vote = int.Parse(Console.ReadLine());
            cats[vote - 1]++;
        }
        int winner = Array.IndexOf(cats, cats.Max()) + 1;

        Console.WriteLine(winner);
    }
}
