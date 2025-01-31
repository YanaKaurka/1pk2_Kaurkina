namespace Task_05_05
{
    internal class Program
    {
        /*У пользователя в консоли запрашивается числа n и m, генерируется прямоугольный массив целых числе [n*m]. Заполнение
        случайными числами в диапазоне от -99 до 99 включительно. Осуществите без создания нового массива преобразование текущего
        по следующему правилу:
        • Если элемент меньше нуля, то отбрасываем знак и выделяем при выводе зеленым цветом
        • Если элемент равен нулю, то перезаписываем единицу и выделяем при выводе красным цветом */
        static void Main(string[] args)
        {
            Console.WriteLine($"Введите число строк: ");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Введите число столбцов: ");
            int m = Int32.Parse(Console.ReadLine());
            int[,] mat = new int[n, m];
            Random rnd = new Random();
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= m; j++)
                {
                    mat[i, j] = rnd.Next(-99, 100);
                }
            }
            
             Console.WriteLine("\nПреобразованная матрица:");
             for (int i = 0; i < n; i++)
             {
             for (int j = 0; j < m; j++)
                 {
                      if (mat[i, j] < 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                mat[i, j] = Math.Abs(mat[i, j]); // Отбрасываем знак через модуль
                            }
                      else if (mat[i, j] == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                mat[i, j] = 1; // Заменяем на 1
                                Console.Write( mat[i, j]);
                            }
                      else
                            {
                                Console.ForegroundColor = ConsoleColor.White; 
                                Console.Write(mat[i, j]);
                            }
                        }
                        Console.WriteLine();
                    }
                    Console.ResetColor(); // Сброс цвета консоли
        }
    }
}
