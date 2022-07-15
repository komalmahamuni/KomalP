using System;
using System.Collections.Generic;
using System.Text;

namespace KomalP
{
    class Car
    {
        public int model;
        public string name;
        public double price;

        static void Main(string[] args)
        {
            Car myObj = new Car();
            myObj.model = 8561;
            myObj.name = "Alto";
            myObj.price = 500000;
            Console.WriteLine(myObj.model + " " + myObj.name + " " + myObj.price);

            Car myObj1 = new Car();
            myObj.model = 8769;
            myObj.name = "Swift";
            myObj.price = 700000;
            Console.WriteLine(myObj.model + " " + myObj.name + " " + myObj.price);



        }
    }
}
