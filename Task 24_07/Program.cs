namespace Task_24_07
{
    /*Реализуйте функцию, которая ищет заданное слово в текстовом файле 
     * и возвращает все строки, содержащиеэтослово (регистронезависимо).*/
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:\\Users\\Asus\\Desktop\\уипд\\Текстовый документ.txt"; 
            string searchWord = "химии"; 

            List<string> linesContainingWord = FindLinesContainingWord(filePath, searchWord);

            // Вывод результатов
            foreach (string line in linesContainingWord)
            {
                Console.WriteLine(line);
            }
        }

        static List<string> FindLinesContainingWord(string filePath, string searchWord)
        {
            List<string> matchingLines = new List<string>();

            try
            {
                // Читаем все строки
                string[] lines = File.ReadAllLines(filePath);

                // Перебираем все строки и ищем заданное слово
                foreach (string line in lines)
                {
                    if (line.IndexOf(searchWord, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        matchingLines.Add(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
            }

            return matchingLines;
        }
    }
}
