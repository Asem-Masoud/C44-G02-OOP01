using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP01
{

    [Flags]
    public enum Permissions
    {
        None = 0,
        Read = 1,
        Write = 2,
        Delete = 4,
        Execute = 8,
        Full = Read | Write | Delete | Execute
    }

    internal class Employee2
    {
        // Properties
        public int ID { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public Permissions Permission { get; set; }

        // Default Constructor
        public Employee2()
        {
            ID = 0;
            Name = "Unknown";
            Role = "Unknown";
            Permission = Permissions.None;
        }

        // Parameterized Constructor
        public Employee2(int id, string name, string role, Permissions permission)
        {
            ID = id;
            Name = name;
            Role = role;
            Permission = permission;
        }

        // Method to display employee Information

        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {ID}, Name: {Name}, Role: {Role}, Permissions: {Permission}");
        }




    }
}
