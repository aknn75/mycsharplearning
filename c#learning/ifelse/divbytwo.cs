using System;

namespace csharplearn
{
    class divbytwo
    {
        static void Main()
        {
            int num;

            Console.Write("Enter a num : ");
            num =int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Num is divisible by 2");
            }
            else
            {
                Console.WriteLine("Numb is not divisible by 2");
            }
        }
    }
}