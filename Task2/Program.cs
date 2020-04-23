using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    //Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле I=m/(h* h); где m — масса тела в килограммах, h — рост в метрах.
    //Исполнитель: Чимитцыденов Э.Р.
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Введите массу тела в килограммах: ");
            int m=Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите рос в метрах: ");
            int h = Convert.ToInt32(Console.ReadLine());

            double I = (m / Math.Pow(h, 2));
            Console.WriteLine("Индекс массы тела составляет: "+$"{I:G2}") ;
            Console.ReadKey();
        }
    }
}
