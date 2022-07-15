using System;
using System.Collections.Generic;
using System.Text;

namespace KomalP
{
    class Armstrong
    {
        static void Main(string[] args)
        {
            int num, r, sum = 0, temp;


            
            Console.Write("Check whether a given number is armstrong number or not:\n");
          
            
            Console.Write("Input  a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (temp = num; num != 0; num = num / 10)
            {
                r = num % 10;
                sum = sum + (r * r * r);
            }
            if (sum == temp)
                Console.Write("{0} is an Armstrong number.\n", temp);
            else
                Console.Write("{0} is not an Armstrong number.\n", temp);
        }
    }
}
    

