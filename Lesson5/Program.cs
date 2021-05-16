using System;

namespace Lesson5
{
    //Создать программу, которая будет проверять корректность ввода логина.Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
    //а) без использования регулярных выражений;
    class Program
    {
        public static bool value = false;

        static string CheckValue (bool value)
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
                    if (Char.IsLetterOrDigit(login[i]) && Char.IsLetter(login[0]))
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
        
    
