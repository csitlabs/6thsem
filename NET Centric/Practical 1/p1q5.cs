using System;

namespace Practical1Question5
{
    class Shape
    {
        public int length, breadth, height;

        // Default constructor
        public Shape() { length = 0; breadth = 0; height = 0; }

        // Constructor with two parameters
        public Shape(int l, int b) { length = l; breadth = b; }

        // Constructor with three parameters
        public Shape(int l, int b, int h) { length = l; breadth = b; height = h; }

        // Calculate area of a rectangle
        public void CalcAreaRectangle()
        {
            Console.WriteLine($"Area of rectangle (5, 4): {length * breadth}");
        }

        // Calculate volume of a box
        public void CalcVolumeBox()
        {
            Console.WriteLine($"Volume of box (3, 4, 5): {length * breadth * height}");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Practical 1, Question 5");
           
            Shape rectangle = new Shape(5, 4);
            Console.WriteLine("\nFor Rectangle:");
            rectangle.CalcAreaRectangle();

            Shape box = new Shape(3, 4, 5);
            Console.WriteLine("\nFor Box:");
            box.CalcVolumeBox();

            Console.WriteLine("\n---------- \nName: Bimochan Poudel \nClass Roll: 21-00031-5 (20780638) \nTU Roll: 28555/078");

            Console.ReadLine();
        }
    }
}
