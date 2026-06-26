using System;

namespace csharplearning
{
    class matrix
    {
        static void Main()
        {
            int r, c;

            Console.Write("Enter number of rows: ");
            r = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number of columns: ");
            c = Convert.ToInt32(Console.ReadLine());

            int[,] arr = new int[r, c];

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write("Enter element: ");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Matrix elements are:");

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}