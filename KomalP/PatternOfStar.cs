﻿using System;
using System.Collections.Generic;
using System.Text;

namespace KomalP
{
    class PatternOfStar
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 6; ++i)
            {
                for (int j = 1; j <= i; ++j)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
    
