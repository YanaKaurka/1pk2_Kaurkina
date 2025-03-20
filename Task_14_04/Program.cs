namespace Task_14_04
{
    /*Определите класс User, который будет иметь статическое свойство CurrentUser, представляющеетекущегопользователя, 
     * и метод для его установки.*/
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        // Конструктор (для создания объектов User)
        public User(int id, string username, string password)
        {
            Id = id;
            Username = username;
            Password = password;
        }
        
        public void GetUserInfo()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Username: {Username}");
            //Console.WriteLine($"Password: {Password}"); // Не выводите пароль!
        }
    }

    
    

}
