using System;

namespace Practical1Question2
{
    // Class to demonstrate method overloading
    class MathOperations
    {
        // Method to add two integers
        public void Add(int num1, int num2)
        {
            Console.WriteLine($"Sum of {num1} and {num2} is: {num1 + num2}");
        }

        // Method to add three integers
        public void Add(int num1, int num2, int num3)
        {
            Console.WriteLine($"Sum of {num1}, {num2}, and {num3} is: {num1 + num2 + num3}");
        }

        // Method to add two decimal numbers
        public void Add(double num1, double num2)
        {
            Console.WriteLine($"Sum of {num1} and {num2} is: {num1 + num2}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Header Information
            Console.WriteLine("Practical 1, Question 2\n");
            
            // Creating an instance of MathOperations
            MathOperations math = new MathOperations();

            // Demonstrating method overloading with different data types and number of parameters
            math.Add(5, 10);                // Adding two integers
            math.Add(4, 7, 12);             // Adding three integers
            math.Add(5.5, 4.5);             // Adding two decimal numbers

            Console.WriteLine("\n---------- \nName: Bimochan Poudel \nClass Roll: 21-00031-5 (20780638) \nTU Roll: 28555/078");

            Console.ReadLine();  // Wait for user input
        }
    }
}
