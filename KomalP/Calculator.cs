using System;
using System.Collections.Generic;
using System.Text;

namespace KomalP
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 1 st number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter 2 nd number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the operator");
            char op = Convert.ToChar(Console.ReadLine());

            switch(op)
            {
                case '+': Console.WriteLine("Addition=" + (num1 + num2));
                    break;
                case '-': Console.WriteLine("Substraction=" + (num1 - num2));
                    break;
                case '*': Console.WriteLine("Multiplication=" + (num1 * num2));
                    break;
                case '/': Console.WriteLine("Division=" + (num1 / num2));
                    break;
                default:Console.WriteLine("Invalid Operator");
                    break;

            }

        }
    }
}
