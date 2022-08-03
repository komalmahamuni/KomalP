using System;
using System.Collections.Generic;
using System.Text;

namespace KomalP.Programes
{
    class StarD
    {
        static void Main(string[] args)
        {
            int number = 4;

            for (int i = 0; i < number; i++)
            {
                if (i == 0 || i == 4)
                {
                    for (int j = 0; j < number; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                if (i >= 1 || i <= 4)
                {
                    for (int j = 0; j < number; j++)
                    {
                        if (j == 0 || j == 3)
                        {
                            Console.Write("*");
                        }
                        else if (j >= 1 && j <= 3)
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
