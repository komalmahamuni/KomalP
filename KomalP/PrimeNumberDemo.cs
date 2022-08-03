using System;
using System.Collections.Generic;
using System.Text;

namespace KomalP
{
    class PrimeNumberDemo
    {
        public void Display()
        {
            int num = int.Parse(Console.ReadLine());
            bool isprime = true;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    isprime = false;

                }
            }
            if (isprime == true)
            {
                Console.WriteLine("prime");
            }
            else
            {
                Console.WriteLine("not prime");
            }

            static void Main(string[] args)
            {
                PrimeNumberDemo d = new PrimeNumberDemo();
                d.Display();
            }
        }
    }
}
