using System;

namespace csharplearn
{
    class numb
    {
        static void Main()
        {
            Console.WriteLine("Enter till number to print");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Here are the number");

            for (int i=0; i<=n; i++)
            {
                
                Console.WriteLine(i);
            }
        }
    }
}