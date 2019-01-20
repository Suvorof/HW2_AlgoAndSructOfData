using System;

namespace Task2
{
    class Program
    {
        static void Main()
        {
            // Реализовать функцию возведения числа a в степень b:
            // a. Без рекурсии.
            // b. Рекурсивно.
            // с. *Рекурсивно, используя свойство четности степени.
            // Константин Суворов. Санкт-Петербург.

            int result = Power (3, 3);
            // double result = PowerWithoutRecursion (3, 3);
            Console.WriteLine($"{result}");
            Console.ReadKey();
        }

        static double PowerWithoutRecursion(int a, int b) // a. Без рекурсии.
        {
            double p = 1;
            double indetermination = 0;

            if (a == 0 && b == 0)
            {
                Console.WriteLine("Ноль в степени ноль - это математическая неопределённость.\n Основание и показатель степени должны быть целыми числами.");
                return indetermination;
            }

            else if (a > 0 && b == 0)
                return p;

            else if (a < 0 && b == 0)
                return p;

            else if (a > 0 && b > 0)
            {
                while (b != 0)
                {
                    p *= a;
                    b--;
                }
                return p;
            }

            else if (a > 0 && b < 0)
            {
                while (b != 0)
                {
                    p = p * 1 / a;
                    b++;
                }
                return p;
            }
            else
                return indetermination;
        }

        static int SimplePower(int a, int n) // b. Рекурсивно.
        {
            if (n != 0)
                return a * SimplePower(a, n - 1);
            return 1;
        }

        static int Power(int a, int n) // с. *Рекурсивно, используя свойство четности степени.
        {
            if (n == 0)
                return 1;
            int p = Power(a, n / 2);
            if (n % 2 == 0)
                return p * p;
            else
                return a * p * p;
        }

    }
}
