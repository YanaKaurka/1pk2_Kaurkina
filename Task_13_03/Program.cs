namespace Task_13_03
{
    /*создайте класс автомобиля
свойства:
номер авто, марка, цвет, текущая скорость
методы:
езда (симитировать равномерное ускорение скорости автомобиля)
торможение (при превышении скорости автомобиля свыше допустимой - он должен остановиться)
конструторы
предусмотрите разные варианты инициализации объектов*/
    using System;

    public class Car
    {
        #region поля
        public string LicensePlate { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public double CurrentSpeed { get; set; } //изменение скорости
        public double MaxSpeed { get; set; }  //наивысшая скорость
        #endregion
       
        private const double DefaultMaxSpeed = 200;//макс.скорость

#region конструкторы

        public Car()
        {
            LicensePlate = "Не указан";
            Brand = "Неизвестно";
            Color = "Не определен";
            CurrentSpeed = 0;
            MaxSpeed = DefaultMaxSpeed;
        }


        public Car(string licensePlate, string brand) : this()
        {
            LicensePlate = licensePlate;
            Brand = brand;
        }


        public Car(string licensePlate, string brand, string color) : this(licensePlate, brand)
        {
            Color = color;
        }

        public Car(string licensePlate, string brand, string color, double currentSpeed) : this(licensePlate, brand, color)
        {
            CurrentSpeed = currentSpeed;
        }
        public Car(string licensePlate, string brand, string color, double currentSpeed, double maxSpeed) : this(licensePlate, brand, color, currentSpeed)
        {
            MaxSpeed = maxSpeed;
        }
        #endregion
#region методы
         //ускорение
        public void Accelerate(double acceleration, double time)
        {
            if (acceleration <= 0 || time <= 0)
            {
                Console.WriteLine("Ускорение и время должны быть положительными.");
                return;
            }

            double newSpeed = CurrentSpeed + acceleration * time;

            if (newSpeed > MaxSpeed)
            {
                CurrentSpeed = MaxSpeed;
                Console.WriteLine($"Достигнута максимальная скорость ({MaxSpeed} км/ч).");
            }
            else
            {
                CurrentSpeed = newSpeed;
                Console.WriteLine($"Скорость увеличена до {CurrentSpeed} км/ч.");
            }
        }

        //торможение
        public void Brake(double speedLimit)
        {
            if (CurrentSpeed > speedLimit)
            {
                Console.WriteLine($"Превышена допустимая скорость ({speedLimit} км/ч). Экстренное торможение!");
                CurrentSpeed = 0;
            }
            else
            {
                Console.WriteLine("Торможение прошло успешно.");
            }
        }
        #endregion
        //вывод информации
        public void GetCarInfo()
        {
            Console.WriteLine("--- Информация об автомобиле ---");
            Console.WriteLine($"Номер: {LicensePlate}");
            Console.WriteLine($"Марка: {Brand}");
            Console.WriteLine($"Цвет: {Color}");
            Console.WriteLine($"Текущая скорость: {CurrentSpeed} км/ч");
            Console.WriteLine($"Максимальная скорость: {MaxSpeed} км/ч");
            Console.WriteLine("------------------------------");
        }
    }
}
