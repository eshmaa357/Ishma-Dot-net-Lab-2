//Write a C# program to demonstrate different types of inheritance. 

using System;
namespace IshmaLab2Qn4
{
    //parent class
    class Person
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        public void Details()
        {
            Console.WriteLine("Name:{0} , Id:{1}", Name, Id);
        }
    }

    //single inheritance
    class Employee : Person
    {
        public int E_Id { get; set; }
        public string E_Name { get; set; }
        public void E_Details()
        {

            Console.WriteLine("Emp name:{0} , Emp Id:{1}", E_Name, E_Id);
            Console.WriteLine("Person name:{0} , Person Id:{1}", Name, Id);
        }
    }

    //Multilevel inheritance
    class BOD : Employee
    {
        public string BOD_Name { get; set; }
        public void BOD_Details()
        {
            Console.WriteLine("BOD name:{0}", BOD_Name);
        }
    }
    //hierarchial inheritance
    class Manager : Person
    {
        public string Manager_Name { get; set; }
        public void Manager_Details()
        {
            Console.WriteLine("Manager name:{0}", Manager_Name);
        }
    }

    class Program
    {
        /*
        static void Main(string[] args)
        {
            //for single inheritance
            Employee emp = new Employee();
            emp.Name = "Ishma Timsina";
            emp.Id = 1;
            emp.E_Name = "Rita Subedi";
            emp.E_Id = 7;
            emp.E_Details();

            //for multilevel inheritance
            BOD bod = new BOD();
            bod.Name = "Sita Lamsal";
            bod.Id = 123;
            bod.E_Name = "Gita Lamsal";
            bod.E_Id = 32;
            bod.BOD_Name = "CEO";
            bod.E_Details();
            bod.BOD_Details();

            //for hierarchical inheritance
            Manager mng = new Manager();
            mng.Name = "Maya Thapa";
            mng.Id = 55;
            mng.Manager_Name = "Ms Maya";
            mng.Details();
            mng.Manager_Details();
            Console.ReadLine();
        }
        */
    }
}