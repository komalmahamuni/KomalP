using System;
using System.Collections.Generic;
using System.Text;

namespace KomalP
{
    class Solution
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            bool isprime = true;
            for(int i=2;i<num;i++)
            {
                if (num % i == 0)
                {
                    isprime = false;

                }
            }
            if(isprime==true)
            {
                Console.WriteLine("prime");
            }
            else
            {
                Console.WriteLine("not prime");
            }
        }

    }
}
