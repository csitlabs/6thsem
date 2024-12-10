using System;

namespace Practical1Question7
{
    // Single-Level Inheritance
    class Parent
    {
        public void DisplayParentInfo()
        {
            Console.WriteLine("This is the Parent class.");
        }
    }

    class Child : Parent
    {
        public void DisplayChildInfo()
        {
            Console.WriteLine("This is the Child class.");
        }
    }

    // Multilevel Inheritance
    class Grandparent
    {
        public void DisplayGrandparentInfo()
        {
            Console.WriteLine("This is the Grandparent class.");
        }
    }

    class ParentOfChild : Grandparent
    {
        public void DisplayParentInfo()
        {
            Console.WriteLine("This is the Parent class.");
        }
    }

    class ChildOfParent : ParentOfChild
    {
        public void DisplayChildOfParentInfo()
        {
            Console.WriteLine("This is the Child of Parent class.");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Practical 1, Question 7\n");
            
            // Single-level inheritance demonstration
            Console.WriteLine("\n--- Single-Level Inheritance ---");
            Child singleChild = new Child();
            singleChild.DisplayParentInfo();
            singleChild.DisplayChildInfo();

            // Multilevel inheritance demonstration
            Console.WriteLine("\n--- Multilevel Inheritance ---");
            ChildOfParent multiChild = new ChildOfParent();
            multiChild.DisplayGrandparentInfo();
            multiChild.DisplayParentInfo();
            multiChild.DisplayChildOfParentInfo();

            Console.WriteLine("\n---------- \nName: Bimochan Poudel \nClass Roll: 21-00031-5 (20780638) \nTU Roll: 28555/078");

            Console.ReadLine();
        }
    }
}
