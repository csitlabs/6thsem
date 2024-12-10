using System;

namespace Practical1Question8
{
    class Person
    {
        public string Name;

        // Constructor
        public Person(string name)
        {
            Console.WriteLine("Person constructor called.");
            Name = name;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Person Name: {Name}");
        }
    }

    class Student : Person
    {
        public int Grade;

        // Constructor using the base keyword to call the Parent constructor
        public Student(string name, int grade) : base(name)
        {
            Console.WriteLine("Student constructor called.");
            Grade = grade;
        }

        public void DisplayStudentInfo()
        {
            DisplayInfo();
            Console.WriteLine($"Grade: {Grade}");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Practical 1, Question 8\n");
            
            // Creating an instance of Student
            Student student = new Student("Alice", 10);
            student.DisplayStudentInfo();

            Console.WriteLine("\n---------- \nName: Bimochan Poudel \nClass Roll: 21-00031-5 (20780638) \nTU Roll: 28555/078");

            Console.ReadLine();
        }
    }
}
