namespace Task_05_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Даны два массива, заполненные символами английского алфавита размером 3*3. Проверить, являются ли матрицы равными, если
да, то вывести сообщение о том, что они равны, если нет, то вывести повторно матрицы с цветовой индикацией только тех
элементов, которые равны. (матрицы считаются равными, если их соответствующие элементы равны.
Пример:
f h h f c h
w g k m g z
a f j a o d
=>
f h h f c h
w g k m g z
a f j a o d*/
            {
                char[,] mat1 = {
            { 'f', 'h', 'h' },
            { 'w', 'g', 'k' },
            { 'a', 'f', 'j' }
         };

                char[,] mat2 = {
            { 'f', 'c', 'h' },
            { 'm', 'g', 'z' },
            { 'a', 'o', 'd' }
        };
                {
                    for (int i = 0; i < 3; i++) 
                    {
                        for (int j = 0; j < 3; j++) 
                        {
                            if (mat1[i, j] == mat2[i, j])
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.Write($"{mat1[i, j]} {mat2[i, j]}");
                                Console.BackgroundColor = ConsoleColor.Black;
                            }

                       
                    

                    }

                }
            }

        }
    }
}
