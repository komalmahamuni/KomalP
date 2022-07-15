using System;
using System.Collections.Generic;
using System.Text;

namespace KomalP
{
    class Spy
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number ");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int digit = 0;
            int product = 1;
            while (num > 0)
            {
                digit = num % 10;
                sum += digit;
                product *= digit;
                num = num / 10;

            }
            Console.WriteLine("sum =" + sum);
            Console.WriteLine("product =" + product);
            Console.WriteLine("------");
            if (sum == product)
                Console.WriteLine("spy number=" + sum);
            else
                Console.WriteLine("not spy number");
        }

    }
}
