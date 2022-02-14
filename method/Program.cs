using System;

namespace method
{
    class chisla
    {
        public void Chisla(int x, int y)
        {
            // объявим переменную количества цифр в первом числе
            int c = 0;
            // объявим переменную количества цифр во втором числе
            int k = 0;
            // счёт цифр в первом числе
            while (x > 0)
            {
                x /= 10;
                c++;
            }
            // счёт цифр во втором числе
            while (y > 0)
            {
                y /= 10;
                k++;
            }
            // вывод числа, у которого больше цифр в числе
            if (c > k)
            {
                Console.WriteLine("Цифр больше в первом числе, чем во втором.");
            }
            else
            {
                if (c < k)
                {
                    Console.WriteLine("Цифр больше во втором числе, чем в первом.");
                }
                else
                {
                    Console.WriteLine("Количество цифрах одно и то же.");
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            chisla resh = new chisla();
            Console.WriteLine("Задача: Даны два натуральных числа. Вывести на экран число, у которого больше цифр.");
            Console.WriteLine("Введите первое число");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int y = Convert.ToInt32(Console.ReadLine());
            resh.Chisla(x, y);
        }
    }
}