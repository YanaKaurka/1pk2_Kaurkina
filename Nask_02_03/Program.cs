namespace Task_02_04
{ 
    internal class Program
    {
        /*       Пользователь вводит свою дату рождения построчно(сначала год, потом месяц и в конце дату) произведите
        расчет является ли пользователь совершеннолетним на текущую дату и выведите соответствующее сообщение об
        этом*/
        static void Main(string[] args)
        {
            int year, month, day, nowyear, nowmonth, nowday;
            Console.WriteLine("Введите свой год рождения(числом");
            while (!int.TryParse(Console.ReadLine(), out year))

            Console.WriteLine("Введите свой месяц рождения(числом)");
            while (!int.TryParse(Console.ReadLine(), out month))

            Console.WriteLine("Введите свой день рождения(числом)");
            while (!int.TryParse(Console.ReadLine(), out day))

            Console.WriteLine("Введите текущий год(числом)");
            while (!int.TryParse(Console.ReadLine(), out nowyear))

            Console.WriteLine("Введите текущий месяц(числом)");
            while (!int.TryParse(Console.ReadLine(), out nowmonth))

            Console.WriteLine("Введите текущий день");
            while (!int.TryParse(Console.ReadLine(), out nowday))
            {
                Console.WriteLine("Некорректный ввод, введите текущий день в виде числа");
            }

            int Age = nowyear - year;
            if ((nowmonth < month & Age == 18) || (nowmonth == month && nowday < day))
                Age -= 1;
            if (Age >= 18)
                Console.WriteLine("Вы совершеннолетний");
            else
                Console.WriteLine("Вы несовершеннолетний");
        }
    }
}