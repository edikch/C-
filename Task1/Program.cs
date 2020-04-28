using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    //1. Написать метод, возвращающий минимальное из трех чисел.
    //Исполнитель: Чимитцыденов Э.Р.

   
    class Program
    {
        static int min(ref int[] x)
        {
            int min;
            if (x[0] < x[1]) min = x[0]; else min = x[1];
            if (min > x[2]) min = x[2]; 
            return min;

        }
        static void Main(string[] args)
        {
            int[] value = { 5, 2, 1 };
            Console.WriteLine(  "Минимальное значение:"+min(ref value));
            Console.ReadKey();
        }
    }
}
