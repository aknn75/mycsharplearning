using System;

namespace csharplearn
{
    class diss
    {
        static void Main()
        {
            double amount, discount, finalAmount;

            Console.Write("Enter total amount : ");
            amount =double.Parse(Console.ReadLine());

            if (amount >= 10000)
            {
                discount = amount * 0.20;
            }
            else if (amount >= 5000)
            {
                discount = amount * 0.10;
            }
            else if (amount >= 2000)
            {
                discount = amount * 0.05;
            }
            else
            {
                discount = 0;
            }

            finalAmount = amount - discount;

            Console.WriteLine("Discount = " + discount);
            Console.WriteLine("Final Amount = " + finalAmount);
        }
    }
}