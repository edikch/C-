using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    //а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
    //б) * Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;
    //Исполнитель: Чимитцыденов Э.Р.
    class Program
    {
        static double Distantion(int x1, int y1, int x2, int y2)
        {
            double r= Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return r;
        }
        static void Main(string[] args)
        {
            int x1 = 100;
            int y1 = 150;
            int x2 = 200;
            int y2 = 300;
            double r = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
            Console.WriteLine("Расстояние между точками R="+$"{r:f2}");

            r = Distantion(100,150,200,300);
            Console.WriteLine("Расстояние между точками R=" + $"{r:f2}");

            Console.ReadKey();
        }
    }
}
