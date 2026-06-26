using System;

namespace csharplearning
{
    class Branches
    {
        int bcode;
        string bname, baddress;

        public void getdata()
        {
            Console.WriteLine("Enter branch code:");
            bcode = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter branch name:");
            bname = Console.ReadLine();

            Console.WriteLine("Enter branch address:");
            baddress = Console.ReadLine();
        }

        public void displaydata()
        {
            Console.WriteLine("Branch code is " + bcode);
            Console.WriteLine("Branch name is " + bname);
            Console.WriteLine("Branch address is " + baddress);
        }
    }

    class Employee : Branches
    {
        int empid, eage;
        string ename, eaddress;

        public void getempdata()
        {
            Console.WriteLine("Enter employee details:");

            Console.WriteLine("Enter employee ID:");
            empid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter employee age:");
            eage = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter employee name:");
            ename = Console.ReadLine();

            Console.WriteLine("Enter employee address:");
            eaddress = Console.ReadLine();
        }

        public void displayempdata()
        {
            Console.WriteLine("Employee ID is " + empid);
            Console.WriteLine("Employee age is " + eage);
            Console.WriteLine("Employee name is " + ename);
            Console.WriteLine("Employee address is " + eaddress);
        }
    }

    class Inheritance
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();

            e1.getdata();
            e1.getempdata();

            e1.displaydata();
            e1.displayempdata();
        }
    }
}