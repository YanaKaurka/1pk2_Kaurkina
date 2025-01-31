namespace Task_05_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Дан квадратный массив размерность n*n. Произведите анализ данной матрицы и выясните является ли данная матрица
диагональной (все элементы вне главной диагонали равны нулю)
Если матрица является диагональной, то вывести ее повторно с цветовым выделением главной диагонали. Если нет, то вывеси
сообщение что матрица не является диагональной. */
            {
                Console.WriteLine($"Введите число строк и столбцов: ");
                int n = Int32.Parse(Console.ReadLine());
                int[,] mat = new int[n, n];
                Random rnd = new Random();
                int count = 0;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        mat[i, j] = rnd.Next(0, 11);
                        {
                           /* if (i != j & mat[i, j] != 0)
                                Console.WriteLine($"Матрица не диагональная");*/
                                if (j != i & mat[i, j] == 0)
                                count++;
                            if (count == mat.Length - n)
                                Console.WriteLine($"Матрица диагональная");
                            else;
                                Console.WriteLine($"Матрица не диагональная");

                        }
                        if (i == j)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Write(mat[i, j]);
                        }
                        else
                            Console.BackgroundColor = ConsoleColor.Black;
                    }
                }
            }
        }       
    }
}
