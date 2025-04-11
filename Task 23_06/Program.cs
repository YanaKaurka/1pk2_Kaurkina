namespace Task_23_06
{
    /*Напишите программу со следующими функциями:
1. Выведите информации о всех дисках в системе
2. Выведите содержимое каталога C:\Users (названия папок)
3. Создайте на диске D папку “work” и всю дальнейшую работу проводите в ней
a) Создание вложенного каталога “temp”
b) Вывод информации о текущем каталоге (имя, родитель и тд)
c) Вывод информации о вложенном каталоге
4. Переместите каталог “temp” по пути “D:\work\newTemp”
a) Реализуйте вывод информационного сообщения об успешном (или нет)
перемещении
5. Удалите каталог “D:\work\temp” и выведите сообщение об успешном (или нет)
удалении.*/
    using System;
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            // 1. Информация о всех дисках в системе
            Console.WriteLine("Информация о всех дисках в системе:");
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine($"Имя диска: {drive.Name}, Тип: {drive.DriveType}, Свободное пространство: {drive.AvailableFreeSpace / (1024 * 1024)} MB");
            }

            // 2. Содержимое каталога C:\Users
            Console.WriteLine("\nСодержимое каталога C:\\Users:");
            string userDirectory = @"C:\Users";
            string[] directories = Directory.GetDirectories(userDirectory);
            foreach (string directory in directories)
            {
                Console.WriteLine(Path.GetFileName(directory));
            }

            // 3. Создание каталога D:\work и вложенного каталога temp
            string workDirectory = @"D:\work";
            string tempDirectory = Path.Combine(workDirectory, "temp");

            Directory.CreateDirectory(workDirectory);
            Directory.CreateDirectory(tempDirectory);

            // 3.b. Информация о текущем каталоге
            Console.WriteLine($"\nИнформация о текущем каталоге: {tempDirectory}");
            DirectoryInfo dirInfo = new DirectoryInfo(tempDirectory);
            Console.WriteLine($"Имя: {dirInfo.Name}, Родитель: {dirInfo.Parent?.FullName}, Полный путь: {dirInfo.FullName}");

            // 3.c. Информация о вложенном каталоге
            Console.WriteLine("\nИнформация о вложенном каталоге:");
            DirectoryInfo[] subDirectories = dirInfo.GetDirectories();
            foreach (var subDir in subDirectories)
            {
                Console.WriteLine($"Имя: {subDir.Name}, Родитель: {subDir.Parent.FullName}");
            }

            // 4. Перемещение каталога temp в D:\work\newTemp
            string newTempDirectory = Path.Combine(workDirectory, "newTemp");

            try
            {
                Directory.Move(tempDirectory, newTempDirectory);
                Console.WriteLine($"\nКаталог перемещен успешно: {newTempDirectory}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при перемещении каталога: {ex.Message}");
            }

            // 5. Удаление каталога D:\work\newTemp
            try
            {
                Directory.Delete(newTempDirectory, true);
                Console.WriteLine($"\nКаталог {newTempDirectory} удален успешно.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при удалении каталога: {ex.Message}");
            }
        }
    }
}
