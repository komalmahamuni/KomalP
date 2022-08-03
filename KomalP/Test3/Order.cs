using System;
using System.Collections.Generic;
using System.Text;

namespace KomalP.Test3
{
    class Order
    {
        int id;
        string city;
        string name;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
        class OrderDemo
        {
            static void Main(string[] args)
            {
                Order o = new Order();
                o.Id = 101;
                o.City = "Pune";
                o.Name = "Pooja";

                int oid = o.Id;
                Console.WriteLine(oid);
                Console.WriteLine(o.Id + " " + o.City + " " + o.Name);
            }
        }
    }

