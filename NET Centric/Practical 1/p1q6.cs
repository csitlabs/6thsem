using System;

namespace Practical1Question6
{
    class EmployeeDetails
    {
        public int empId;
        public string empName, empGender, empAddress, empPosition;

        public EmployeeDetails(int id, string name, string gender, string address, string position)
        {
            empId = id;
            empName = name;
            empGender = gender;
            empAddress = address;
            empPosition = position;
        }

        public void Display()
        {
            Console.WriteLine($"ID: {empId}, Name: {empName}, Gender: {empGender}");
            Console.WriteLine($"Address: {empAddress}, Position: {empPosition}");
        }
    }

    class SalaryInfo : EmployeeDetails
    {
        public double salary;

        public SalaryInfo(int id, string name, string gender, string address, string position, double sal)
            : base(id, name, gender, address, position)
        {
            salary = sal;
        }

        public void CalcTax()
        {
            double tax = 0;
            if (salary <= 400000) tax = salary * 0.01;
            else if (salary <= 800000) tax = salary * 0.1;
            else tax = salary * 0.2;

            double netSalary = salary - tax;
            Console.WriteLine($"Salary: {salary}, Tax: {tax}, Net Salary: {netSalary}");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Practical 1, Question 6\n");
            
            var employee = new SalaryInfo(101, "John Doe", "Male", "NYC", "Manager", 500000);
            employee.Display();
            employee.CalcTax();

            Console.WriteLine("\n---------- \nName: Bimochan Poudel \nClass Roll: 21-00031-5 (20780638) \nTU Roll: 28555/078");

            Console.ReadLine();
        }
    }
}
