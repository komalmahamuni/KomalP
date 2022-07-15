using System;
using System.Collections.Generic;
using System.Text;

namespace KomalP
{
    class Palindrome
    {
        static void Main(string[] args)
        {
             
            Console.Write("Enter the Number: ");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            while (num > 0)
            {
              int  r = num % 10;

                sum = (sum * 10) + r;
                num = num / 10;
            }
           
                Console.Write("Number is Palindrome.");
           
        }
    }
}
    

