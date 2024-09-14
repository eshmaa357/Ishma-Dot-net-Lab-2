// Write a C# program to create virtual method in C#

using System;
namespace IshmaLab2Qn5
{
    class Vehicle
    {
        public virtual void honk()
        {
            Console.WriteLine("Vehicle horn Sound");
        }
    }
    class car : Vehicle
    {
        public override void honk()
        {
            Console.WriteLine("Car goes beep beep");
        }
    }
    class bike : Vehicle
    {
        public override void honk()
        {
            Console.WriteLine("Bike goes bhorom bhorom");
        }
    }

    class bus : Vehicle
    {
        public override void honk()
        {
            Console.WriteLine("Bus goes honk honk");
        }
    }

    class program
    {
        /*
        static void Main(string[] args)
        {
            Vehicle vehObj = new Vehicle();
            vehObj.honk();

            Vehicle carObj = new car();
            carObj.honk();

            Vehicle bikeObj = new bike();
            bikeObj.honk();

            Vehicle busObj = new bus();
            busObj.honk();

        }
        */
    }
}