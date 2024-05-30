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

            bool hasUpper = false;
            bool hasDigit = false;

            foreach (char ch in groupNo)
            {
                if (ch == 0 && ch == 1)
                    if (char.IsUpper(ch))
                        hasUpper = true;
                    else
                    if (char.IsUpper(ch))
                        hasDigit = true;
            }

            bool returner()
            {
                if (hasUpper == false) return false;
                if (hasDigit == false) return false;
                else return true;
            }
            return returner();
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
            //for (int i = 0; i < studentCount; i++)
            //{
            //    if (i == id)
            //    {
            //        return Students[i];
            //    }
            //    if (Students[i].Id == id)
            //    {
            //        return Students[i];
            //    }
            //}

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
