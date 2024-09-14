// Write a program in C# to overload unary operator. 

using System;
namespace IshmaLab2Qn7
{
    class Counter
    {
        public int Count { get; private set; }
        public Counter(int initialCount)
        {
            Count = initialCount;
        }

        public static Counter operator ++(Counter c)
        {
            c.Count++;
            return c;
        }
        public static Counter operator --(Counter c)
        {
            c.Count--;
            return c;
        }
        public override string ToString()
        {
            return $"Count: {Count}";
        }
    }

    class Program
    {
        /*
        static void Main(string[] args)
        {
            // Create a Counter object
            Counter counter = new Counter(10);
            Console.WriteLine("Initial " + counter);

            // Use overloaded prefix increment operator
            ++counter;
            Console.WriteLine("After ++ " + counter);

            // Use overloaded prefix decrement operator
            --counter;
            Console.WriteLine("After -- " + counter);

            Console.ReadKey();
        }
        */
    }
}