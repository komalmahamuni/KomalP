﻿using System;
using System.Collections.Generic;
using System.Text;

namespace KomalP
{
    class EvenOdd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            if(num1 %2 ==0)
            {
                Console.WriteLine(+num1 + "\t the number is even");
            }
            else
            {
                Console.WriteLine(num1 + "\t the number is odd");
            }
        }
    }
}
