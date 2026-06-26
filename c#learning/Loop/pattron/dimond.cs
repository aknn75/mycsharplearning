using System;

namespace csharplearn
{
    class pattornn
    {
        static void Main()
        {
            int n = 5;

            for (int r = 1; r <= n; r++)
            {
                
                for (int s = 1; s <= n - r; s++)
                {
                    Console.Write(" ");
                }

                for (int c = 1; c <= 2 * r - 1; c++)
                {
                    Console.Write("#");
                }

                Console.WriteLine();
            }

            for (int r = n-1; r>1; r--)
            {
                
                for (int s = 1; s <= n - r; s++)
                {
                    Console.Write(" ");
                }

                for (int c = 1; c <= 2 * r - 1; c++)
                {
                    Console.Write("#");
                }

                Console.WriteLine();
            }
        }
    }
}