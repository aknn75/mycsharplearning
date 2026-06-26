using System;

namespace csharplearning
{
    class marks
    {
        public int m1, m2, m3;

        public int total()
        {
            return m1 + m2 + m3;
        }
    }

    class program
    {
        static void Main()
        {
            marks m = new marks();

            Console.Write("Enter M 1: ");
            m.m1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter M 2: ");
            m.m2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter M 3: ");
            m.m3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Total = " + m.total());
        }
    }
}