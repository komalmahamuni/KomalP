using System;
using System.Collections.Generic;
using System.Text;

namespace KomalP.Test4
{
    class Qu4b
    {
        static void Main(string[] args)
        {
			int i, j, c = 0;

			for (i = 0; i < 4; i++)  //loop for row
			{
				for (j = 0; j <= i; j++)  //loop for column
				{
					c++;  //increment in count variable
					if (c % 2 == 1)
						Console.Write(1);
					else
						Console.Write(0);
				}
				Console.WriteLine();  //for new line
			}
		}
	}
}
        
    

