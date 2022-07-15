using System;
using System.Collections.Generic;
using System.Text;

namespace KomalP
{
    class CheckAlphaDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter char");
            char ch = Convert.ToChar(Console.ReadLine());

            if(ch>='A' && ch<='Z')
            {
                Console.WriteLine("Alphabet");

            }
            else if (ch >= 'a' && ch <= 'z')
            {
                Console.WriteLine("Alphabet");
            }
            else if(ch>='0' && ch<='9')
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("symbol");
            }
        }
    }
}
