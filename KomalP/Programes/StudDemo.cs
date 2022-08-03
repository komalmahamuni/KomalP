using System;
using System.Collections.Generic;
using System.Text;

namespace KomalP.Programes
{
    class StudDemo
    {
        int id;
        string name;
        float percentage;
        char studgrade;
        public void Accept(int id,string name,float percentage)
        {
            this.id = id;
            this.name = name;
            this.percentage = percentage;

        }
        public void Grade()
        {
            if(percentage>90)
            {
                studgrade = 'A';
            }
            else if(percentage>80)
            {
                studgrade = 'B';
            }
            else if(percentage>50)
            {
                studgrade = 'C';
            }
            else
            {
                studgrade = 'F';
            }
        }
        public void display()
        {
            Console.WriteLine("student detail");
            if(percentage<0)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine("percentage" + percentage + "studgrade" + studgrade);
            }
            Console.WriteLine("id" + id + "name" + name + "percentage" + percentage);
        }
        static void Main(string[] args)
        {
            StudDemo s = new StudDemo();
            s.Accept(104, "priti", 70);
            s.Grade();
            s.display();
        }
    }
}
