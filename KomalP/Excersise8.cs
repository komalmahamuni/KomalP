using System;
using System.Collections.Generic;
using System.Text;

namespace KomalP
{
    class Excersise8
    {
        static void Main(string[] args)
        {
            int i = 0;

            Console.WriteLine("Even Numbers :");
            for (i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine("\nOdd Numbers :");
            for (i = 1; i <= 50; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i*i + " ");
                }
            }

            Console.WriteLine();
        }
    }
}
        
    

