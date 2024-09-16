//Write a program to demonstrate different types of property in C#.

using System;
namespace IshmaLab2Qn9
{
    class Product
    {
        //Auto - Implemented Property
        public string Name { get; set; }

        //read-only property
        private double _costPrice;
        public double CostPrice
        {
            get { return _costPrice;}

        }

        //Write_Only property
        private double _discount;
        public double Discount
        {
            set
            {
                if (value >= 0 && value <= 40)
                {
                    _discount = value;
                }
                else
                {
                    Console.WriteLine("Invalid discount");
                }
            }
        }

        // computed property
        public double SellingPrice
        {
            get { return _costPrice * (1 - _discount / 100); }
        }

        //constructor to initialize cost price
        public Product(string name , double costPrice)
        {
            Name = name;
            _costPrice = costPrice;
        }

        public void display()
        {
            Console.WriteLine($"Product Name : {Name}");
            Console.WriteLine($"Cost Price : {CostPrice}");
            Console.WriteLine($"Selling Price :{SellingPrice}");
        }

    
    class Program
        {
            /*
            static void Main(string[] args)
            {
                //product intance
                Product prObj = new Product("Bag", 1000);

                //using auto_implemented property
                prObj.Name = "School bag";

                //write-only property for setting discount
                prObj.Discount = 10; //10%

                //display product info
                prObj.display();

                // Try to read Discount value (not allowed, write-only)
                // Console.WriteLine(prod.Discount);  // This would result in a compilation error.

                // Try to set an invalid discount
                prObj.Discount = 70;  //invalid discount should trigger

            Console.ReadLine();
            }
            */
        }
    }
}
