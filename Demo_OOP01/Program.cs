using System;
using System.ComponentModel;

namespace Demo_OOP01
{
    internal class Program
    {

        static void Main()
        {
            #region Q1P01

            ////1.Create a struct called "Point" to represent a 2D point with properties "X" and "Y".
            ////Write a C# program that takes two points as input from the user and calculates the distance between them. 


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


        }
    }
}