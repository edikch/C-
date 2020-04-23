using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    #region Описание 
 //    Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
 //   а) используя склеивание;
 //   б) используя форматированный вывод;
//в) используя вывод со знаком $.
 //   Исполнитель: Чимитцыденов Э.Р.
         
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте!");
            Console.Write("Введите Ваше имя:");
            String name = Console.ReadLine();

            Console.Write("Введите Вашу фамилию:");
            String fullname = Console.ReadLine();

            Console.Write("Введите Ваш возраст:");
            String age = Console.ReadLine();

            Console.Write("Введите Ваш рос:");
            String  length= Console.ReadLine();

            Console.Write("Введите Ваш вес:");
            String mass = Console.ReadLine();

            Console.WriteLine("Вы ввели данные-"+$" Имя:{name:G}, Фамилия: { fullname:G}, Возраст:{ age:D}, Рост:{ length:D}, Масса:{ mass:D}");

            Console.ReadKey();
        }
    }
}
