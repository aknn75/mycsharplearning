using System;

namespace csharplearm
{
    class cricker
    {
        static void Main()
        {
            int balls, runs, total = 0;

            Console.Write("Enter number of balls : ");
            balls = int.Parse(Console.ReadLine());

            for (int i = 1; i <= balls; i++)
            {
                Console.Write("Enter runs scored on ball " + i + " : ");
                runs = int.Parse(Console.ReadLine());

                total = total + runs;
            }

            Console.WriteLine("Total Score = " + total);
        }
    }
}