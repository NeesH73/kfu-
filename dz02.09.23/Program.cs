using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz02._09._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1: написать мир труд май");
                Console.WriteLine("Мир Труд Май");
                Console.WriteLine("Мир");
                Console.WriteLine("    Труд ");
                Console.WriteLine("         Май");
            Console.WriteLine("Задание 2: поменять местами переменные");
                Console.Write("Введите первую переменную:");
                string ch1=Console.ReadLine();
                Console.Write("Введите вторрую переменную:");
                string ch2=Console.ReadLine();
                Console.WriteLine($"{ch2} {ch1}");
            Console.WriteLine("Задание 3: вывести длину и площадь окружности");
                Console.Write("Введите радиус окружности: ");
                double r =int.Parse(Console.ReadLine());
                Console.WriteLine("Длина окружности = " + 2 * Math.PI * r);
                Console.WriteLine("Площадь окружности = " + Math.PI * r*r);
            Console.WriteLine("Задание 4: Вывести косинус ");
                Console.Write("Введите угол: ");
                double ugl = int.Parse(Console.ReadLine());
                Console.WriteLine("y = " + Math.Cos(ugl));
            Console.WriteLine("Задание 5:Найти корни кв. ур-ия  ");
                Console.Write("Введите значение а: ");
                double a = int.Parse(Console.ReadLine());
                Console.Write("Введите значение b: ");
                double b = int.Parse(Console.ReadLine());
                Console.Write("Введите значение c: ");
                double c = int.Parse(Console.ReadLine());
                double D=b*b-4*a*c; // нахождение дискриминанта
                if (D < 0)
                {
                    Console.WriteLine("Нет корней");
                }
                else
                {
                    double x1 = (-1 * b + Math.Sqrt(D)) / 2 * a;
                    double x2 = (-1 * b - Math.Sqrt(D)) / 2 * a;
                    Console.WriteLine("Корни:" + $"{ x1} { x2}");
                }
            Console.WriteLine("Задание 6: обменять значение переменных  ");
                Console.Write("Введите значение а: ");
                double a6=int.Parse(Console.ReadLine());
                Console.Write("Введите значение b: ");
                double b6= int.Parse(Console.ReadLine());
                Console.Write("Введите значение c: ");
                double c6= int.Parse(Console.ReadLine());
                double a1, a2, b1, b2, c1, c2;
                b1 = c6; a1 = b6; c1 = a6;
                b2 = a6; c2 = b6; a2 = a6;
                Console.WriteLine("a) " + " a= " + a1 + " b= " + b1 + " c= " + c1);
                Console.WriteLine("b) " + " a= " + a2 + " b= " + b2 + " c= " + c2);
            Console.WriteLine("Задание 7: вывести 4 случайных числа  ");
                Random rnd = new Random();
                int chislo1 = rnd.Next();
                int chislo2 = rnd.Next();
                int chislo3 = rnd.Next();
                int chislo4 = rnd.Next();
                Console.WriteLine("1-ое число " + chislo1);
                Console.WriteLine("2-ое число " + chislo2);
                Console.WriteLine("3-е число " + chislo3);
                Console.WriteLine("4-ое число " + chislo4);
            Console.WriteLine("Задание 8: из 3-ч знач. числа послед. цифру поставить на 1 место ");
                Console.Write("Введите 3-х знач. число ");
                int trex = int.Parse(Console.ReadLine());
                int posl = trex % 10;
                int prom = (trex - posl) / 10;
                int itog = posl * 100 + prom;
                Console.WriteLine("конечное число "+itog);
            Console.WriteLine("Задание 9: Найти стоимомть покупки  ");
                Console.Write("Стоимость 1кг конфет: ");
                double cenakon = int.Parse(Console.ReadLine());
                Console.Write("Стоимость 1кг печенья: ");
                double cenapech = int.Parse(Console.ReadLine());
                Console.Write("Стоимость 1кг яблок: ");
                double cenayabl = int.Parse(Console.ReadLine());
                Console.Write("кол-во кг конфет: ");
                double kolkon = int.Parse(Console.ReadLine());
                Console.Write("кол-во кг печ.: ");
                double kolpech = int.Parse(Console.ReadLine());
                Console.Write("кол-во кг ябл.: ");
                double kolyabl = int.Parse(Console.ReadLine());
                double cena = cenakon * kolkon + cenapech * kolpech + cenayabl * cenayabl;
                Console.WriteLine("Итоговая сумма: " + cena);




















        }
    }
}
