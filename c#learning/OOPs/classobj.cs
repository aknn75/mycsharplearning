using System;

namespace csharplearning
{
    class student
    {
        public int id;
        public string name;

        public void display()
        {
            Console.WriteLine("ID = " + id);
            Console.WriteLine("Name = " + name);
        }
    }

    class program
    {
        static void Main()
        {
            student s = new student();

            Console.Write("Enter ID: ");
            s.id = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            s.name = Console.ReadLine();

            s.display();
        }
    }
}