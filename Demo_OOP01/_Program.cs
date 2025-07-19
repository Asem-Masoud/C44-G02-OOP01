using System;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Reflection.Emit;
using System.Security.Claims;
using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Demo_OOP01
{
    internal class _Program
    {

        static void Main()
        {
            #region Q1P01

            ////1.Create a struct called "Point" to represent a 2D point with properties "X" and "Y".
            ////Write a C# program that takes two points as input from the user and calculates the distance between them. 



            /////////////////////////////////////////////////
            ////Console.WriteLine("Enter coordinates for the first point:");
            ////Console.Write("X1: ");
            ////double x1 = double.Parse(Console.ReadLine());
            ////Console.Write("Y1: ");
            ////double y1 = double.Parse(Console.ReadLine());

            ////Console.WriteLine("\nEnter coordinates for the second point:");
            ////Console.Write("X2: ");
            ////double x2 = double.Parse(Console.ReadLine());
            ////Console.Write("Y2: ");
            ////double y2 = double.Parse(Console.ReadLine());
            /////////////////////////////////////////////////
            //Console.WriteLine("Enter first point (X Y):");
            //string[] parts1 = Console.ReadLine().Split();
            //int x1 = Convert.ToInt32(parts1[0]);
            //int y1 = Convert.ToInt32(parts1[1]);

            //Console.WriteLine("Enter second point (X Y):");
            //string[] parts2 = Console.ReadLine().Split();
            //int x2 = Convert.ToInt32(parts2[0]);
            //int y2 = Convert.ToInt32(parts2[1]);

            //Point point1 = new Point(x1, y1);
            //Point point2 = new Point(x2, y2);

            //double distance = point1.DistanceTo(point2);

            //Console.WriteLine($"\nPoint 1: {point1}");
            //Console.WriteLine($"Point 2: {point2}");
            //Console.WriteLine($"Distance between the points: {distance:F2}");

            #endregion

            #region Q2P01
            //2.Create a struct called "Person" with properties "Name" and "Age".
            //Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.


            //Person[] persons = new Person[3];

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter name of person {i + 1}:");
            //    string name = Console.ReadLine();

            //    Console.WriteLine($"Enter age of person {i + 1}:");
            //    int age = Convert.ToInt32(Console.ReadLine());

            //    persons[i] = new Person { Name = name, Age = age };
            //}

            //Person oldest = persons[0];

            //for (int i = 1; i < persons.Length; i++)
            //{
            //    if (persons[i].Age > oldest.Age)
            //    {
            //        oldest = persons[i];
            //    }
            //}

            //Console.WriteLine($"The oldest person is: {oldest.Name}, Age: {oldest.Age}");

            #endregion

            #region Q1P02

            //1. Design and implement a Class for the employees in a company:
            // Notes:
            //● Employee is identified by an ID, Name, security level, salary, hire date and Gender.
            //● We need to restrict the Gender field to be only M or F[Male or Female]
            //● Assign the following security privileges to the employee(guest,Developer, secretary and DBA) in a form of Enum.
            //● We want to provide the Employee Class to represent Employee data in a string Form(override ToString()),
            //display employee salary in a currency format [Use String.Format() Function].


            //Employee emp1 = new Employee(101, "John Smith", SecurityLevel.Developer, 75000.50m,
            //        new DateTime(2022, 3, 15), 'M');

            //Employee emp2 = new Employee(102, "Sarah Johnson", SecurityLevel.DBA, 85000.00m,
            //    new DateTime(2021, 8, 10), 'F');

            //Employee emp3 = new Employee(103, "Mike Wilson", SecurityLevel.Secretary, 45000.75m,
            //    new DateTime(2023, 1, 20), 'M');

            //Employee emp4 = new Employee(104, "Lisa Brown", SecurityLevel.Guest, 35000.00m,
            //    new DateTime(2023, 6, 5), 'F');

            //Console.WriteLine(emp1.ToString());
            //Console.WriteLine(emp2.ToString());
            //Console.WriteLine(emp3.ToString());
            //Console.WriteLine(emp4.ToString());

            #endregion

            #region Q2P02

            //2. Develop a Class to represent the Hiring Date Data:
            //● Consisting of fields to hold the day, month and Years.

            //HiringDate hiringDate = new HiringDate(15, 3, 2022);
            //Console.WriteLine($"Hiring Date: {hiringDate}");

            #endregion

            #region Q3P02

            //Create an array of Employees with size three a DBA, Guest and the third one is security officer who have full permissions. (Employee [] EmpArr;)
            //Notes:
            //● Implement All the Necessary Member Functions on the Class(Getters, Setters)
            //● Define all the Necessary Constructors for the Class
            //● Allow NO RUNTIME errors if the user inputs any data
            //● Write down all the necessary Properties(Instead of setters and getters)

            //// Create array of employees
            //Employee2[] EmpArr = new Employee2[3];

            //EmpArr[0] = new Employee2(1, "Ali", "DBA", Permissions.Read | Permissions.Write);
            //EmpArr[1] = new Employee2(2, "Omar", "Guest", Permissions.Read);
            //EmpArr[2] = new Employee2(3, "Sara", "Security Officer", Permissions.Full);

            //// Display info
            //foreach (var emp in EmpArr)
            //{
            //    emp.DisplayInfo();
            //}

            #endregion


        }


    }
}
