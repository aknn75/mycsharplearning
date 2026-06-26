using System;

namespace csharplearning
{
    class Animal
    {
        public virtual void sound()
        {
            Console.WriteLine("Animal makes sound");
        }
    }

    class Dog : Animal
    {
        public override void sound()
        {
            Console.WriteLine("Dog barks");
        }
    }

    class Cow : Animal
    {
        public override void sound()
        {
            Console.WriteLine(" Cow Moo");
        }
    }

    class program
    {
        static void Main()
        {
            Animal a;

            a = new Animal();
            a.sound();

            Animal d = new Dog();
            d.sound();

            Animal c = new Cow();
            c.sound();

        }
    }
}