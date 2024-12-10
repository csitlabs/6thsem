using System;

namespace Practical1Question9
{
    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal makes a sound.");
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog barks.");
        }
    }

    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Cat meows.");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Practical 1, Question 9\n");
            
            // Creating instances of Animal, Dog, and Cat
            Animal animal1 = new Dog();
            Animal animal2 = new Cat();
            Animal animal3 = new Animal();

            Console.WriteLine("Using Method Overriding:");
            animal1.Speak();   // Calls Dog's Speak method
            animal2.Speak();   // Calls Cat's Speak method
            animal3.Speak();   // Calls Animal's Speak method

            Console.WriteLine("\n---------- \nName: Bimochan Poudel \nClass Roll: 21-00031-5 (20780638) \nTU Roll: 28555/078");

            Console.ReadLine();
        }
    }
}
