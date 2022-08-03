using System;
using System.Collections.Generic;
using System.Text;

namespace KomalP.Test4
{
    class Qu1
    {
        
      static int frequencyDigits(int n,
                           int d)
        {
            
            int c = 0;

            
            while (n > 0)
            {

                
                if (n % 10 == d)
                    c++;
              
                n = n / 10;
            }
            return c;
        }
        static void Main(string[] args)
        {
            // input number N
            int N = 1122322;

            // input digit D
            int D = 2;

            Console.WriteLine(frequencyDigits(N, D));

        }
    }

}
    

