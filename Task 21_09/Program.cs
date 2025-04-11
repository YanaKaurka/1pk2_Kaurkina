namespace Task_21_09
{
    /*создайте класс билета (Ticket). сгенерируйте список из 30 билетов. произведите:
• поиск билета с максимальной суммой,
• билета с минимальной суммой,
• выведите список билетов с багажом
• выведите список люготных билетов*/
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Ticket
    {
        public int TicketId { get; set; }
        public decimal Price { get; set; }
        public bool HasLuggage { get; set; } // true, если есть багаж
        public bool IsDiscounted { get; set; } // true, если билет льготный

        public Ticket(int ticketId, decimal price, bool hasLuggage, bool isDiscounted)
        {
            TicketId = ticketId;
            Price = price;
            HasLuggage = hasLuggage;
            IsDiscounted = isDiscounted;
        }

        public override string ToString()
        {
            return $"Ticket ID: {TicketId}, Price: {Price:C}, Luggage: {(HasLuggage ? "Yes" : "No")}, Discounted: {(IsDiscounted ? "Yes" : "No")}";
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            List<Ticket> tickets = new List<Ticket>();

            // Генерация 30 билетов
            for (int i = 1; i <= 30; i++)
            {
                decimal price = random.Next(100, 1000); // Цены от 100 до 999
                bool hasLuggage = random.Next(0, 2) == 0; // Случайно устанавливаем наличие багажа
                bool isDiscounted = random.Next(0, 2) == 0; // Случайно устанавливаем льготный билет
                tickets.Add(new Ticket(i, price, hasLuggage, isDiscounted));
            }

            // Поиск билета с максимальной и минимальной суммой
            var maxTicket = tickets.OrderByDescending(t => t.Price).First();
            var minTicket = tickets.OrderBy(t => t.Price).First();

            Console.WriteLine($"Билет с максимальной суммой: {maxTicket}");
            Console.WriteLine($"Билет с минимальной суммой: {minTicket}");

            // Список билетов с багажом
            var ticketsWithLuggage = tickets.Where(t => t.HasLuggage).ToList();
            Console.WriteLine("\nБилеты с багажом:");
            foreach (var ticket in ticketsWithLuggage)
            {
                Console.WriteLine(ticket);
            }

            // Список льготных билетов
            var discountedTickets = tickets.Where(t => t.IsDiscounted).ToList();
            Console.WriteLine("\nЛьготные билеты:");
            foreach (var ticket in discountedTickets)
            {
                Console.WriteLine(ticket);
            }
        }
    }
}
