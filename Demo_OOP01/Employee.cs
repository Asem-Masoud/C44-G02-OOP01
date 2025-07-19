using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP01
{
    internal class Employee
    {
        private int id;
        private string name;
        private double salary;

        // Apply Encapsulation User Setter Getter Method

        // Setter 

        //public void SetId(int id)
        //{
        //    this.id = id;
        //}

        // Getter
        public int GetId()
        {
            return id;
        }

        // Setter
        public void SetName(string name)
        {
            if (name.Length >= 8 && name.Length <= 20)
                this.name = name;
        }
        // Getter
        public string GetName()
        {
            return name;
        }
        // Setter
        public void SetSalary(double salary)
        {
            if (salary > 0)
                this.salary = salary;
        }
        // Getter
        public double GetSalary()
        {
            return salary;
        }

        // Constructor
        //public Employee(int id, string name, double salary)
        //{
        //    this.id = id;
        //    this.name = name;
        //    this.salary = salary;
        //}


        // Constructor 2
        public Employee(int id, string name, double salary)
        {
            //SetId(id);
            SetName(name);
            SetSalary(salary);
        }

        // ToString Method
        public override string ToString()
        {
            return $"Id: {id} :: Name: {name} ::: Salary: {salary}";
        }


    }
}
