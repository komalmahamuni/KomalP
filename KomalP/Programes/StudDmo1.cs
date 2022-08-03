using System;
using System.Collections.Generic;
using System.Text;

namespace KomalP.Programes
{
    class StudDmo1
    {
        int id;
        string name;
        float percentage;

        public int Id
        {
            get { return id; }
            set { id = value; }

        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public float Percentage
        {
            get { return percentage; }
            set { percentage = value; }


        }
    }
        class Studentd
        {
            static void Main(string[] args)
            {
                StudDmo1 s = new StudDmo1();
                s.Id = 5;
                s.Name = "Sakshi";
                s.Percentage = 70.65f;


                int sid = s.Id;
                Console.WriteLine(sid);
                Console.WriteLine(s.Name + " " + s.Percentage);
            }
        }
    }


    

