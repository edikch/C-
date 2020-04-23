using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Task6
{
    class MyClass
    {
        public void Print(string ms, int x,int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(ms);
        }

        public void Pause()
        {
            Console.ReadKey();
        }
    }
    class Program
    {
        //6. *Создать класс с методами, которые могут пригодиться в вашей учебе(Print, Pause).
        //Исполнитель: Чимитцыденов Э.Р.
        static void Main(string[] args)
        {


            MyClass p = new MyClass();
            p.Print("Я изучаю C#",10,10);
            p.Pause();
        }
    }
}
