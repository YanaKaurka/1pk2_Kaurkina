namespace Task_24_08
{
    /*реализуйте функцию, осуществляющую поиск текста в файле и его замену на значения, введенныепользователем*/
    using System;
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите путь к файлу: ");
            string filePath = Console.ReadLine();

            Console.Write("Введите текст для поиска: ");
            string oldText = Console.ReadLine();

            Console.Write("Введите текст для замены: ");
            string newText = Console.ReadLine();

            try
            {
                // Читаем содержимое файла
                string fileContent = File.ReadAllText(filePath);

                // Заменяем старый текст на новый
                string updatedContent = fileContent.Replace(oldText, newText);

                // Записываем измененное содержимое обратно в файл
                File.WriteAllText(filePath, updatedContent);

                Console.WriteLine("Замена выполнена успешно.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}
