using System;

namespace csharplearn
{
    class tryside
    {
        static void Main()
        {
            int a, b, c;

            Console.Write("Enter side 1 : ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Enter side 2 : ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Enter side 3 : ");
            c = int.Parse(Console.ReadLine());

            if (a == b && b == c)
            {
                Console.WriteLine("Equilateral Triangle");
            }
            else if (a == b || b == c || a == c)
            {
                Console.WriteLine("Isosceles Triangle");
            }
            else
            {
                Console.WriteLine("Scalene Triangle");
            }
        }
    }
}