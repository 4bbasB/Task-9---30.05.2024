using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9___30._05._2024
{
    public class User : IAccount
    {
        private static int Count = 1;
        public static int _id;
        static User()
        {
            Count = 1;
        }
        public User(string email, string password)
        {
            Count++;
            Id = Count;
        }
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        private string _password;

        

        public User(string fullname, string email, string password)
        {
            Fullname = fullname;
            Email = email;
            Password = password;
        }

        public bool PasswordChecker(string password)
        {
            if (password.Length < 8)
                return false;

            bool hasUpper = false;
            bool hasLower = false;
            bool hasDigit = false;

            foreach (char ch in password)
            {
                if (char.IsUpper(ch)) hasUpper = true;
                if (char.IsLower(ch)) hasLower = true;
                if (char.IsDigit(ch)) hasDigit = true;
            }

            bool returner()
            {
                if (hasUpper == false ) return false;
                if (hasLower == false ) return false;
                if (hasDigit == false ) return false;
                else return true;
            }
            return returner();
        }

        public string Password
        {
            get { return _password; }
            set
            {
                if (PasswordChecker(value))
                    _password = value;
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"ID: {Id}, Fullname: {Fullname}, Email: {Email}");
        }
    }
}