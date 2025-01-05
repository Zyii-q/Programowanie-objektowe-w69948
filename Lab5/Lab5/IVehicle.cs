namespace Lab5
{
    public interface IVehicle
    {
        int MaxSpeed { get; set; }

        // Інтерфейси не можуть мати реалізовані методи до C# 8.0.
        // Якщо необхідна реалізація, використовуйте abstract class.
        void Start();
        void Stop();
    }

    public class Car : IVehicle
    {
        public int MaxSpeed { get; set; }

        public void Start()
        {
            Console.WriteLine("Start engine");
        }

        public void Stop()
        {
            Console.WriteLine("Stop engine");
        }
    }

    public class Bike : IVehicle
    {
        public int MaxSpeed { get; set; }

        // Додано функціонал для методу IncreaseSpeed
        public void IncreaseSpeed()
        {
            Console.WriteLine("Increasing speed...");
        }

        public void Start()
        {
            Console.WriteLine("Start ride");
        }

        public void Stop()
        {
            Console.WriteLine("Stop ride");
        }
    }
}
