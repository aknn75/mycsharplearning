using System;

namespace csharplearn
{
    class rat
    {
        static void Main()
        {
            int rating;

            Console.Write("Enter performance rating (1 to 5) : ");
            rating =int.Parse(Console.ReadLine());

            if (rating == 5)
            {
                Console.WriteLine("Excellent");
                Console.WriteLine("Salary Hike : 20%");
            }
            else if (rating == 4)
            {
                Console.WriteLine("Very Good");
                Console.WriteLine("Salary Hike : 15%");
            }
            else if (rating == 3)
            {
                Console.WriteLine("Good");
                Console.WriteLine("Salary Hike : 10%");
            }
            else if (rating == 2)
            {
                Console.WriteLine("Average");
                Console.WriteLine("Salary Hike : 5%");
            }
            else if (rating == 1)
            {
                Console.WriteLine("Poor");
                Console.WriteLine("No Salary Hike");
            }
            else
            {
                Console.WriteLine("Invalid Rating");
            }
        }
    }
}