using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
    //а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
    //б) Сделать задание, только вывод организуйте в центре экрана
    //в) *Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y)
    //Исполнитель: Чимитцыденов Э.Р.

        static void Print(string ms, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(ms);
        }

        static void Main(string[] args)
        {
            
            Console.SetWindowSize(50, 30);
            Console.SetBufferSize(50, 30);
            Console.SetCursorPosition(23, 14);
            //Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Эдуард");
            Print("Чимитцыденов", 20, 15);
            Print("г. Улан-Удэ", 20, 16);
            Console.ReadKey();
        }
    }
}
