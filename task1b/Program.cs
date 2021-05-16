using System;
using System.Text.RegularExpressions;

namespace task1b
{
    //б) ** с использованием регулярных выражений.
    class Program
    {
        public static bool value = false;
        public static string pattern = @"\w";
        public static Regex regex = new Regex(pattern);
        static string CheckValue(bool value)
        {
            if (value == true) return "Логин корректный";
            else return "Логин некорректный";

        }
        static void CheckLogin(string login)
        {
            if (login.Length >= 2 && login.Length <= 10)
            {
                for (int i = 0; i < login.Length; i++)
                {
                    if (regex.Match(login).Success && Char.IsLetter(login[0])) // если совпадение удачно
                    {
                        value = true;

                    }
                    else
                    {
                        value = false;

                    }
                }
            }
            else
            {
                Console.WriteLine("Логин должен содержать от 2 до 10 символов");
            }

        }
        static void Main(string[] args)
        {
          
            Console.WriteLine("Введите логин");
            string login = Console.ReadLine();
          

            CheckLogin(login);
            Console.WriteLine(CheckValue(value));
            Console.ReadLine();
        }
    }
}
