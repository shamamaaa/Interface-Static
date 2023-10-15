using System;
using System.Xml.Linq;
using Interface_Static_Task1.Interfaces;

namespace Interface_Static_Task1.Models
{
    public class Student : ICodeAcademy

	{

        private static int Count = 0;

        public int ID { get; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CodeEmail { get; set; }


        public Student(string name, string surname)
        {

            ID = ++Count;
            Name = name;
            Surname = surname;
            GenerateEmail();
        }

        public static bool CheckName(string input)
        {
            if (input.Length < 3 || input.Length > 25)
                return false;

            else if (!CheckLetters(input))
                return false;

            return true;

        }

        public static bool CheckLetters(string input)
        {
            foreach (char letter in input)
            {
                if (!char.IsLetter(letter))
                    return false;
            }
            return true;
        }


        public void GenerateEmail()
        {
            CodeEmail = $"{Name.ToLower()}.{Surname.ToLower()}{ID}@code.edu.az";
        }

    }
}

