using System;
using Interface_Static_Task3.Extension;

namespace Interface_Static_Task3.Models
{
	public class Student
	{
        private static int Count = 0;
        private string _name;
        private string _surname;


        public int ID { get; }
        public string Name
        {
            get { return _name; }

            set
            {
                if (value.CheckName())
                {
                    _name = value.Capitalize();
                }
            }

        }
        public string Surname
        {
            get { return _surname; }

            set
            {
                if (value.CheckName())
                {
                    _surname = value.Capitalize();
                }
            }

        }

        public Student(string name, string surname)
        {
            Count++;
            ID = Count;
            Name = name;
            Surname = surname;

        }
        public void GetInfo()
        {
            Console.WriteLine($"{ID} nomreli telebe:\nAd:{Name} Soyad:{Surname}");
        }

    }
}

