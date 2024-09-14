//  Write a class named ‘Shape’ having Length and Breadth properties along with default and 
// parametrized constructor. The parametrized constructor should accept two inputs and initialize 
// the properties of the class. Create new class rectangle from shape class and calculate area of 
// rectangle.

using System;
namespace IshmaLab2Qn10
{
   public class Shape
    {
        //properties
        public double Length { get; set; }
        public double Breadth { get; set; }

        //default constructor
        public Shape()
        {
            Length = 2;
            Breadth = 4;
        }

        //parameterized constructor
        public Shape(double length, double breadth)
        {
            Length = length;
            Breadth = breadth;
        }
    }

   public class Rectangle : Shape
        {
        //default constructor
            public Rectangle() : base()
        {

        }

        //parameterized constructor
        public Rectangle(double length , double breadth) : base(length , breadth)
        {
            
        }

        //method to calculate area of rectangle
         public double CalculateArea()
        {
            return Length * Breadth;
        }

        public override string ToString()
        {
            return $"Rectangle :Length= {Length},Breadth= {Breadth}, Area= {CalculateArea()}";
        }
        }

    public class Program
    {
        /*
        static void Main(string[] args)
        {
            // using default constructor
            Shape shapeObj = new Shape();
            Console.WriteLine($"Shape :Length= {shapeObj.Length}, Breadth= {shapeObj.Breadth}");

            //using parameterize constructor

            Rectangle recObj = new Rectangle(20, 30);
            Console.WriteLine(recObj);

            Console.ReadLine();
        }
        */
    }

    
}