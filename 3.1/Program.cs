using System;

namespace _3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер дня");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер месяца");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер года");
            int c = Convert.ToInt32(Console.ReadLine());
            bool vis = false;

            if (((c % 4 == 0) && (c % 100 != 0)) || (c % 400 == 0))
            {
                Console.WriteLine("Количество дней в году - 356");
                vis = true;

            } else Console.WriteLine("Количество дней в году - 355");

            bool flag = false;
            if ((b == 4) || (b == 6) || (b == 9) || (b == 11))
            { 
                Console.WriteLine($"В {b} месяце 30 дней");
                flag = true;
            }
            if (!flag && b != 2) Console.WriteLine($"В {b} месяце 31 день");
            if (b == 2) 
                if (vis)
                    Console.WriteLine($"В {b} месяце 29 дней");
                else
                    Console.WriteLine($"В {b} месяце 28 дней");
        }
    }
}
