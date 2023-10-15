using Interface_Static_Task3.Models;

namespace Interface_Static_Task3;
class Program
{
    static void Main(string[] args)
    {
        Group group1 = new Group("AB104");
        Group group2 = new Group("AB105");

        group1.AddStudent(new Student("Samama", "Guliyeva"));
        group1.AddStudent(new Student("Sabuhi", "Camalzade"));
        group1.AddStudent(new Student("Zulfiyya", "Qurbanova"));
        group1.AddStudent(new Student("Sabir", "Quliyev"));

        group2.AddStudent(new Student("Said", "Suleymanov"));
        group2.AddStudent(new Student("Amirxan", "Memmedov"));
        group2.AddStudent(new Student("Lale", "Humbetova"));
        group2.AddStudent(new Student("Tural", "Shixiyev"));

        Group.AddGroup(group1);
        Group.AddGroup(group2);

        Group.ShowAllGroups();

        //Student student = group1.GetStudent(9);
        //if (student != null)
        //    student.GetInfo();
        //else
        //    Console.WriteLine("Telebe tapilmadi.");

        //group1.Search("Li");

        //group2.Students = group2.RemoveStudent(5);
        //group2.ShowStudents();

    }
}

