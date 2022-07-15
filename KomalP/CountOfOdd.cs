using System;
using System.Collections.Generic;
using System.Text;

namespace KomalP
{
    class CountOfOdd
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for(int i=1;i<=10;i++)
            {
                if(i%2==1)
                {
                    sum = sum + 1;

                }
            }
            Console.WriteLine(sum);
        }
    }
}
