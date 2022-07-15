using System;
using System.Collections.Generic;
using System.Text;

namespace KomalP
{
    class ConditionDemo
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the number :");
            n = int.Parse(Console.ReadLine());
            if(n%5==0)
            {
                Console.WriteLine("Entered Number is divisible by 5");
            }
            else
            {
                Console.WriteLine("Entered Number is not divisible by 5");
            }
            Console.ReadLine();
        }


    }
}
