using System;

namespace _3._2
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год");
            int year = Convert.ToInt32(Console.ReadLine());
            int days = 31;
            for (int month = 1, month < 13, month++)
            {
                bool flag = false;
                if ((month == 4) || (month == 6) || (month == 9) || (month == 11))
                {
                    days = 30;
                    flag = true;
                    var date = new System.DateOnly(year, month, days);
                }
                if (!flag && month != 2)
                {

                }
                if (month == 2)
                {

                }
                    
            } 
        }
    }
}
