using System;

namespace csharplearning
{
    class factorial
    {
        static void Main()
        {
            int n, i = 1;
            int fact = 1;

            Console.Write("Enter a number: ");
            n = Convert.ToInt32(Console.ReadLine());

            while (i <= n)
            {
                fact = fact * i;
                i++;
            }

            Console.WriteLine("Factorial = " + fact);
        }
    }
}