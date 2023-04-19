using System;
using System.Linq;

namespace _2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите элементы массива через пробел: ");
            int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int count = 0;

            for (int i = 0; i < num.Length; i++)
                if (num[i] % 2 == 0)
                {
                    count++;
                }

            Console.WriteLine("Количество четных чисел в массиве: " + count);
        }
    }
}
