using System;

namespace csharplearn
{
    class factr
    {
        static void Main()
        {
            int num;
            long fact = 1;

            Console.Write("Enter a number to find factorial : ");
            num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }

            Console.WriteLine("Factorial of " +num+ " is " + fact);
        }
    }
}