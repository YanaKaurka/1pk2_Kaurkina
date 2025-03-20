namespace Task_13_02
{
    /*создать класс питомца
свойства:
кличка, вид животного, возраст, вес, отметка о состонии здоровья (здоров/нездоров)
методы:
вывод информации об объекте
изменение значения веса животного
изменение отметки о состоянии здоровья
конструторы:
предусмотрите разные варианты инициализации объектов*/
    using System;

    public class Pet
    {
#region поля
        public string Nickname { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public bool IsHealthy { get; set; }
        #endregion 

        #region конструкторы
        public Pet()
        {//инициализация всего
            Nickname = "Безымянный";
            Species = "Неизвестный вид";
            Age = 0;
            Weight = 1.0;
            IsHealthy = true;
        }
        public Pet(string nickname, string species) : this() //кличка и вид
        {
            Nickname = nickname;
            Species = species;
        }
        public Pet(string nickname, string species, int age, double weight) : this(nickname, species) // всё кроме здоровья
        {
            Age = age;
            Weight = weight;
        }

        public Pet(string nickname, string species, int age, double weight, bool isHealthy) : this(nickname, species, age, weight) // все параметры
        {
            IsHealthy = isHealthy;
        }
        #endregion

        #region методы

        //вывод
        public void GetPetInfo()
        {
            Console.WriteLine("--- Информация о питомце ---");
            Console.WriteLine($"Кличка: {Nickname}");
            Console.WriteLine($"Вид: {Species}");
            Console.WriteLine($"Возраст: {Age} лет");
            Console.WriteLine($"Вес: {Weight} кг");
            Console.WriteLine($"Состояние здоровья: {(IsHealthy ? "Здоров" : "Не здоров")}");
            Console.WriteLine("--------------------------");
        }

        //изменение веса
        public void SetWeight(double newWeight)
        {
            if (newWeight > 0)
            {
                Weight = newWeight;
            }
            else
            {
                Console.WriteLine("Недопустимый вес. Вес должен быть больше нуля.");
            }
        }
        #endregion 
    }
}
