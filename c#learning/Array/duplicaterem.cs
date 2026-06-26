using System;

namespace csharplearning
{
    class removeduplicate
    {
        static void Main()
        {
            int n;

            Console.Write("Enter number of elements: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Enter element " + i + ": ");
                arr[i - 1] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Array after removing duplicates:");

            for (int i = 0; i < n; i++)
            {
                int j;

                for (j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        break;
                    }
                }

                if (i == j)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}