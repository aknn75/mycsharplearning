using System;

namespace csharplearning
{
    class calculator
    {
        public void add(int a, int b)
        {
            Console.WriteLine("Addition = " + (a + b));
        }

        public void add(int a, int b, int c)
        {
            Console.WriteLine("Addition = " + (a + b + c));
        }

        public void add(double a, double b)
        {
            Console.WriteLine("Addition = " + (a + b));
        }
    }

    class Program
    {
        static void Main()
        {
            calculator c = new calculator();

            c.add(10, 20);
            c.add(10, 20, 30);
            c.add(10.5, 20.5);
        }
    }
}