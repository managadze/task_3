using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    class Program
    {
        static void Color(string txt)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(txt);
            Console.ResetColor();
        }

        static void Main(string[] args)
        {
            double y = 0, x = 0;
            bool ok = false;
            do
            {
                Color("Введите х:");
                try  // Ввод переменной x
                {
                    ok = true;
                    x = double.Parse(Console.ReadLine());
                }
                catch
                {
                    ok = false;
                    Console.WriteLine("Ошибка, повторите ввод");
                }
            } while (!ok);

            Color("Введите у:");
            do
            {
                try  // Ввод переменной y
                {
                    ok = true;
                    y = double.Parse(Console.ReadLine());
                }
                catch
                {
                    ok = false;
                    Console.WriteLine("Ошибка, повторите ввод");
                }
            } while (!ok);

            if ((y <= -2 * x + 1) && (y <= 2 * x + 1) && (y >= -2 * x - 1) && (y >= 2 * x - 1))
                Console.WriteLine($"Точка ({x};{y}) принадлежит данной области");
            else Console.WriteLine($"Точка ({x};{y}) не принадлежит данной области");

            Console.Read();
        }
    }
}
