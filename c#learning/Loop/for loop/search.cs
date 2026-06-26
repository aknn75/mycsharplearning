using System;

namespace csharplearn
{
    class searchh
    {
        static void Main()
        {
            int[] listt = { 10, 20, 30, 40, 50 };
            int ele;
            bool found = false;

            Console.Write("Enter element to search : ");
            ele = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < listt.Length; i++)
            {
                if (listt[i] == ele20)
                {
                    found = true;
                    break;
                }
            }

            if (found)
            {
                Console.WriteLine("Element Found");
            }
            else
            {
                Console.WriteLine("Element Not Found");
            }
        }
    }
}