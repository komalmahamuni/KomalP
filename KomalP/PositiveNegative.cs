using System;
using System.Collections.Generic;
using System.Text;

namespace KomalP
{
    class PositiveNegative
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter a number : ");
            n = int.Parse(Console.ReadLine());

            if(n==0)
            {
                Console.WriteLine(n + "is zero.");
            }
            else if(n>0)
            {
                Console.WriteLine(n + "is positive");
            }
            else
            {
                Console.WriteLine(n + "is negative");
            }
        }
    }
}
