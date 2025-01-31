namespace Task_05_06
{
    internal class Program
    {
        /*Осуществить генерация двумерного [10*5] массива по следующему правилу:
• 1 столбец содержит нули
• 2 столбце содержит числа кратные 2
• 3 столбец содержит числа кратные 3
• 4 столбец содержит числа кратные 4
• 5 столбец содержит числа кратные 5 */
        static void Main(string[] args)
        {
            int str = 10;
            int stb = 5;
            int[,] matrix = new int[str, stb];

            for (int i = 0; i < str; i++)
            {
                matrix[i, 0] = 0; // 1-й столбец - нули
                matrix[i, 1] = (i + 1) * 2; // кратные 2
                matrix[i, 2] = (i + 1) * 3; // кратные 3
                matrix[i, 3] = (i + 1) * 4; // кратные 4
                matrix[i, 4] = (i + 1) * 5; // кратные 5
            }

            Console.WriteLine("Сгенерированная матрица:");
            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < stb; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
