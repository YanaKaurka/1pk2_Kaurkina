namespace Task_24_06
{
    /*Напишите метод, который принимает путь к файлу и возвращает количество строк в нем. Используйте StreamReader*/
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:\\Users\\Asus\\Desktop\\уипд\\Текстовый документ.txt";
            try
            {
                int lineCount = GetLineCount(filePath);
                Console.WriteLine($"Количество строк в файле: {lineCount}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }

        static int GetLineCount(string filePath)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (reader.ReadLine() != null)
                {
                    count++;
                }
            }
            return count;
        }
    }
}

