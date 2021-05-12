using System;

namespace task2
{
//    Реализуйте задачу 1 в виде статического класса StaticClass;
//а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;

    class MyArray
    {
        int[] array;

        public MyArray()
        {
            array = new int[20];
        }

        public int Count { get { return array.Length; } }
        public int this[int index, int item]
        {

            get { return array[index]; }
            set { array[index] = item; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyArray Num = new MyArray();

            int count1 = 0;
            Random rnd = new Random();
            for (int i = 0; i < Num.Count; i++)
            {
                Num[i, rnd.Next(-10000, 10001)] = rnd.Next(-10000, 10001);
                Console.Write($"{ Num[i, rnd.Next(-10000, 10001)]}, ");
            }
            for (int i = 0; i < (Num.Count - 1); i++)
            {
                if (Num[i, rnd.Next(-10000, 10001)] % 3 == 0 && Num[i + 1, rnd.Next(-10000, 10001)] % 3 != 0)
                {
                    count1++;
                }
            }
            Console.WriteLine($"Count =  {count1}");
            Console.ReadLine();
        }
    }
}
