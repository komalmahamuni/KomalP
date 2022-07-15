using System;
using System.Collections.Generic;
using System.Text;

namespace KomalP
{
    class Diamond
    {
        static void Main(string[] args)
        {
            for (char i = '1'; i <= '4'; i++)
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

        
    

