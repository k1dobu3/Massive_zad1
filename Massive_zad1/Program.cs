using System;

namespace Massive_zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0, sum = 0;
            Console.WriteLine("Введите кол-во элеменов массива:");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] b = new int[5];
            Console.WriteLine("Введите элементы последовательности через пробел");
            var array = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
            for (int i = 0; i < N; i++)
            {
                if (array[i] > count)
                {
                    count = array[i];
                    sum += array[i];

                }
            }

            Console.WriteLine($"Максимальные элемент последовательности равен {count}");
            Console.WriteLine($"Обратная последовательость:");
            for (int i = N - 1; i >= 0; i--)
            {
                Console.WriteLine($"{array[i]} ");
            }
            //В массиве действительных чисел все нулевые элементы заменить на среднее арифметическое всех элементов массива.

            for (int j = 0; j < N; j++)
            {
                if (array[j] == 0)
                {
                    array[j] = sum / N;
                }
                if (j == N - 1)
                {
                    Console.WriteLine($"При замене нулей на среднее ариф. : {string.Join(",", array)}");
                }
            }
        }
    }
}
