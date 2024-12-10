using System;

namespace Practical1Question4
{
    class Number
    {
        public int x, y;
        // Default constructor sets x and y to 1 and 2
        public Number() { x = 1; y = 2; }

        public Number(int a, int b) { x = a; y = b; }

        public void FindOdd()
        {
            Console.Write("Even numbers between x and y: ");
            for (int i = x; i <= y; i++)
                if (i % 2 == 0) Console.Write(i + " ");
            Console.WriteLine();
        }

        public void FindEven()
        {
            Console.Write("Odd numbers between x and y: ");
            for (int i = x; i <= y; i++)
                if (i % 2 != 0) Console.Write(i + " ");
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Practical 1, Question 4\n");
            
            Number num1 = new Number();
            Console.WriteLine("\nUsing Default Constructor:");
            num1.FindOdd();
            num1.FindEven();

            Number num2 = new Number(5, 15);
            Console.WriteLine("\nUsing Parameterized Constructor (5 to 15):");
            num2.FindOdd();
            num2.FindEven();

            Console.WriteLine("\n---------- \nName: Bimochan Poudel \nClass Roll: 21-00031-5 (20780638) \nTU Roll: 28555/078");

            Console.ReadLine();
        }
    }
}
