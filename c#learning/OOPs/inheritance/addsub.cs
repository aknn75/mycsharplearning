using System;

namespace csharplearning
{
    interface IAdd
    {
        void add(int a, int b);
    }

    interface ISubtract
    {
        void subtract(int a, int b);
    }

    class Calculator : IAdd, ISubtract
    {
        public void add(int a, int b)
        {
            Console.WriteLine("Addition = " + (a + b));
        }

        public void subtract(int a, int b)
        {
            Console.WriteLine("Subtraction = " + (a - b));
        }
    }

    class Program
    {
        static void Main()
        {
            Calculator c = new Calculator();

            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            c.add(a, b);
            c.subtract(a, b);
        }
    }
}