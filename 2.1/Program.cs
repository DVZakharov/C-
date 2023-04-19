using System;

namespace _2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите объем цилиндра: ");
            double V = Convert.ToDouble(Console.ReadLine());
    
            Console.WriteLine("Введите площадь основания цилиндра: ");
            double S = Convert.ToDouble(Console.ReadLine());

            double H = V / S;
            Console.WriteLine("Высота цилиндра равна: " + H);

            Console.ReadKey();
        }
    }
}