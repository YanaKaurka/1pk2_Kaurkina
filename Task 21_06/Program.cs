namespace Task_21_06
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 2, 1, 4, 5, 4 };
            List<int> uniqueNumbers = RemoveDuplicates(numbers);

            Console.WriteLine(string.Join(", ", uniqueNumbers));
        }

        static List<T> RemoveDuplicates<T>(List<T> list)
        {
            HashSet<T> seenElements = new HashSet<T>();
            List<T> result = new List<T>();

            foreach (var item in list)
            {
                // Проверяем, был ли элемент уже добавлен
                if (seenElements.Add(item))
                {
                    // Если нет, добавляем его в результирующий список
                    result.Add(item);
                }
            }

            return result;
        }
    }
}
