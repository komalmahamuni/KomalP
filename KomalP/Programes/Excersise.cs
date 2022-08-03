using System;
using System.Collections.Generic;
using System.Text;

namespace KomalP.Programes
{
    class Excersise
    {
        static void Main(string[] args)
        {
            int num, sum = 0, firstDigit, lastDigit;

            
            Console.Write("Enter any number: ");
            num = Convert.ToInt32(Console.ReadLine());

            lastDigit = num % 10;

            firstDigit = num;

            while (num >= 10)
            {
                num = num / 10;
            }
            firstDigit = num;

            
            sum = firstDigit + lastDigit;

            Console.WriteLine("Sum of first and last digit: " + sum);

            Console.ReadLine();
        }
    }
    }


