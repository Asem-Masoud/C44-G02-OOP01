using System;

namespace Demo_OOP01
{
    /*
     * Class
     * Struct
     * Interface
     * Enum
     */
    internal class Program
    {
        static void Main()
        {
            #region 01. Struct
            ////Struct: Value Types: STACK


            ////Employee
            ////Id, name, age, address

            //// Point


            //Point P01;

            //// Declare For Object From Type 'Point '
            //// POI: Object
            ////Allocate UnInitialized 8 Bytes at STACK

            ////Console.WriteLine(P01.X);
            ////Console.WriteLine(P01.Y);


            ////P01.X = 12;
            ////P01.Y = 34;

            ////Console.WriteLine(P01.X);
            ////Console.WriteLine(P01.Y);

            //P01 = new Point(1, 2);
            ////new : Used For Select The Constructor

            ////Console.WriteLine(P01.X);
            ////Console.WriteLine(P01.Y);

            ////Console.WriteLine(P01);//Demo_OOP01.Point
            ////Console.WriteLine(P01);//Demo_OOP01.Point
            //P01.PrintPoint();

            //Console.WriteLine(P01.ToString());//Demo_OOP01.Point
            //Console.WriteLine(P01.ToString());//(1,2) -> After Overrides

            //Console.WriteLine(P01);//(1,2) 
            #endregion

            #region 02 OOP Overview

            // OOP: Object Oriented Programming
            // Programming Paradigm
            // OOP : the Paradigm Use For Build Any Business 

            // Class : Blueprint of Object
            // Object : Specific Instance of Class

            // 4 Pillars of OOP
            /*
             *  1. Encapsulation: Hiding the internal state and requiring all interaction to be performed through an object's methods.
             *  2. Inheritance: Mechanism where a new class can inherit properties and methods from an existing class.
             *  3. Polymorphism: Ability to present the same interface for different underlying data types.
             *  4. Abstraction: Hiding complex implementation details and showing only the essential features of the object.
             *  محتاج أأكد التعريفات دي
             */
            #endregion

            #region 03 Encapsulation using Setter Getter Methods

            //  1. Encapsulation: Separate the data (attributes) Definition From Its Use
            //  [Setter Getter Method - Properties] .
            //  For Class Or Struct. 

            //Employee -> Id, Name, Salary


            // 1. End User Access data itself
            // 2. No Data Validation
            // 3. No Read Only Field


            //Apply Encapsulation
            // 1. Make All Attributes Private
            // 2. Access Data Through :
            // 2.1. Setter Getter Method
            // 2.2 . Properties
            //Employee E01 = new Employee();
            //E01.id = 1;
            //E01.name = "Ahmed";
            //E01.salary = 12000;

            //Console.WriteLine(E01.id);
            //Console.WriteLine(E01.name);
            //Console.WriteLine(E01.salary);

            // After  the Setter Getter Method
            //E01.SetId(1);
            //E01.SetName("Ahmed");
            //E01.SetSalary(12000);

            //Console.WriteLine(E01.GetId());
            //Console.WriteLine(E01.GetName());
            //Console.WriteLine(E01.GetSalary());

            // After Constructor

            //Employee E01 = new Employee(1, "Ahmed", -12000);

            //Console.WriteLine(E01.GetId());
            //Console.WriteLine(E01.GetName());
            //Console.WriteLine(E01.GetSalary());


            //After To String Method
            //Employee E01 = new Employee(1, "Ahmed", -12000);
            //Console.WriteLine(E01);

            // After Comment SetId
            // Id : Read Only Attribute
            //E01.GetId();

            #endregion

            #region 04 Encapsulation using Properties

            //Employee E01 = new Employee();

            //E01.Id = 1;

            //E01.Name = "Ahmed";

            //E01.Salary = 120;

            //E01.Address = "Cairo";

            //Console.WriteLine(E01.Id);
            //Console.WriteLine(E01.Name);
            //Console.WriteLine(E01.Salary);
            //Console.WriteLine(E01.Address);



            #endregion

            #region 05 Indexer

            ////Indexer: Special Property

            //// PhoneBook :
            //Phonebook phoneBook = new Phonebook(3);

            //phoneBook.AddPerson("Ahmed", 1234567890, 0);
            //phoneBook.AddPerson("Ali", 1234568891, 1);
            //phoneBook.AddPerson("Asem", 1234768892, 2);

            ////Console.WriteLine(phoneBook.GetNumber("Ahmed")); // Output: 1234567890  
            ////Console.WriteLine(phoneBook.GetNumber("Mohamed")); // Output: -1 -> Not Found

            ////phoneBook.UpdateNumber("Ahmed", 9876543210);
            ////Console.WriteLine(phoneBook.GetNumber("Ahmed")); // Output: 9876543210

            ////Console.WriteLine(phoneBook.GetName(1234568891)); // Output: Ali

            ////phoneBook.UpdateName(1234568891, "Asem");
            ////Console.WriteLine(phoneBook.GetName(1234568891)); // Output: Asem

            //Console.WriteLine(phoneBook["Ahmed"]);
            //// Indexer
            //phoneBook["Ahmed"] = 11111;

            //Console.WriteLine(phoneBook["Ahmed"]); // Output: 11111

            //Console.WriteLine(phoneBook[11111]); // Output: Ahmed

            #endregion

        }
    }
}