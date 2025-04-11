namespace Task_21_08
{
    /*напишите метод, который на вход получается массив параметров (строк) и возвращает толькоуникальныестроки*/
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            string[] inputArray = { "apple", "banana", "apple", "orange", "banana", "kiwi" };
            string[] uniqueStrings = GetUniqueStrings(inputArray);

            Console.WriteLine("Уникальные строки:");
            foreach (var str in uniqueStrings)
            {
                Console.WriteLine(str);
            }
        }

        static string[] GetUniqueStrings(string[] input)
        {
            // Создаем HashSet для хранения уникальных строк
            HashSet<string> uniqueSet = new HashSet<string>();

            // Добавляем каждую строку в HashSet
            foreach (var str in input)
            {
                uniqueSet.Add(str);
            }

            // Преобразуем HashSet обратно в массив и возвращаем
            return uniqueSet.ToArray();
        }
    }
}
