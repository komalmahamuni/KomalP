using System;
using System.Collections.Generic;
using System.Text;

namespace KomalP.Constructer
{
    class Student
    {
        int id;
        string name;
        string address;

        public Student()
        {
            id = 1;
            name = "komal";
            address = "Mumbai";
        }
        static void Main(string[] args)
        {
            Student s = new Student();
            Console.WriteLine(s.id + " " + s.name + " " + s.address);
        }
    }
}
