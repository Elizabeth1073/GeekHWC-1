using System;

namespace lesson4
{
    //Дан целочисленный  массив из 20 элементов.Элементы массива  могут принимать  целые значения  от –10 000 до 10 000 включительно.
    //    Заполнить случайными числами.
    //    Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3. 
    //    В данной задаче под парой подразумевается два подряд идущих элемента массива.
    //    Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2. 

   
    class Program
    {
        
        static void Main(string[] args)
        {


            int count = 0;
            int[] array = new int[20];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-10000, 10001);
                Console.Write($"{ array[i]}, ");
            }
            for (int i = 0; i < (array.Length - 1); i++)
            {
                if (array[i] % 3 == 0 && array[i + 1] % 3 != 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"Count =  {count}");
            Console.ReadLine();




        }
    }
}
