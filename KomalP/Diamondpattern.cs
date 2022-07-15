using System;
using System.Collections.Generic;
using System.Text;

namespace KomalP
{
    class Diamondpattern
    {
        static void Main(string[] args)
        {
            for (char i = '1'; i <= '5'; i++)
            {
                for (char j = '1'; j <= i; j++)
                {
                    Console.Write(i);

                }
                Console.WriteLine();
            }
        }
    }
}

