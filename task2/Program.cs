using System;
using System.Linq;
using System.Text;

namespace task2
{
<<<<<<< HEAD
    //Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
    //а) Вывести только те слова сообщения, которые содержат не более n букв.
    //б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
    //в) Найти самое длинное слово сообщения.
    //г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
    //д) *** Создать метод, который производит частотный анализ текста.
    //В качестве параметра в него передается массив слов и текст, в качестве результата метод возвращает
    //сколько раз каждое из слов массива входит в этот текст.
    //Здесь требуется использовать класс Dictionary.
    class Message
    {
        public static bool value = false;
        public static string[] SepText;
        public static string text = "молоко овощи погода небо ппоаоадводаодвоа";

        public static string[] CountMessage(string text, char charToTrim)
        {
            return SepText = text.Split(' ');
        }

        public static string[] TrimMessage(string text, char charToTrim) // вот тут я не понимаю, что не так, какие значения ещё хочет возвращать этот метод
        {
            for (int i = 0; i < SepText.Length; i++)
            {
                if (SepText[i].EndsWith(charToTrim))
                    return SepText[i].Trim(charToTrim);
            }



        }
        class Program
        {


            static void Main(string[] args)
            {
                Message mes = new Message();

                int n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите символ, который хотите удалить из всех строк");
                char charToTrim = Convert.ToChar(Console.ReadLine());

                //text1 = "молоко овощи погода небо ппоаоадводаодвоа";



                mes.CountMessage(text, charToTrim); // здесь как-то некорректно вызывается метод, говорит, что нужно указать имя типа



                // удаление последнего символа из каждой строки
                //for (int i = 0; i < SepText.Length; i++)
                //{

                //    if (SepText[i].EndsWith(charToTrim))
                //        Console.WriteLine(SepText[i].Trim(charToTrim));
                //}

                // вывод слов определенной длины
                //for (int i = 0; i < SepText.Length; i++)
                //{

                //    if (SepText[i].Length <= n)
                //    {
                //        value = true;
                //        Console.WriteLine(SepText[i]);
                //    }
                //if (SepText[i].EndsWith(charToTrim))
                //Console.WriteLine(SepText[i].Trim(charToTrim));

                // }
                //if (value == false)
                //    Console.WriteLine("wrong number");





                //Console.WriteLine("Самая длинная строка: " + SepText.Max());

                //StringBuilder str = new StringBuilder();
                //str.Append(" 111");
                //Console.WriteLine(str);

                Console.ReadLine();
            }
=======
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
>>>>>>> lesson4
        }
    }
}

