using System;

namespace csharplearn
{
    class bounss
    {
        static void Main()
        {
            int salary, year, bonus;

            Console.Write("Enter salary : ");
            salary = int.Parse(Console.ReadLine());

            Console.Write("Enter years of service : ");
            year = int.Parse(Console.ReadLine());

            if (year >= 5)
            {
                if (salary < 10000)
                {
                    bonus = salary + 1000;
                }
                else if (salary <= 20000)
                {
                    bonus = salary + 2000;
                }
                else
                {
                    bonus = salary + 500;
                }

                Console.WriteLine("Bonus = " + bonus);
            }
            else
            {
                Console.WriteLine("No Bonus");
            }
        }
    }
}