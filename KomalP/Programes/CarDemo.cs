using System;
using System.Collections.Generic;
using System.Text;

namespace KomalP.Programes
{
    class CarDemo
    {
        int modelno;
        string name;
        string colour;
        double price;
        int speed;

        public int Modelno
        {
            get { return modelno; }
            set { modelno = value; }

        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Colour
        {
            get { return colour; }
            set { colour = value; }


        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
    }

        class CarInfo
        {
            static void Main(string[] args)
            {
                CarDemo c = new CarDemo();
                c.Modelno = 555;
                c.Name = "Alto";
                c.Colour = "Blue";
                c.Price = 500000;
                c.Speed = 70;

                int cmodelno = c.Modelno;
                Console.WriteLine(cmodelno);
                Console.WriteLine(c.Name + " " + c.Colour + " " + c.Price + " " + c.Speed);
            }
        }
    }



