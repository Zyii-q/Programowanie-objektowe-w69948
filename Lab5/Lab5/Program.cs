using Lab5;
using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Testowanie systemu ===");

            // Приклад роботи з класами Shape
            Shape square = new Square { X = 5 };
            Console.WriteLine($"Pole kwadratu: {square.CalculateArea()}");

            Shape circle = new Circle { R = 3 };
            Console.WriteLine($"Pole koła: {circle.CalculateArea()}");

            // Приклад роботи з класами IVehicle
            IVehicle car = new Car { MaxSpeed = 180 };
            car.Start();
            car.Stop();

            IVehicle bike = new Bike { MaxSpeed = 60 };
            bike.Start();
            bike.Stop();

            Console.WriteLine("Test zakończony.");
        }
    }
}
