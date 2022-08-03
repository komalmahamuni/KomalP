using System;
using System.Collections.Generic;
using System.Text;

namespace KomalP.Programes
{
    class Animal
    {
        public string name;
        public int legs;
        public string food;

        static void Main(string[] args)
        {
            Animal a = new Animal();
            a.name = "Cat";
            a.legs = 4;
            a.food = "Milk";
            Console.WriteLine(a.name + " " + a.legs + " " + a.food);

            Animal a1 = new Animal();
            a1.name = "Dog";
            a1.legs = 4;
            a1.food = "Pedigree";
            Console.WriteLine(a1.name + " " + a1.legs + " " + a1.food);
        }


    }
}
