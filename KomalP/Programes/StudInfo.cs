using System;
using System.Collections.Generic;
using System.Text;

namespace KomalP.Programes
{
    class StudInfo
    {
        private int roll_no = 1;
        internal string name = "Aboli";
        protected string address = "Pune";
        public int marks = 70;

        static void Main(string[] args)
        {
            StudInfo s = new StudInfo();
            Console.WriteLine(s.roll_no);
            Console.WriteLine(s.name);
            Console.WriteLine(s.address);
            Console.WriteLine(s.marks);


        }
    }
}
