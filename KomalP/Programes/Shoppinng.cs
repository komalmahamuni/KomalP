using System;
using System.Collections.Generic;
using System.Text;

namespace KomalP.Programes
{
    class Shoppinng
    {
        int sid;
        string product_name;
        int price;
        int qty;
        int total_bill;

        Shoppinng(int sid,string product_name,int price,int qty)
        {
            this.sid = sid;
            this.product_name = product_name;   //1st use
            this.price = price;
            this.qty = qty;

        }
        Shoppinng():this(2,"Toys",4,100)    //3rd use
        {
            total_bill = price * qty;
            this.Display();                   //2nd use
        }
        void Display()
        {
            Console.WriteLine(sid + " " + product_name + " "+price + " " + qty + " " + total_bill);
        }
        static void Main(string[] args)
        {
            Shoppinng s = new Shoppinng();
        }


    }
}
