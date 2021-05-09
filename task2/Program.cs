using System;

namespace task2
{
    //С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). 
    //Требуется подсчитать сумму всех нечётных положительных чисел.Сами числа и сумму вывести на экран, используя tryParse.

    class Program
    {
        public int sum;
        public int number;

        public void Print(int sum)
        {
            Console.WriteLine("Сумма всех нечётных положительных чисел равна {0}", sum);
        }
        public int CountSum(int number)
        {
            do
            {
                Console.WriteLine("Введите число ");
                number = int.Parse(Console.ReadLine());
                if (number > 0 && number % 2 != 0)
                {
                    sum += number;
                }
            } while (number != 0);
            return sum;
        }

        static void Main(string[] args)
        {
            Program pro = new Program();

            pro.CountSum(pro.number);
            pro.Print(pro.sum);

            Console.ReadLine();

        }
    }
    
}
