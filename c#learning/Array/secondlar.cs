using System;

namespace csharplearning
{
    class secondlargest
    {
        static void Main()
        {
          
            int[] arr = {13, 45, 55, 33, 45};
            int n = arr.Length;

            
            int first = int.MinValue;
            int second = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] > first)
                {
                    second = first;
                    first = arr[i];
                }
                else if (arr[i] > second && arr[i] != first)
                {
                    second = arr[i];
                }
            }

            Console.WriteLine(second);
        }
    }
}