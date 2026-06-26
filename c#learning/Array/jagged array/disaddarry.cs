using System;

namespace csharplearning
{
    class jaggedarray
    {
        static void Main()
        {
            int n;

            Console.Write("Enter number of rows: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[][] arr = new int[n][];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter number of elements in row " + (i + 1) + ": ");
                int size = Convert.ToInt32(Console.ReadLine());

                arr[i] = new int[size];

                for (int j = 0; j < size; j++)
                {
                    Console.Write("Enter element [" + i + "," + j + "]: ");
                    arr[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Jagged Array:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}