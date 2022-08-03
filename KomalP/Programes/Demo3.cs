using System;
using System.Collections.Generic;
using System.Text;

namespace KomalP.Programes
{
    class Demo3
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter the 15 digit number:");
            int num = Convert.ToInt32(Console.ReadLine());

            int r;
            int sum = 0;
            while(num>0)
            {
                r = num % 10;
                sum = sum + r;

                num = num / 10;
            }
            if(sum%10==0)
            {
                Console.WriteLine("IMEI number");
            }
            else
            {
                Console.WriteLine(" Not IMEI number");
            }

        }
    }
}
