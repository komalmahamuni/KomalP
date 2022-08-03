using System;
using System.Collections.Generic;
using System.Text;

namespace KomalP.Programes
{
    class Department
    {
        public int id;
        public string name;

        public Department(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public void showDepartment()
        {
            Console.WriteLine(" " + id + " "+name);
        }
    }








   class Employee
    {
        int id;
        string name;
        int salary;
        Department dep;

        Employee(int id,string name,int salary,Department dep)
        {
            this.id = id;
            this. name = name;
            this.salary = salary;
            this.dep = dep;
        }
        void DisplayEmployee()
        {
            Console.WriteLine(id + " " + name + " " + salary);
            dep.showDepartment();
        }
        static void Main(string[] args)
        {
            Employee e = new Employee(1, "Pooja", 20000, new Department(101, "Computer"));
            e.DisplayEmployee();
        }
    }
}
