using System;
using System.Collections.Generic;
using System.Text;

namespace KomalP
{
    class Area1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter length");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("enter breadth");
            int breadth = int.Parse(Console.ReadLine());
            Console.WriteLine("enter radius");
            int radius = int.Parse(Console.ReadLine());
           
            Console.WriteLine("enter height");
            int height = int.Parse(Console.ReadLine());
            
            Console.WriteLine("1.Area of rectangle\n2.area of square\n3.area of circle\n4.area of triangle");
            Console.WriteLine("enter your choice");
            int choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1: Console.WriteLine("Area of rectangle=" + (length * breadth));
                    break;
                case 2: Console.WriteLine("Area of square=" + (length*length));
                    break;
                case 3: Console.WriteLine("Area of circle=" + (3.14 * radius*radius));
                    break;
                case 4: Console.WriteLine("Area of triangle=" + (1/2 *length*height));
                    break;
                default:Console.WriteLine("invalid choice");
                    break;

            }

           
                

            }

        }
    }


