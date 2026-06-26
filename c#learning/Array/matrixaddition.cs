using System;

namespace csharplearning
{
    class matrixaddition
    {
        static void Main()
        {
            int[,] a =
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int[,] b =
            {
                { 2, 8, 4 },
                { 6, 5, 5 },
                { 3, 7, 9 }
            };

            int[,] c = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                }
            }

            Console.WriteLine("Result Matrix:");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(c[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}