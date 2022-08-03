using System;
using System.Collections.Generic;
using System.Text;

namespace KomalP.Test4
{
    class Qu3
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter an Positive Integer Number:: ");
            int number = Convert.ToInt32(Console.ReadLine());

            
            if (IsKaprekar(number))
                Console.WriteLine(number + " is a kaprekar number");
            else
                Console.WriteLine(number + " is not a kaprekar number");

            
            Console.ReadLine();
        }
        public static bool IsKaprekar(int number)
        {
           
            int square = 0;
            int temp = 0;
            int countDigits = 0;
            int firstPart = 0;
            int secondPart = 0;
            int sum = 0;

            
            square = number * number;

           
            temp = square;
            while (temp != 0)
            {
                countDigits++;
                temp /= 10;
            }
           
            for (int i = countDigits - 1; i > 0; i--)
            {
              
                firstPart = square / (int)Math.Pow(10, i);

               
                secondPart = square % (int)Math.Pow(10, i);

                
                if (firstPart == 0 || secondPart == 0)
                    continue;

               
                sum = firstPart + secondPart;

               
                if (sum == number)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

