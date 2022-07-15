using System;
using System.Collections.Generic;
using System.Text;

namespace KomalP
{
    class Area
    {
        static void Main(string[] args)
        {
            int r;
            double A;
            Console.WriteLine("Enter the radius:");
            r = Convert.ToInt32(Console.ReadLine());
            A = (3.14) * r * r;
            Console.WriteLine("The Area of circle of given radius is="+A);
            Console.ReadLine();
        }
    }
}
