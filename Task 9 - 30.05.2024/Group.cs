using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9___30._05._2024
{
    public class Group
    {
        public string GroupNo { get; set; }
        public int StudentLimit { get; set; }
        Student[] Students;
        private int studentCount = 0;


        public Group(string groupNo, int studentLimit)
        {
            if (!CheckGroupNo(groupNo))
            {
                Console.WriteLine("Qrup No sehvdir!");
                return;
            }
            if (studentLimit < 5 || studentLimit > 18)
            {
                Console.WriteLine("Student Limit 5 ve 18 arasinda olmalidir");
                return;
            }
            GroupNo = groupNo;
            StudentLimit = studentLimit;
            Students = new Student[StudentLimit];

        }


        public bool CheckGroupNo(string groupNo)
        {
            if (groupNo.Length != 5)
                return false;

            for (int i = 0; i < 2; i++)
            {
                if (!char.IsUpper(groupNo[i]))
                    return false;
            }

            for (int i = 2; i < 5; i++)
            {
                if (!char.IsDigit(groupNo[i]))
                    return false;
            }

            return true;
        }

        public void AddStudent(Student student)
        {
            if (studentCount >= StudentLimit)
                Console.WriteLine("Student Limitini kecmisiniz!");
            else
                Students[studentCount++] = student;
        }

        public Student GetStudent(int? id)
        {
            foreach (var student in Students)
                if (student.Id == id)
                    return student;
            return null;

        }

        public Student[] GetAllStudents()
        {
            return Students;
        }


    }
}
