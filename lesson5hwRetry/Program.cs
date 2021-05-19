using System;
using System.Collections.Generic;
using System.Text;

namespace lesson5hwRetry
{
    class Message
    {
        string text;
        char[] separ;
        List<string> col;
        public Message(string text, params char[] separ) // конструктор класса
        {
            this.text = text; // ссылка на переменную 
            this.separ = separ;
            col = new List<string>();
        }
        public string[] FindWords(int n)
        {
            col.Clear(); // очищаем коллекцию перед каждым методом
            var words = text.Split(separ); //разделение текста на слова
           // List<string> col = new List<string>(); // предварительно добавить библиотеку using System.Collections.Generic;
            foreach (var item in words)
            {
                if (item.Length == n)
                {
                    col.Add(item);
                }//Console.WriteLine(item);
            }
            return col.ToArray();
        }
        public string Delete(string sub)
        {
            col.Clear();
            var words = text.Split(separ); //разделение текста на слова
            //List<string> col = new List<string>(); // предварительно добавить библиотеку using System.Collections.Generic;
            foreach (var item in words)
            {
                if (!item.EndsWith(sub)) 
                {
                    col.Add(item);
                }
            }
            return string.Join(separ[0], col);
        }
        public string Find1()
        {
            col.Clear();
            var words = text.Split(separ); //разделение текста на слова
            //List<string> col = new List<string>(); // предварительно добавить библиотеку using System.Collections.Generic;
            string max = String.Empty; // создание пустой строки
            foreach (var item in words)
            {
                if (item.Length > max.Length)
                {
                    max = item;
                }
            }
            return max;
        }
        public StringBuilder FindAllMax()
        {
            var words = text.Split(separ); //разделение текста на слова
            StringBuilder sb = new StringBuilder(); // предварительно добавить using System.Text;
            int max = FindAllMax().Length;
            //foreach (var item in words)
            //{
            //    if (item.Length > max)
            //    {
            //        max = item.Length;
            //    }
            //}
            //sb.AppendJoin(' ', FindWords(max));
            return sb.AppendJoin(' ', FindWords(max));
        }
        class Program
        {
            static void Main(string[] args)
            {
                Message message = new Message("gjdhkjd asjlwoi dius pqiqoi ww gg rr", ' ');
                var res = message.FindWords(2);

                //foreach(var item in res)
                //{
                //    Console.WriteLine(item);
                //}
                Console.WriteLine(message.Delete("i"));
                Console.WriteLine(message.Find1());
                Console.WriteLine(message.FindAllMax().ToString()); // на выходе должна быть строка, а не StringBuilder
            }
        }
    }
}
