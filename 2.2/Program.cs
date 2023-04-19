using System;

namespace _2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа a, b, c: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            if (a > 1 && a < 3)
                Console.WriteLine($"a = {a} принадлежит интервалу (1, 3)");
            else
                Console.WriteLine($"a = {a} не принадлежит интервалу (1, 3)");
            if (b > 1 && b < 3)
                Console.WriteLine($"b = {b} принадлежит интервалу (1, 3)");
            else Console.WriteLine($"b = {b} не принадлежит интервалу (1, 3)");
            if (c > 1 && c < 3)
                Console.WriteLine($"c = {c} принадлежит интервалу (1, 3)");
            else Console.WriteLine($"c = {c} не принадлежит интервалу (1, 3)");
            Console.ReadLine();
        }
    }
}
