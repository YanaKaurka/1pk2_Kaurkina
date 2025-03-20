namespace Task_14_03
{
    /*Реализуйте статический метод Factorial, который принимает целое число и возвращает его факториал. Сделайтетак, чтобы метод работал только для неотрицательных чисел.*/
    internal class Program
    {
        public static long Factorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Факториал определен только для неотрицательных чисел.");
            }

            if (n == 0)
            {
                return 1; // Факториал 0 равен 1
            }

            long result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
