using System;

namespace csharplearning
{
    class largestmatrix
    {
        static void Main()
        {
            int[,] arr =
            {
                { 12, 45, 67 },
                { 89, 23, 10 },
                { 34, 99, 56 }
            };

            int large = arr[0, 0];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (arr[i, j] > large)
                    {
                        large = arr[i, j];
                    }
                }
            }

            Console.WriteLine("Largest element = " + large);
        }
    }
}

