using System;

namespace csharplearning
{
    class matrixsum
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
                    Console.Write("Enter element [" + i + "," + j + "]: ");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Row-wise Sum");

            for (int i = 0; i < r; i++)
            {
                int sum = 0;

                for (int j = 0; j < c; j++)
                {
                    sum = sum + arr[i, j];
                }

                Console.WriteLine("Row " + (i + 1) + " = " + sum);
            }

            Console.WriteLine("Column-wise Sum");

            for (int j = 0; j < c; j++)
            {
                int sum = 0;

                for (int i = 0; i < r; i++)
                {
                    sum = sum + arr[i, j];
                }

                Console.WriteLine("Column " + (j + 1) + " = " + sum);
            }
        }
    }
}