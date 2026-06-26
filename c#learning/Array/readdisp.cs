using System;

namespace csharplearning
{
    class arrredis
    {
        static void Main()
        {
            int n;

            Console.Write("Enter number of elements: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter element " + (i + 1) + ": ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nArray elements are:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}