namespace Ефыл_20_05
{
    /*Напишите программу, имитирующую систему авторизации с использованием перечисления AccessLevel:
• Guest (только чтение)
• User (чтение + комментарии)
• Moderator (удаление контента)
• Admin (полный доступ)
Создайте метод, который проверяет, может ли пользователь выполнить действие (например, удалитьпост).
    На основе уровня доступа выводите сообщение (например,
"Ошибка: Недостаточно прав!").*/
    using System;

    namespace AuthorizationSystem
    {
        // Перечисление уровней доступа
        public enum AccessLevel
        {
            Guest,     // только чтение
            User,      // чтение + комментарии
            Moderator, // удаление контента
            Admin      // полный доступ
        }

        // Класс пользователя
        public class User
        {
            public string Name { get; set; }
            public AccessLevel Level { get; set; }

            public User(string name, AccessLevel level)
            {
                Name = name;
                Level = level;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                // Создание пользователей с различными уровнями доступа
                User guest = new User("Гость", AccessLevel.Guest);
                User user = new User("Пользователь", AccessLevel.User);
                User moderator = new User("Модератор", AccessLevel.Moderator);
                User admin = new User("Администратор", AccessLevel.Admin);

                // Проверка возможности удаления поста для разных пользователей
                PerformDeletePost(guest);
                PerformDeletePost(user);
                PerformDeletePost(moderator);
                PerformDeletePost(admin);
            }

            // Метод для проверки прав доступа
            static void PerformDeletePost(User user)
            {
                if (CanDeletePost(user))
                {
                    Console.WriteLine($"{user.Name} успешно удалил пост.");
                }
                else
                {
                    Console.WriteLine($"Ошибка: {user.Name}, недостаточно прав для удаления поста!");
                }
            }

            // Метод проверки прав на удаление поста
            static bool CanDeletePost(User user)
            {
                return user.Level == AccessLevel.Moderator || user.Level == AccessLevel.Admin;
            }
        }
    }
}
