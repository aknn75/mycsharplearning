using System;

namespace csharplearning
{
    class area
    {
        public void calculate(int side)
        {
            Console.WriteLine("Square Area = " + (side * side));
        }

        public void calculate(int length, int breadth)
        {
            Console.WriteLine("Rectangle Area = " + (length * breadth));
        }

        public void calculate(double radius)
        {
            Console.WriteLine("Circle Area = " + (3.14 * radius * radius));
        }
    }

    class Program
    {
        static void Main()
        {
            area a = new area();

            a.calculate(5);
            a.calculate(10, 20);
            a.calculate(7.5);
        }
    }
}