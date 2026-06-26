using System;

namespace csharplearning
{
    class Shape
    {
        public virtual void area()
        {
            Console.WriteLine("Calculate area");
        }
    }

    class Circle : Shape
    {
        public double r;

        public void getData()
        {
            Console.Write("Enter radius: ");
            r = Convert.ToDouble(Console.ReadLine());
        }

        public override void area()
        {
            Console.WriteLine("Circle Area = " + (3.14 * r * r));
        }
    }

    class Rectangle : Shape
    {
        public double l, b;

        public void getData()
        {
            Console.Write("Enter length: ");
            l = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter breadth: ");
            b = Convert.ToDouble(Console.ReadLine());
        }

        public override void area()
        {
            Console.WriteLine("Rectangle Area = " + (l * b));
        }
    }

    class program
    {
        static void Main()
        {
            Shape s;

            Circle c = new Circle();
            c.getData();

            Rectangle r = new Rectangle();
            r.getData();

            s = c;
            s.area();

            s = r;
            s.area();
        }
    }
}