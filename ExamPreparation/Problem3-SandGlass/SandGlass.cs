using System;

class SandGlass
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            int astCount = N;
            int dotCount = 0;

            for (int i = 0; i < N; i++)
            {
                string drawDots = new string('.', dotCount);
                string drawAstr = new string('*', astCount);

                Console.WriteLine(drawDots + drawAstr + drawDots);
                dotCount++;

                if (astCount == 1)
                {
                    break;
                }
                astCount -= 2;
            }

            dotCount -= 2;
            astCount += 2;

            for (int i = 0; i < N; i++)
            {
                string drawDots = new string('.', dotCount);
                string drawAstr = new string('*', astCount);

                Console.WriteLine(drawDots + drawAstr + drawDots);
                dotCount--;
                if (astCount == N)
                {
                    break;
                }
                astCount += 2;
            }
        }
    }