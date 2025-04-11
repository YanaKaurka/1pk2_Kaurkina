namespace Task_21_07
{
    /*Написать метод, который находит первый ключ в словаре, 
     * соответствующий заданному значению. Еслизначениянет, вернуть null.*/
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            // Пример словаря
            Dictionary<string, int> dict = new Dictionary<string, int>
        {
            { "один", 1 },
            { "два", 2 },
            { "три", 3 },
            { "четыре", 2 }
        };

            // Поиск ключа по значению
            string valueToFind = "два";
            string result = FindKeyByValue(dict, 2);

            if (result != null)
            {
                Console.WriteLine($"Первый ключ, соответствующий значению {valueToFind}: {result}");
            }
            else
            {
                Console.WriteLine($"Значение {valueToFind} не найдено.");
            }
        }

        static string FindKeyByValue(Dictionary<string, int> dictionary, int value)
        {
            // Проходим по всем ключам и значениям в словаре
            foreach (var pair in dictionary)
            {
                // Если значение совпадает, возвращаем ключ
                if (pair.Value == value)
                {
                    return pair.Key;
                }
            }

            // Если значение не найдено, возвращаем null
            return null;
        }
    }
}
