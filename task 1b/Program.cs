using System;

namespace task_1b
{
     //Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
     //в) Добавить диалог с использованием switch демонстрирующий работу класса.

    namespace ConsoleApp1
    {
        class Complex
        {

            public double re;
            public double im;

            public Complex(double re, double im)
            {
                this.re = re;
                this.im = im;
            }

            public Complex Substract(Complex q, Complex w)
            {
                return new Complex(q.re - w.re, q.im - q.re);
            }

            public Complex Mult(Complex q, Complex w)
            {
                return new Complex(q.re * w.re, q.im * w.im);
            }

            public void PrintS()
            {
                Console.WriteLine($"{re} - {im}i");
            }
            public void PrintM()
            {
                Console.WriteLine($"{re} * {im}i");
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Complex Comp = new Complex(2, 2);
                Complex Comp1 = new Complex(3, 3);
                Comp.Substract(Comp, Comp1);
                Comp.PrintS();
                Comp.Mult(Comp, Comp1);
                Comp.PrintM();

                Console.ReadLine();
            }
        }
    }


   
}
