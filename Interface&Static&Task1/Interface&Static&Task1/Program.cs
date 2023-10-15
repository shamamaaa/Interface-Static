using System.Xml.Linq;
using Interface_Static_Task1.Models;

namespace Interface_Static_Task1;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nece telebe daxil edilecek?");
        int count = int.Parse(Console.ReadLine());

        Student[] students = new Student[count];


        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Ad daxil edin:");
            string name = Console.ReadLine().Trim();
            Console.WriteLine("Soyad daxil edin:");
            string surname = Console.ReadLine().Trim();

            if (Student.CheckName(name) && Student.CheckName(surname))
            {
                students[i] = new Student(name, surname);
                Console.WriteLine($"{students[i].ID}-IDli telebe ucun email yaradildi\nEmail: {students[i].CodeEmail}");
            }
            else
            {
                Console.WriteLine("Yanlis ad ve ya soyad daxil edildi.");
                i--;

            }
        }


        //Console.WriteLine("Yaradilan emailler:");
        //for (int i = 0; i < count; i++)
        //{
        //        Console.WriteLine($"{students[i].ID}: {students[i].CodeEmail}");
        //}

    }

}

