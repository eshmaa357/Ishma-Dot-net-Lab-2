//Write a C# program to access class method and fields of different namespace.
using System;

namespace Namespace_First
{
    class IshmaLab2Qn2
    {
        public int FirstField { get; set; }
        public void FirstMethod()
        {
            Console.WriteLine("This is inside First namespace");
        }
    }
}
