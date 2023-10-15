using System;
using System.Xml.Linq;
using Interface_Static_Task3.Extension;

namespace Interface_Static_Task3.Models
{
    public class Group
    {
        public static Group[] Groups = new Group[0];
        static int GroupCount = 0;
        public int GroupId { get; }

        private string _groupname;
        public string GroupName
        {
            get { return _groupname; }

            set
            {
                if (value.CheckGroupName())
                {
                    _groupname = value.ToUpper();
                }
            }

        }

        public Student[] Students = new Student[0];

        public Group(string groupname)
        {
            GroupCount++;
            GroupId = GroupCount;
            GroupName = groupname;
        }

        public void GetGroupInfo()
        {
            Console.WriteLine($"{GroupId} nomreli qrup:\nQrup adi:{GroupName} Telebe sayi:{Students.Length}");
        }

        public Student GetStudent(int studentid)
        {
            foreach (Student student in Students)
            {

                if (student.ID == studentid)
                {
                    return student;
                }

            }
            return null;
        }


        public void AddStudent(Student student)
        {
            Array.Resize(ref Students, Students.Length+1);
            Students[Students.Length-1] = student;
        }


        public static void AddGroup(Group group)
        {
            Array.Resize(ref Groups, Groups.Length + 1);
            Groups[Groups.Length-1] = group;
        }


        public void ShowStudents()
        {
            foreach (Student student in Students)
            {
                student.GetInfo();
            }
        }


        public static void ShowAllGroups()
        {
            foreach (Group group in Groups)
            {
                group.GetGroupInfo();
            }
        }

        public void Search(string search)
        {
            Console.WriteLine("Axtarilan telebeler:");
            int count = 0;
            foreach (var student in Students)
            {
                if (student.Name.ToLower().Contains(search.ToLower()) || student.Surname.ToLower().Contains(search.ToLower()))
                {
                    student.GetInfo();
                    count++;
                }
            }
            if (count==0)
            {
                Console.WriteLine("Telebe tapilmadi.");
            }
        }

        public Student[] RemoveStudent(int id)
        {
            Student[] newstudents = new Student[0];

            foreach (Student student in Students)
            {
                if (student.ID!=id)
                {
                    Array.Resize(ref newstudents, newstudents.Length+1);
                    newstudents[newstudents.Length - 1] = student;
                }
            }

            return newstudents;
        }


    }
}

