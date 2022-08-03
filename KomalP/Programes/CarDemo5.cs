using System;
using System.Collections.Generic;
using System.Text;

namespace KomalP.Programes
{
    class CarDemo5
    {
        int model_no;
        string name;
        int price;

        public int Model_No
        {
            get { return model_no; }
            set { model_no = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

    }
    class CarInformation
    {
        static void Main(string[] args)
        {
            CarDemo5 c = new CarDemo5();
            c.Model_No = 1356;
            c.Name = "Wagonar";
            c.Price = 500000;
            Console.WriteLine("Model_No" + c.Model_No + " Name" + c.Name + " Price=" + c.Price);

        }
    }
}
