using System;
using System.Collections.Generic;
using System.Text;

namespace KomalP.Test3
{
    class PatternD4
    {
        static void Main(string[] args)
        {
            for (char i = 'D'; i >= 'A'; i--)
            {
                for (char j = 'A'; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}

        
    

