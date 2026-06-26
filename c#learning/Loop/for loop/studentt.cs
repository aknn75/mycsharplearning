using System;

namespace csharplearn
{
    class StusentMarks
    {
        static void Main()
        {
            int students, subjects;

            Console.Write("Enter number of students : ");
            students = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number of subjects : ");
            subjects = Convert.ToInt32(Console.ReadLine());

            int[] id = new int[students];
            int[,] marks = new int[students, subjects];

            for (int i = 0; i < students; i++)
            {
                Console.Write("\nEnter Student ID : ");
                id[i] = Convert.ToInt32(Console.ReadLine());

                for (int j = 0; j < subjects; j++)
                {
                    Console.Write("Enter marks of Subject " + (j + 1) + " : ");
                    marks[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int searchId;
            bool found = false;

            Console.Write("\nEnter Student ID to search : ");
            searchId = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < students; i++)
            {
                if (id[i] == searchId)
                {
                    Console.WriteLine("\nStudent ID : " + id[i]);

                    for (int j = 0; j < subjects; j++)
                    {
                        Console.WriteLine("Subject " + (j + 1) + " : " + marks[i, j]);
                    }

                    found = true;
                    break;
                }
            }

            if (found == false)
            {
                Console.WriteLine("Student ID not found.");
            }
        }
    }
}
