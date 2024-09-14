//Write a C# program to create employee class with name, email and salary field, also 
//create object for employee.

using System;

namespace Ishma_dot_net_practical_1
{

    public class Employee
    {
        public string E_Name { get; set; }
        public string E_email { get; set; }
        public double E_Salary { get; set; }

        public Employee(string name, string email, double salary)
        {
            E_Name = name;
            E_email = email;
            E_Salary = salary;

        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Employee name : {E_Name}");
            Console.WriteLine($"Employee email : {E_email}");
            Console.WriteLine($"Employee salary : {E_Salary}");
        }
    }

    class Program
    {
        /*
        static void Main(string[] args)
        {

            Employee emp = new Employee("Ishma", "timsinaishma123@gmail.com", 23456.124);
            emp.DisplayInfo();
            Console.ReadLine();

        }
        */

    }
}
