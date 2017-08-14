using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBank;

namespace Accounting_system
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu = -1;
            int admMenu = -1;
            int nomer;
            bool passReal = true;
            string menuString;
            CleverMas NotRealUsers = new CleverMas();
            CleverMas RealUsers = new CleverMas();
            User user = new User();
            Admin admin = new Admin();
            do
            {
                if (menu == -1)
                {
                    //CleverMas NP = new CleverMas();
                    //User a = new User();
                    //a.SetLogin(Console.ReadLine());
                    //NP.Add(a);
                    //Console.ReadLine();
                    Console.WriteLine("Выберите действие: ");
                    Console.WriteLine("1 - Войти как администратор");
                    Console.WriteLine("2 - Войти как пользователь");
                    Console.WriteLine("3 - Подать заявку на регистрацию");
                    Console.WriteLine("0 - Выход из системы");
                    Console.Write("Команда - ");
                    menuString = Console.ReadLine();
                    menu = Int32.Parse(menuString);
                }

                if (menu == 1)
                {
                    Console.WriteLine("Введите логин: ");
                    string strLog;
                    strLog = Console.ReadLine();

                    Console.WriteLine("Введите пароль:");
                    string strPass;
                    strPass = Console.ReadLine();

                    if (admin.CheckLogin(strLog) && admin.CheckPass(strPass)) // проверка
                    {
                        do
                        {

                            if (admMenu == -1)
                            {

                                Console.WriteLine("Выберите действие: ");
                                Console.WriteLine("1 - Рассмотреть заявки");
                                Console.WriteLine("2 - Показать всех пользователей");
                                menuString = Console.ReadLine();
                                admMenu = Int32.Parse(menuString);
                            }

                            else if (admMenu == 1)
                            {
                                NotRealUsers.Show();
                                Console.WriteLine("3 - Удалить пользователя");
                                Console.WriteLine("4 - Одобрить пользователя");
                                menuString = Console.ReadLine();
                                admMenu = Int32.Parse(menuString);

                                if (admMenu == 3)
                                {
                                    Console.WriteLine("Введите номер пользователя: ");
                                    menuString = Console.ReadLine();
                                    nomer = Int32.Parse(menuString);

                                }

                                else if (admMenu == 4)
                                {

                                }
                            }

                            else if (admMenu == 2) { }
                        } while (admMenu != 0);
                    }

                }



                if (menu == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Добро пожаловать!");

                    Console.WriteLine("Введите Ваше имя: ");
                    string strName = Console.ReadLine();
                    user.SetName(strName);

                    Console.WriteLine("Введите Вашу фамилию: ");
                    string strSurname = Console.ReadLine();
                    user.SetSurname(strSurname);

                    Console.WriteLine("Введите Ваш номер телефона: ");
                    string strTel = Console.ReadLine();
                    user.SetTel(strTel);

                    Console.WriteLine("Введите логин: ");
                    string strLog = Console.ReadLine();
                    user.SetLogin(strLog);

                    do
                    {
                        Console.WriteLine("Введите пароль: ");
                        string strPass = Console.ReadLine();

                        Console.WriteLine("Подтвердите пароль: ");
                        string strPass2 = Console.ReadLine();

                        if (strPass == strPass2)
                        {
                            user.SetPassword(strPass);
                            passReal = false;
                        }
                        else
                        {
                            Console.WriteLine("Проверьте правильность введенных данных!");
                        }
                    } while (passReal);

                    NotRealUsers.Add(user);
                    menu = -1;
                }

                else
                {
                    Console.WriteLine("Неверное имя пользователя или пароль");
                    menu = -1;
                }

            } while (menu != 0);

        }
    }
}
