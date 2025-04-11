namespace Task_20_06
{
    /*Создайте программу, имитирующую работу светофора, используя перечисление TrafficLightColor:
• Red
• Yellow
• Green
Реализуйте автоматическое переключение цветов (каждые 3 секунды). 
    При смене цвета выводите его в консоль (можно с задержкой Thread.Sleep). 
    Добавьте возможность ручного переключения (например, по нажатию клавиши).*/
    using System;
    using System.Threading;

    namespace TrafficLightSimulation
    {
        class Program
        {
            enum TrafficLightColor
            {
                Red,
                Yellow,
                Green
            }

            static void Main(string[] args)
            {
                TrafficLightColor currentColor = TrafficLightColor.Red;

                // Создаем поток для автоматического переключения
                Thread autoSwitchThread = new Thread(() =>
                {
                    while (true)
                    {
                        // Изменяем цвет светофора
                        switch (currentColor)
                        {
                            case TrafficLightColor.Red:
                                currentColor = TrafficLightColor.Green;
                                break;
                            case TrafficLightColor.Green:
                                currentColor = TrafficLightColor.Yellow;
                                break;
                            case TrafficLightColor.Yellow:
                                currentColor = TrafficLightColor.Red;
                                break;
                        }

                        // Выводим текущий цвет в консоль
                        Console.WriteLine($"Светофор: {currentColor}");
                        Thread.Sleep(3000); // Задержка 3 секунды
                    }
                });

                // Запускаем поток
                autoSwitchThread.Start();

                // Основной поток - для ручного переключения
                while (true)
                {
                    Console.WriteLine("Нажмите любую клавишу для ручного переключения цвета светофора...");
                    Console.ReadKey(true); // Ожидание нажатия клавиши
                    Console.WriteLine("Ручное переключение...");

                    // Переключаем цвет вручную
                    switch (currentColor)
                    {
                        case TrafficLightColor.Red:
                            currentColor = TrafficLightColor.Green;
                            break;
                        case TrafficLightColor.Green:
                            currentColor = TrafficLightColor.Yellow;
                            break;
                        case TrafficLightColor.Yellow:
                            currentColor = TrafficLightColor.Red;
                            break;
                    }

                    // Выводим текущий цвет в консоль
                    Console.WriteLine($"Светофор: {currentColor}");
                }
            }
        }
    }
}
