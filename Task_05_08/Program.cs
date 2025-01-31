namespace Task_05_08
{
    internal class Program
    {
            public class MatrixMultiplicationSimple
        {
            public static void Main(string[] args)
            {

                int str = 10;
                int stb = 10;


                int[,] mat1 = new int[str, stb];
                int[,] mat2 = new int[str, stb];
                int[,] result = new int[str, stb];

                Random random = new Random();

                for (int i = 0; i < str; i++)
                {
                    for (int j = 0; j < stb; j++)
                    {
                        mat1[i, j] = random.Next(1, 10); 
                        mat2[i, j] = random.Next(1, 10);
                    }
                }
                for (int i = 0; i < str; i++)
                {
                    for (int j = 0; j < stb; j++)
                    {
                        result[i, j] = mat1[i, j] * mat2[i, j];
                    }
                }
                Console.WriteLine("Матрица с произведением: ");
                for (int i = 0; i < str; i++)
                {
                    for (int j = 0; j < stb; j++)
                    {
                        Console.Write(result[i, j] + "  " ); 
                    }
                    Console.WriteLine();
                }
            }
            
           
        }
    }
}

