using System;
using System.Collections.Generic;
using System.Text;

namespace KomalP.Programes
{
    class OverLoading
    {

        void area()
        {
            Console.WriteLine("area Method");
        }
        int area(int l,int w)
        {
            return (l * w);
        }
        double area(double b, double h)
        {
            return (b * h )/ 2;
        }
        int area(int s)
        {
            return (s * s);
        }
        double area( double r)
        {
            return (3.14 * r * r);
        }
        static void Main(string[] args)
        {
            OverLoading o = new OverLoading();
            int rectangle = o.area(4, 2);
            Console.WriteLine(rectangle);
            double triangle = o.area(2.2, 3.3);
            Console.WriteLine(triangle);
            int square = o.area(2);
            Console.WriteLine(square);
            double circle = o.area(3.2);
            Console.WriteLine(circle);

        }
    }
}
