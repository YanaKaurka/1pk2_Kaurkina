namespace Task_05_07
{
    internal class Program
    {
        /*У пользователя в консоли запрашивается число n, генерируется квадратный массив целых числе [n*n]. Заполнение случайными
числами в диапазоне от 10 до 99 включительно.
Найти и вывести отдельно минимальный элемент в матрице (LINQ под запретом) Осуществить умножение матрицы на ее
минимальный элемент, при выводе цветом выделить пять максимальных значений в массиве */
        static void Main(string[] args)
        {
            Console.WriteLine($"Введите число строк и столбцов: ");
            int n = Int32.Parse(Console.ReadLine());
            int[,] mat = new int[n, n];
            Random rnd = new Random();
            int min = 99;
            int max = 10;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = rnd.Next(10, 100);
                    {
                        Console.Write(mat[i, j] + " ");

                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < min)
                        min = mat[i, j];
                    if (mat[i, j] > max)
                        max = mat[i, j];

                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    while (i < n; j < n)

                }
            }
        }
    }
}


