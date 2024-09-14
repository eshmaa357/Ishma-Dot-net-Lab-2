// Write a C# program to demonstrate different types of constructor.

using System;
namespace IshmaLab2Qn6
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        //default constructor
        public Person()
        {
            Name = "Not Defined";
            Age = 0;
            Console.WriteLine("This is Default constructor");
        }

        //parameterize constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine("This is parameterized constructor");
        }

        //copy constructor
        public Person(Person cpy)
        {
            Name = cpy.Name;
            Age = cpy.Age;
            Console.WriteLine("This is copy constructor");
        }

        //destructor
        public void Display()
        {
            Console.WriteLine($"Name : {Name} , Age : {Age}");
        }
    }
    class Program
    {
        /*
        static void Main(string[] args)
        {
            //default constructor
            Person pObj1 = new Person();
            pObj1.Display();

            //parameterized constructor
            Person pObj2 = new Person("Ishma Timsina",20);
            pObj2.Display();

            //copy constructor
            Person pObj3 = new Person(pObj2);
            pObj3.Display();

            Console.ReadKey();
        }
        */
    }
}
