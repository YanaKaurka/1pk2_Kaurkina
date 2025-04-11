using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_20_04.VehicleManagement;

namespace Task_20_04
{
    public class Vehicle
    {
        public VehicleType Type { get; set; }
        public string Model { get; set; }

        public Vehicle(VehicleType type, string model)
        {
            Type = type;
            Model = model;
        }
        public override string ToString()
        {
            return $"{Type} - {Model}";
        }
    }
    public class VehicleManager
    {
        private List<Vehicle> vehicles;

        public VehicleManager()
        {
            vehicles = new List<Vehicle>();
        }

        // Метод для добавления транспортного средства в список
        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        // Метод для подсчета транспорта определенного типа
        public int CountVehiclesByType(VehicleType type)
        {
            int count = 0;
            foreach (var vehicle in vehicles)
            {
                if (vehicle.Type == type)
                {
                    count++;
                }
            }
            return count;
        }

        // Метод для поиска и вывода информации 
        public void PrintVehiclesByType(VehicleType type)
        {
            Console.WriteLine($"Транспортные средства типа {type}:");
            foreach (var vehicle in vehicles)
            {
                if (vehicle.Type == type)
                {
                    Console.WriteLine(vehicle);
                }
            }
        }

    }
}
