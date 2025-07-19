using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP01
{
    public enum SecurityLevel
    {
        Guest,
        Developer,
        Secretary,
        DBA
    }
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private char gender;
        public char Gender
        {
            get { return gender; }
            set
            {
                if (value == 'M' || value == 'F')
                    gender = value;
                else
                    throw new ArgumentException("Gender must be 'M' or 'F'");
            }
        }

        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }
        public SecurityLevel Security { get; set; }

        public Employee(int id, string name, SecurityLevel securityLevel, decimal salary, DateTime hireDate, char gender)
        {
            Id = id;
            Name = name;
            securityLevel = securityLevel;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender;
        }
        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Gender: {Gender}, " +
                   $"Security Level: {Security}, Salary: {String.Format("{0:C}", Salary)}, " +
                   $"Hire Date: {HireDate.ToShortDateString()}";
        }


    }
}
