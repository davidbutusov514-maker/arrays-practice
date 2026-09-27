using System;

namespace Task2.InputSort
{
    class Program 
    {
        static void Main(string[] args)
        {
            int n;
            while (true)
            {
                Console.Write("Введите кол-во элементов: ");
                if (int.TryParse(Console.ReadLine(), out n) && n > 0)
                {
                    break;
                }
            }
            int[] numbers = new int[n];
for (int i = 0; i < n; i++)
{
    while (true)
    {
        Console.Write($"Элемент [{i}]: ");
        string? input = Console.ReadLine();
        try
        {
            numbers[i] = int.Parse(input ?? "");
            break;
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: введите целое число!");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Ошибка: число слишком большое!");
        }
    }
}

            Console.WriteLine();
            Console.WriteLine($"Исходный маaссив: {string.Join(", ", numbers)}");

            int[] reversed = (int[])numbers.Clone();
            Array.Reverse(reversed);
            Console.WriteLine($"Обратный порядок {string.Join(", ", reversed)}");

            Array.Sort(numbers);
            Console.WriteLine($"Отсортированный массив {string.Join(", ", numbers)}");

            int max = numbers[0];
            int min = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            Console.WriteLine($"Максимум: {max}");
            Console.WriteLine($"Минимум: {min}");
        }
    }

}
