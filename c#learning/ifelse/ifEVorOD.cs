using System;

namespace csharplearn
{
    class EvenOdd
    {
        static void Main()
        {
            int num;

            Console.Write("Enter a number : ");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("even Number");
            }
            else
            {
                Console.WriteLine("odd Number");
            }
        }
    }
}