using System;

namespace FinalTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[5, 5];

            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    a[i, j] = random.Next(100);

                }

            }

            for (int i = 0; i < 5; ++i)
            {
                for (int j = i + 1; j < 5; ++j)
                {
                    a[i,j] = 1;
                }
            }

            Console.ReadLine();
        }
    }
}
