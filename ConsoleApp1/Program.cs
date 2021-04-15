using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 1.5;
            int i;
            string s;

            Console.Title = "ЛБ 1";
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Cyan; Console.Clear();
            Console.Write("Введите сторону равностороннего треугольник: ");
            i = Int32.Parse(Console.ReadLine());

            if (i>0)
            {
                x = (Math.Pow(i, 2) * Math.Sqrt(3)) / 4;
                Console.WriteLine("x =" + x);
            }
            else
            {
                Console.WriteLine("Некорректное число");
                    }
        }
    }
}
