namespace Task_21_10
{
    /*Написать метод, который объединяет два словаря. Если ключ присутствует в обоих словарях, суммироватьихзначения.*/
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            // Пример использования метода
            Dictionary<string, int> dict1 = new Dictionary<string, int>
        {
            { "apple", 2 },
            { "banana", 3 },
            { "orange", 1 }
        };

            Dictionary<string, int> dict2 = new Dictionary<string, int>
        {
            { "banana", 2 },
            { "orange", 3 },
            { "kiwi", 5 }
        };

            Dictionary<string, int> combinedDict = CombineDictionaries(dict1, dict2);

            // Выводим объединённый словарь
            foreach (var item in combinedDict)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }

        static Dictionary<string, int> CombineDictionaries(Dictionary<string, int> dict1, Dictionary<string, int> dict2)
        {
            // Создаём новый словарь для хранения объединённых данных
            Dictionary<string, int> result = new Dictionary<string, int>();

            // Добавляем элементы из первого словаря
            foreach (var kvp in dict1)
            {
                result[kvp.Key] = kvp.Value;
            }

            // Обрабатываем второй словарь
            foreach (var kvp in dict2)
            {
                if (result.ContainsKey(kvp.Key))
                {
                    // Если ключ уже есть, суммируем значения
                    result[kvp.Key] += kvp.Value;
                }
                else
                {
                    // Если ключа нет, просто добавляем элемент
                    result[kvp.Key] = kvp.Value;
                }
            }

            return result;
        }
    }
}
