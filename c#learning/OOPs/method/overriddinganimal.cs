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

    class Cat : Animal
    {
        public override void sound()
        {
            Console.WriteLine("Cat meows");
        }
    }

    class Program
    {
        static void Main()
        {
            Animal a;

            a = new Dog();
            a.sound();

            a = new Cat();
            a.sound();
        }
    }
}