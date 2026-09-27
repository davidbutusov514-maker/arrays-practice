using System;

namespace Task4.Exceptions
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int[] numbers = new int[5];

            // Ввод с обработкой исключений
            for (int i = 0; i < numbers.Length; i++)
            {
                while (true)
                {
                    Console.Write($"Введите элемент [{i}]: ");
                    string? input = Console.ReadLine();

                    try
                    {
                        numbers[i] = int.Parse(input ?? "");
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Ошибка: Введите целое число!");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Ошибка: Число слишком большое!");
                    }
                }
            }

            Console.WriteLine("\nМассив: " + string.Join(", ", numbers));

            // Запрос индекса с обработкой IndexOutOfRangeException
            Console.Write("\nВведите индекс для вывода (0-4): ");
            string? indexInput = Console.ReadLine();

            try
            {
                int index = int.Parse(indexInput ?? "");
                Console.WriteLine($"Элемент [{index}] = {numbers[index]}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: индекс должен быть числом.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка: число слишком большое.");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Ошибка: Индекс вне границ массива.");
            }
        }
    }
}