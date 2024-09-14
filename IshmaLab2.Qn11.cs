//  Write a C# program to create generic class and methods. 

using System;

namespace IshmaLab2Qn11
{
    public class Box<T>
    {
        //private field to hold value of <T>
        private T _value;

        //constructor to initialize value
        public Box(T value)
        {
            _value = value;
        }

        //property to get or set value
        public T value
        {
            get { return _value; }
            set { _value = value; }
        }

        //method to display value
        public void Display()
        {
            Console.WriteLine($"The value in the box is :{_value}");
        }

        //generic method to compare 2 values of type T
        public bool Compare<T>(T value1, T value2)
        {
            // Compare using the Equals method
            return value1.Equals(value2);
        }
    }

    public class Program
    {
        /*
        static void Main(string[] args)
        {
            // Create a Box of type int
            Box<int> intBox = new Box<int>(123);
            intBox.Display();

            // Create a Box of type string
            Box<string> strBox = new Box<string>("Hello,Ishma");
            strBox.Display();

            // Test the generic method Compare
            bool isEqual = intBox.Compare(123, 123);
            Console.WriteLine($"123 equals 123: {isEqual}");

            isEqual = intBox.Compare(123, 456);
            Console.WriteLine($"123 equals 456: {isEqual}");
            Console.ReadLine();
        }
        */
    }
}