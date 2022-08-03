using System;
using System.Collections.Generic;
using System.Text;

namespace KomalP
{
    class Exam
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                int num = n % 10;
                if (num % 2 == 0)
                {
                    Console.WriteLine("Not Happy");
                }
                else
                {
                    Console.WriteLine("Happy");
                }
            }
        }
    }
}
            