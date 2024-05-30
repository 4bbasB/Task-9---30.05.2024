using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9___30._05._2024
{
    internal interface IAccount
    {
        public bool PasswordChecker(string password);

        public void ShowInfo();
    }
}
