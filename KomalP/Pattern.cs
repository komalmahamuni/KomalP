using System;
using System.Collections.Generic;
using System.Text;

namespace KomalP
{
    class Pattern
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("*******************");
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}






