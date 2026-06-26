using System;

namespace csharplearn
{
    class numb
    {
        static void Main()
        {
            Console.WriteLine("Enter till number to print");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Here are the revers number");

            for (int i=n; i>=1; i--)
            {
                
                Console.WriteLine(i);
            }
        }
    }
}