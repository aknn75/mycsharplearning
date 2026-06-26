using System;

namespace csharplearning
{
    class Vehicle
    {
        public string brand;
        public int speed;

        public void getVehicleDetails()
        {
            Console.Write("Enter brand: ");
            brand = Console.ReadLine();

            Console.Write("Enter speed: ");
            speed = Convert.ToInt32(Console.ReadLine());
        }

        public virtual void display()
        {
            Console.WriteLine("Brand = " + brand);
            Console.WriteLine("Speed = " + speed);
        }
    }

    class Car : Vehicle
    {
        public int seats;

        public void getCarDetails()
        {
            Console.Write("Enter number of seats: ");
            seats = Convert.ToInt32(Console.ReadLine());
        }

        public override void display()
        {
            Console.WriteLine("Brand = " + brand);
            Console.WriteLine("Speed = " + speed);
            Console.WriteLine("Seats = " + seats);
        }
    }

    class program
    {
        static void Main()
        {
            Car c = new Car();

            c.getVehicleDetails();
            c.getCarDetails();

            c.display();
        }
    }
}