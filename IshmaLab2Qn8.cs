//Write a program in C# to binary operator.
using System;
namespace IshmaLab2Qn8
{
    class BinaryOperator
    {
        public int Value { get; set; }
        public BinaryOperator(int value)
        {
            Value = value;
        }
        // Overloading the binary(+,-,*,/)  operator
        public static BinaryOperator operator +(BinaryOperator a, BinaryOperator b)
        {
            return new BinaryOperator(a.Value + b.Value);
        }
        public static BinaryOperator operator -(BinaryOperator a, BinaryOperator b)
        {
            return new BinaryOperator(a.Value - b.Value);
        }
        public static BinaryOperator operator *(BinaryOperator a, BinaryOperator b)
        {
            return new BinaryOperator(a.Value * b.Value);
        }
        public static BinaryOperator operator /(BinaryOperator a, BinaryOperator b)
        {
            if (b.Value == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero!");
            }
            return new BinaryOperator(a.Value / b.Value);
        }
        public void Display()
        {
            Console.WriteLine($"Value: {Value}");
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            BinaryOperator a = new BinaryOperator(num1);

            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            BinaryOperator b = new BinaryOperator(num2);

            BinaryOperator resultAdd = a + b;
            Console.WriteLine("Addition Result:");
            resultAdd.Display();

            BinaryOperator resultSub = a - b;
            Console.WriteLine("Subtraction Result:");
            resultSub.Display();

            BinaryOperator resultMul = a * b;
            Console.WriteLine("Multiplication Result:");
            resultMul.Display();

            try
            {
                BinaryOperator resultDiv = a / b;
                Console.WriteLine("Division Result:");
                resultDiv.Display();
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}

