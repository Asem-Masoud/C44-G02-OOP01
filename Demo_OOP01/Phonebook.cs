using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP01
{
    internal struct Phonebook
    {
        string[] names;
        long[] numbers;

        public Phonebook(int size)
        {
            names = new string[size];
            numbers = new long[size];
        }


        public void AddPerson(string name, long number, int index)
        {
            names[index] = name;
            numbers[index] = number;

        }

        public long GetNumber(string name)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == name)
                    return numbers[i];
            }
            return -1; // Return -1 if the name is not found
        }

        public void UpdateNumber(string name, long newNumber)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == name)
                    numbers[i] = newNumber;

            }
        }

        public string GetName(long number)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == number)
                    return names[i];
            }
            return null; // Return null if the number is not found
        }

        public void UpdateName(long number, string newName)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (numbers[i] == number)
                    names[i] = newName;

            }
        }


    }
}

