using System;

namespace Practical1Question1
{
    // Class to demonstrate class, constructor, properties, and method
    class Person
    {
        // Properties
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor (Default Constructor)
        public Person()
        {
            Name = "Unknown";
            Age = 0;
        }

        // Constructor (Parameterized Constructor)
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Method to display person details
        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Header Information
            Console.WriteLine("Practical 1, Question 1\n");
            
            // Creating an instance of Person using default constructor
            Person person1 = new Person();
            Console.WriteLine("\nUsing Default Constructor:");
            person1.DisplayDetails();

            // Creating an instance of Person using parameterized constructor
            Person person2 = new Person("Alice", 25);
            Console.WriteLine("\nUsing Parameterized Constructor:");
            person2.DisplayDetails();

            Console.WriteLine("\n---------- \nName: Bimochan Poudel \nClass Roll: 21-00031-5 (20780638) \nTU Roll: 28555/078");

            Console.ReadLine();  // Wait for user input
        }
    }
}
