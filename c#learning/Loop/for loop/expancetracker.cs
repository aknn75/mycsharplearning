using System;

namespace csharplearning
{
    class expense
    {
        static void Main()
        {
            int n, amount, total = 0;
            double average;

            Console.Write("Enter number of expenses: ");
            n =int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Enter expense " + i + ": ");
                amount = int.Parse(Console.ReadLine());

                total = total + amount;
            }

            average = (double)total / n;

            Console.WriteLine("\nTotal Monthly Expense = " + total);
            Console.WriteLine("Average Expense = " + average);
        }
    }
}