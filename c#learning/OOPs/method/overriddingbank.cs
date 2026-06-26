using System;

namespace csharplearning
{
    class Bank
    {
        public virtual void interest()
        {
            Console.WriteLine("Bank interest is default 4%");
        }
    }

    class SBI : Bank
    {
        public override void interest()
        {
            Console.WriteLine("SBI interest = 6%");
        }
    }

    class ICICI : Bank
    {
        public override void interest()
        {
            Console.WriteLine("ICICI interest = 7%");
        }
    }

    class Program
    {
        static void Main()
        {
            Bank b;

            b = new SBI();
            b.interest();

            b = new ICICI();
            b.interest();
        }
    }
}