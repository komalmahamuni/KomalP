using System;
using System.Collections.Generic;
using System.Text;

namespace KomalP
{
    class Rectangle
    {
        static void Main(string[] args)
        {
            int Length = 15;
            int Breadth = 6;
            int Area = Length * Breadth;

            Console.WriteLine($"Area of Length{Length} and Breadth{Breadth} Rectangle is {Area}");
            Console.ReadKey();
        }
    }
}
