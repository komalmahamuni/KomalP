using System;
using System.Collections.Generic;
using System.Text;

namespace KomalP
{
    class Dayno
    {
        static void Main(string[] args)
        {
            int dayno;
            Console.Write("Accept day number and display its equivalent day name in word:\n");

            Console.Write("Input Day No : ");
            dayno = Convert.ToInt32(Console.ReadLine());

			switch (dayno)
			{
				case 1:
					Console.WriteLine("Monday \n");
					break;
				case 2:
					Console.WriteLine("Tuesday \n");
					break;
				case 3:
					Console.WriteLine("Wednesday \n");
					break;
				case 4:
					Console.WriteLine("Thursday \n");
					break;
				case 5:
					Console.WriteLine("Friday \n");
					break;
				case 6:
					Console.WriteLine("Saturday \n");
					break;
				case 7:
					Console.WriteLine("Sunday  \n");
					break;
				default:
					Console.WriteLine("Invalid day number. ");
					break;
			}
		}
	}
    }
    


