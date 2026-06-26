using System;

namespace csharplearning
{
    class arrsear
    {
        static void Main()
        {
            int n, serch, flag = 0;

            Console.Write("Enter number of elements: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter element " + (i + 1) + ": ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter element to search: ");
            serch = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                if (arr[i] == serch)
                {
                    flag = 1;
                    break;
                }
            }

            if (flag == 1)
            {
                Console.WriteLine("Element exists");
            }
            else
            {
                Console.WriteLine("Element does not exist");
            }
        }
    }
}