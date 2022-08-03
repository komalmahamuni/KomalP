using System;
using System.Collections.Generic;
using System.Text;

namespace KomalP.Programes
{
    class MethodOverLoadingDemo
    {
        void calculate()
        {
            Console.WriteLine("calculate Method");
        }
        int calculate (int a,int b)
        {
            return a - b;
        }
        float calculate (float x,float y)
        {
            return x + y;
        }
        double calculate(double c,double d)
        {
            return c * d;
        }
        double calculate(int a, double b)
        {
            return a % b;
        }
        static void Main(string[] args)
        {
            MethodOverLoadingDemo m = new MethodOverLoadingDemo();
            int diff = m.calculate(5, 4);
            Console.WriteLine(diff);
            float add = m.calculate(2f, 3f);
            Console.WriteLine(add);
            double multi = m.calculate(4.4, 2.3);
            Console.WriteLine(multi);
            double divide = m.calculate(5, 2.4);
            Console.WriteLine(divide);
        }




    }
}
