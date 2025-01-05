namespace Lab5
{
    public abstract class Shape
    {
        // Виправлено помилку в назві методу "CalulateArea" -> "CalculateArea"
        public abstract double CalculateArea();
    }

    public class Square : Shape
    {
        public double X { get; set; }

        public override double CalculateArea()
        {
            if (X < 0)
            {
                // Додано змістовне повідомлення до винятку
                throw new ArgumentException("Side length cannot be negative.");
            }
            return X * X;
        }
    }

    public class Circle : Shape
    {
        public double R { get; set; }

        public override double CalculateArea()
        {
            if (R < 0)
            {
                // Додано перевірку для від'ємного радіуса
                throw new ArgumentException("Radius cannot be negative.");
            }
            return Math.PI * Math.Pow(R, 2);
        }
    }
}
