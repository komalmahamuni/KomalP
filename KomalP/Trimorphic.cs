using System;
using System.Collections.Generic;
using System.Text;

namespace KomalP
{
    class Trimorphic
    {
        static bool isTrimorphic(int N)
        {
            
            int cube = N * N * N;

           
            while (N > 0)
            {

                
                if (N % 10 != cube % 10)
                    return false;

               
                N /= 10;
                cube /= 10;
            }

            return true;
        }
        public static void Main()
        {
            int N = 24;

            if (isTrimorphic(N) == true)
                Console.Write("trimorphic");
            else
                Console.Write("not trimorphic");
        }
    }
}


