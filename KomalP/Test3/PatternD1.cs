using System;
using System.Collections.Generic;
using System.Text;

namespace KomalP.Test3
{
    class PatternD1
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=4;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    if(j==2 || j==4)
                    {
                        Console.Write("0");
                    }
                    else
                    {
                        Console.Write("1");
                    }

                }
                Console.WriteLine();
            }
        }
    }
}
