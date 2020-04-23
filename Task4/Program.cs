using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        //4. Написать программу обмена значениями двух переменных.
        //а) с использованием третьей переменной;
        //б) *без использования третьей переменной.
        //Исполнитель: Чимитцыденов Э.Р.

        static void Swap(ref int x,ref int y)
        {
            int a=x;
            x = y;
            y = a;

        }

        static void SwapVar(ref int x, ref int y )
        {
            x = x ^ y;
            y = y ^ x;
            x = x ^ y;
        }

        static void Main(string[] args)
        {
            int c =10;
            int b = 20;
            Console.WriteLine("c=" + c + " b=" + b);
            Swap(ref c,ref b);
            
            Console.WriteLine("c=" + c + " b=" + b);

            SwapVar(ref c, ref b);
            Console.WriteLine("c=" + c + " b=" + b);

            Console.ReadKey();


           

        }
    }
}
