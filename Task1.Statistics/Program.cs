using System;
using System.Globalization;

namespace Task1.Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 101);
            }
            Console.WriteLine($"Массив: {string.Join(", ", numbers)}");

            int sum = 0;
            double product = 1;
            int count = 0;

            foreach (int num in numbers)
            {
                sum += num;
                product *= num;
                if (num % 2 == 0)
                {
                    count++;
                }
            }

            double average = (double)sum / numbers.Length;

            int greaterCount = 0;
            foreach (int num in numbers)
            {
                if (num > average)
                {
                    greaterCount++;
                }
            }

            Console.WriteLine($"Сумма {sum}");
            Console.WriteLine($"Произведение {product:E2}");
            Console.WriteLine($"Четных чисел {count}");
            Console.WriteLine($"Больше среднего ({Math.Round(average, 1)}): {greaterCount}");

        }
    }

}
