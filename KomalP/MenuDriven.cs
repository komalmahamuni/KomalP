﻿using System;
using System.Collections.Generic;
using System.Text;

namespace KomalP
{
    class MenuDriven
    {
        static void Main(string[] args)
        {
            int num1, num2, opt;

            
            Console.Write("A menu driven program for a simple calculator:\n");
           


            Console.Write("Enter the first Integer :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second Integer :");
            num2 = Convert.ToInt32(Console.ReadLine());


            Console.Write("\nHere are the options :\n");
            Console.Write("1-Addition.\n2-Substraction.\n3-Multiplication.\n5-Exit.\n");
            Console.Write("\nInput your choice :");
            opt = Convert.ToInt32(Console.ReadLine());

            switch (opt)
            {
                case 1:
                    Console.Write("The Addition of  {0} and {1} is: {2}\n", num1, num2, num1 + num2);
                    break;

                case 2:
                    Console.Write("The Substraction of {0}  and {1} is: {2}\n", num1, num2, num1 - num2);
                    break;

                case 3:
                    Console.Write("The Multiplication of {0}  and {1} is: {2}\n", num1, num2, num1 * num2);
                    break;

                case 5:
                    break;

                default:
                    Console.Write("Input correct option\n");
                    break;
            }
        }
    }
}

