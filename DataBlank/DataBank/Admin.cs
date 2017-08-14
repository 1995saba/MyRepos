using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DataBank
{
    public class Admin
    {
        public string login = "Admin";
        public string password = "Admin";

        public bool CheckLogin(string newLogin)
        {
            if (newLogin.Equals(login))
                return true;
            else
                return false;
        }
        public bool CheckPass(string newPass)
        {
            if (newPass.Equals(password))
                return true;
            else
                return false;
        }

        public string GetLogin()
        {
            return login;
        }

        public void SetPassword(string newPassword)
        {
            if (newPassword == password)
                newPassword = password;
            else
                WriteLine("Неверный пароль!");
        }

        public string GetPassword()
        {
            return password;
        }

    }
}
