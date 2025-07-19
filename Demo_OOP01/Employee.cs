using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP01
{
    internal class Employee // Camal Case
    {
        private int id;
        private string name;
        private double salary;
        // Address

        #region Apply Encapsulation User Setter Getter Method

        // Apply Encapsulation User Setter Getter Method

        // Setter 

        //public void SetId(int id)
        //{
        //    this.id = id;
        //}

        //// Getter
        //public int GetId()
        //{
        //    return id;
        //}

        //// Setter
        //public void SetName(string name)
        //{
        //    if (name.Length >= 8 && name.Length <= 20)
        //        this.name = name;
        //}
        //// Getter
        //public string GetName()
        //{
        //    return name;
        //}
        //// Setter
        //public void SetSalary(double salary)
        //{
        //    if (salary > 0)
        //        this.salary = salary;
        //}
        //// Getter
        //public double GetSalary()
        //{
        //    return salary;
        //}

        #endregion


        #region Apply Encapsulation User Properties 

        // Apply Encapsulation User Properties [Recommended]
        // 1 Full Property -> if found Logic

        //ID
        public int Id //Pascal
        {
            // set
            // get
            set
            {
                id = value; // value : is a keyword used in properties to refer to the value being assigned.
            }
            get
            {

                return id;
            }
        }

        //Name
        public string Name
        {
            set
            {
                if (value.Length >= 8 && value.Length <= 20)
                    name = value;
            }
            get
            {
                return name;
            }
        }

        //Salary
        public double Salary
        {
            set
            {
                if (value > 0)
                    salary = value;
            }
            get
            {
                return salary;
            }
        }


        // 2. Auto Property -> No Logic Found

        // Don't ned to create a private attribute
        public string Address { get; set; } // Auto Property

        // 3. Special Property [Indexer]



        #endregion

        //// Constructor

        //public Employee(int id, string name, double salary)
        //{
        //    this.id = id;
        //    this.name = name;
        //    this.salary = salary;
        //}


        //// Constructor 2
        //public Employee(int id, string name, double salary)
        //{
        //    //SetId(id);
        //    SetName(name);
        //    SetSalary(salary);
        //}

        //// ToString Method
        //public override string ToString()
        //{
        //    return $"Id: {id} :: Name: {name} ::: Salary: {salary}";
        //}


    }
}
