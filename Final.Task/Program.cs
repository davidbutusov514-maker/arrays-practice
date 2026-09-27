using System;

namespace Final.Task
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Вариант 0. Успеваемость студентов
            // Номер в журнале: 6, 6 % 3 = 0

            string[] students = { "Анна", "Борис", "Виктор", "Галина" };
            int[] grades = { 85, 92, 78, 95 };

            // Таблица с выравниванием
            Console.WriteLine("Успеваемость студентов:");
            Console.WriteLine(new string('-', 25));

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"{students[i],-10} | {grades[i],4} баллов");
            }

            Console.WriteLine(new string('-', 25));

            // Лучший студент
            int maxGrade = grades[0];
            for (int i = 1; i < grades.Length; i++)
            {
                if (grades[i] > maxGrade)
                    maxGrade = grades[i];
            }

            int bestIndex = Array.IndexOf(grades, maxGrade);
            Console.WriteLine($"\nЛучший студент: {students[bestIndex]} ({grades[bestIndex]} баллов)");

            // Средний балл группы
            int sum = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                sum += grades[i];
            }

            double average = (double)sum / grades.Length;
            Console.WriteLine($"Средний балл группы: {average:F1}");
        }
    }
}