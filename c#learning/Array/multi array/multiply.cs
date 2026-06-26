using System;

namespace csharplearning
{
    class matrixmultiplication
    {
        static void Main()
        {
            int[,] a = new int[3, 3];
            int[,] b = new int[3, 3];
            int[,] c = new int[3, 3];

            Console.WriteLine("Enter elements of Matrix A:");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("A[" + i + "," + j + "] = ");
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Enter elements of Matrix B:");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("B[" + i + "," + j + "] = ");
                    b[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    c[i, j] = 0;

                    for (int k = 0; k < 3; k++)
                    {
                        c[i, j] = c[i, j] + a[i, k] * b[k, j];
                    }
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