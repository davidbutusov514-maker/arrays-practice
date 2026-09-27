using System;

namespace Task3.Unique
{
    class Program
    {
        public static int[] GetUnique(int[] source)
        {
            if (source == null || source.Length == 0)
                return new int[0];

            // Вспомогательный массив — максимум все элементы уникальны
            int[] temp = new int[source.Length];
            int count = 0;

            for (int i = 0; i < source.Length; i++)
            {
                bool found = false;
                for (int j = 0; j < count; j++)
                {
                    if (temp[j] == source[i])
                    {
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    temp[count] = source[i];
                    count++;
                }
            }

            // Обрезаем до реального размера
            int[] result = new int[count];
            for (int i = 0; i < count; i++)
                result[i] = temp[i];

            return result;
        }

        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int[] arr = new int[10];
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
                arr[i] = random.Next(1, 6);

            Console.WriteLine("Исходный:   " + string.Join(", ", arr));

            int[] unique = GetUnique(arr);
            Console.WriteLine("Уникальные: " + string.Join(", ", unique));
        }
    }
}