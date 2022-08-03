using System;
using System.Collections.Generic;
using System.Text;

namespace KomalP.Test3
{
    class Q2
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value of number:");
            int number = Convert.ToInt32(Console.ReadLine());
            int factor;
            for (factor = 1; factor <= number; factor++)
            {
                if (number % factor == 0)
                {
                    Console.Write(factor + ",");
                }
            }
            Console.ReadKey();
        }
    }
}
        
    

