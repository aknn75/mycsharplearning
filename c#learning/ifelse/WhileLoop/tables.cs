using System;

namespace csharplearning
{
    class table
    {
        static void Main()
        {
            int n, i = 1;

            Console.Write("Enter a number: ");
            n = Convert.ToInt32(Console.ReadLine());

            while (i <= 10)
            {
                Console.WriteLine(n + " x " + i + " = " + (n * i));
                i++;
            }
        }
    }
}