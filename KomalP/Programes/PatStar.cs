using System;
using System.Collections.Generic;
using System.Text;

namespace KomalP.Programes
{
    class PatStar
    {
        static void Main(string[] args)
        {
            int i, j;
            int MAX = 4;
            for (i = 1; i <= MAX; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    if (j == 1 || j == i || i == MAX)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
    }

