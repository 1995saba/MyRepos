using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBank
{
    public class User
    {
        public string login;
        public string password;
        public string name;
        public string surname;
        public int telephone;

        public User() { }

        public void SetLogin(string newLogin)
        {
            login = newLogin;
        }

        public string GetLogin()
        {
            return login;
        }
        
        public void SetPassword(string newPassword)
        {
            password = newPassword;
        }

        public string GetPassword()
        {
            return password;
        }
                
        public void SetName(string newName)
        {
            name = newName;
        }

        public string GetName()
        {
            return name;
        }

        public void SetSurname(string newSurname)
        {
            surname = newSurname;
        }

        public string GetSurname()
        {
            return surname;
        }
               
        public void SetTel(string newTel)
        {
            telephone = Int32.Parse(newTel);
        }

        public int GetTel()
        {
            return telephone;
        }

    }
}
