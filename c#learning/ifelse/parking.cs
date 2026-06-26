using System;

namespace csharplearn
{
    class parkingg
    {
        static void Main()
        {
            int hours, fee;

            Console.Write("Enter parking hours : ");
            hours = int.Parse(Console.ReadLine());

            if (hours <= 2)
            {
                fee = 10;
            }
            else if (hours <= 5)
            {
                fee = 10 + (hours - 2) * 5;
            }
            else
            {
                fee = 25 + (hours - 5) * 10;
            }

            Console.WriteLine("Parking Fee = " + fee);
        }
    }
}