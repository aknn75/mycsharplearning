using System;

namespace csharplearning
{
    class studentmarks
    {
        static void Main()
        {
            int students;

            Console.Write("Enter number of students: ");
            students = Convert.ToInt32(Console.ReadLine());

            int[][] marks = new int[students][];

            for (int i = 0; i < students; i++)
            {
                Console.Write("Enter number of subjects for student " + (i + 1) + ": ");
                int subjects = Convert.ToInt32(Console.ReadLine());

                marks[i] = new int[subjects];

                for (int j = 0; j < subjects; j++)
                {
                    Console.Write("Enter marks for subject " + (j + 1) + ": ");
                    marks[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Student Marks:");

            for (int i = 0; i < students; i++)
            {
                Console.Write("Student " + (i + 1) + ": ");

                for (int j = 0; j < marks[i].Length; j++)
                {
                    Console.Write(marks[i][j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}