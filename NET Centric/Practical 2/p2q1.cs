using System;

namespace Practical2Question1
{
    class EmployeeDetails
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpGender { get; set; }
        public string EmpAddress { get; set; }
        public string EmpPosition { get; set; }

        public EmployeeDetails(int empId, string empName, string empGender, string empAddress, string empPosition)
        {
            EmpId = empId;
            EmpName = empName;
            EmpGender = empGender;
            EmpAddress = empAddress;
            EmpPosition = empPosition;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"ID: {EmpId}, Name: {EmpName}, Gender: {EmpGender}, Address: {EmpAddress}, Position: {EmpPosition}");
        }
    }

    class SalaryInfo : EmployeeDetails
    {
        public double Salary { get; set; }

        public SalaryInfo(int empId, string empName, string empGender, string empAddress, string empPosition, double salary)
            : base(empId, empName, empGender, empAddress, empPosition)
        {
            Salary = salary;
        }

        public void CalcTax()
        {
            double tax;
            if (Salary <= 400000)
                tax = Salary * 0.01;
            else if (Salary <= 800000)
                tax = Salary * 0.10;
            else
                tax = Salary * 0.20;

            double finalSalary = Salary - tax;
            Console.WriteLine($"Salary: {Salary}, Tax: {tax}, Final Salary: {finalSalary}");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Practical 2, Question 1\n");
           
            // Create an instance of SalaryInfo and demonstrate
            SalaryInfo employee = new SalaryInfo(101, "Alice", "Female", "Kathmandu", "Manager", 850000);
            employee.DisplayDetails();
            employee.CalcTax();

            Console.WriteLine("\n---------- \nName: Bimochan Poudel \nClass Roll: 21-00031-5 (20780638) \nTU Roll: 28555/078");

            Console.ReadLine();
        }
    }
}
