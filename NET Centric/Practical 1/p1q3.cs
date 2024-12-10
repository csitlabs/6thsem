using System;

namespace Practical1Question3
{
    class Calculate
    {
        public int num1, num2;

        public void SetCalc(int a, int b)
        {
            num1 = a;
            num2 = b;
        }

        public void CalcSum()
        {
            Console.WriteLine("Sum: " + (num1 + num2));
        }

        public void CalcMulti()
        {
            Console.WriteLine("Multiplication: " + (num1 * num2));
        }

        public void CalcDifference()
        {
            Console.WriteLine("Difference: " + (num1 - num2));
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Practical 1, Question 3\n");
            
            Calculate calc = new Calculate();
            calc.SetCalc(10, 5);

            calc.CalcSum();
            calc.CalcMulti();
            calc.CalcDifference();

            Console.WriteLine("\n---------- \nName: Bimochan Poudel \nClass Roll: 21-00031-5 (20780638) \nTU Roll: 28555/078");

            Console.ReadLine();
        }
    }
}
