namespace Ефыл_05_09
{
    /*Дан квадратный массив размерностью n*n. Проанализируйте данную матрицу и выясните, 
     * является ли она Z-матрицей (это матрица, в которой все недиагональные элементы меньше нуля). 
     * Если данное условие выполняется, выведите данную матрицу с цветовой индикацией главной диагонали.
     * Если не выполняется, выведите сообщение о том, что данная матрица не является Z-матрице*/
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Введите число строк и столбцов: ");
            int n = Int32.Parse(Console.ReadLine());
            int[,] mat = new int[n, n];
            Random rnd = new Random();
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = rnd.Next(-10, 11);
                    if (i != j && mat[i, j] >= 0)
                    {
                        Console.WriteLine($"Матрица не Z-образная");
                    }
                    break;


                }

            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    if (i != j && mat[i, j] < 0)
                        count++;
                if (count == n * n - n)
                    Console.WriteLine($"Матрица Z-образная");
            }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                        Console.Write(mat[i, j]);
                }
                
            
        }
    }
}
