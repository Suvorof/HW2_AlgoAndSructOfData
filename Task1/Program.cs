using System;

namespace Task1
{
    class Program
    {
        static void Main()
        {
            // Реализовать функцию перевода чисел из десятичной системы в двоичную, используя рекурсию.
            // Константин Суворов. Санкт-Петербург.

            TransformToBinary(110);
            Console.ReadKey();
        }

        static void TransformToBinary (int a)
        {
            int result=0;

            if (a != 0)
            {
                result = result * 10 + a % 2;
                a /= 2;
                TransformToBinary(a);
                Console.Write($"{result}");
            }
        }
    }
}