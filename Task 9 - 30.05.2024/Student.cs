using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9___30._05._2024
{
    public class Student
    {
        private static int Count = 0;
        public string Fullname { get; set; }
        public double Point { get; set; }

        public static int _id;
        public int Id { get; set; }

        static Student()
        {
            Count = 0;
        }
        public Student(string Fullname, double point)
        {
            Count++;
            Id = Count;
        }
        

        public void StudentInfo()
        {
            Console.WriteLine($"ID: {Id}, Fullname: {Fullname}, Point: {Point}");
        }
    }
}
