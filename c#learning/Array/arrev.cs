using System;

namespace csharplearning
{
    class arrarevs
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

           
            Console.WriteLine("\nArray in reverse order:");
            for (int i = n - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}