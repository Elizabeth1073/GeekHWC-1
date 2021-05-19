using System;
using static System.Math;

namespace lesson6
{
    //Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double). 

    //    Продемонстрировать работу на функции с функцией a* x^2 и функцией a* sin(x).

    public delegate double Fun(double x, double a);
    class Program
    {

        public static void Table(Fun F, double x, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x,b));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }

        public static double MyFunc(double x, double a)
        {
            return a * x * x;
        }
        public static double Sin(double x, double a)
        {
            return a * Math.Sin(x);
        }
        static void Main()
        {

            Console.WriteLine("Таблица функции MyFunc:");
            Table(MyFunc, -2, 2); // не удаётся преобразовать тип

            Console.WriteLine("Таблица функции Sin:");
            Table(Sin, -2, 2); // 

        }


    }

}
