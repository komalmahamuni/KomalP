using System;
using System.Collections.Generic;
using System.Text;

namespace KomalP
{
    class Triangular
    {
        static void Main(string[] args)
        {
            int n = 6;
            string series = new string('*', n);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(series);
                series = series.Substring(1);
            }
            Console.ReadLine();
        }
    }
}
    

