namespace Task_20_04
{
    /*Создайте программу для учета транспортных средств. Используйте перечисление VehicleType:
• Car
• Bike
• Bus
• Truck
• Motorcycle
Храните список транспортных средств (можно просто List<VehicleType>). 
    Добавьте метод для подсчёта транспорта определённого типа (например, сколько грузовиков).
    Реализуйте поиск по типу и вывод информации.*/


    namespace VehicleManagement
    {
        // Перечисление для типов транспортных средств
        public enum VehicleType
        {
            Car,
            Bike,
            Bus,
            Truck,
            Motorcycle
        }


        class Program
        {
            static void Main(string[] args)
            {
                VehicleManager manager = new VehicleManager();

                // Добавление транспортных средств
                manager.AddVehicle(new Vehicle(VehicleType.Car, "Toyota Camry"));
                manager.AddVehicle(new Vehicle(VehicleType.Bike, "Yamaha YZF-R3"));
                manager.AddVehicle(new Vehicle(VehicleType.Bus, "Mercedes-Benz Sprinter"));
                manager.AddVehicle(new Vehicle(VehicleType.Truck, "Volvo FH"));
                manager.AddVehicle(new Vehicle(VehicleType.Motorcycle, "Kawasaki Ninja"));

                // Подсчет грузовиков
                int truckCount = manager.CountVehiclesByType(VehicleType.Truck);
                Console.WriteLine($"Количество грузовиков: {truckCount}");

                // Вывод информации о мотоциклах
                manager.PrintVehiclesByType(VehicleType.Motorcycle);

                Console.ReadLine();
            }
        }
    }
}
    

