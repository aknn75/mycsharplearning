using System;

namespace csharplearning
{
    class Person
    {
        public string name;

        public void getPerson()
        {
            Console.Write("Enter name: ");
            name = Console.ReadLine();
        }

        public void displayPerson()
        {
            Console.WriteLine("Name: " + name);
        }
    }

    class Student : Person
    {
        public int rollNo;

        public void getStudent()
        {
            Console.Write("Enter roll number: ");
            rollNo = Convert.ToInt32(Console.ReadLine());
        }

        public void displayStudent()
        {
            Console.WriteLine("Roll No: " + rollNo);
        }
    }

    interface ISports
    {
        void getSportsMarks();
        void displaySportsMarks();
    }

    class SportsStudent : Student, ISports
    {
        int sportsMarks;

        public void getSportsMarks()
        {
            Console.Write("Enter sports marks: ");
            sportsMarks = Convert.ToInt32(Console.ReadLine());
        }

        public void displaySportsMarks()
        {
            Console.WriteLine("Sports Marks: " + sportsMarks);
        }
    }

    class Program
    {
        static void Main()
        {
            SportsStudent s = new SportsStudent();

            s.getPerson();
            s.getStudent();
            s.getSportsMarks();

            Console.WriteLine("\n--- DETAILS ---");

            s.displayPerson();
            s.displayStudent();
            s.displaySportsMarks();
        }
    }
}