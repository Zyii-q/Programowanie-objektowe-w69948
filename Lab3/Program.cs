using System;
using System.Collections.Generic;

// Klasa bazowa Shape
public abstract class Shape
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Height { get; set; }
    public int Width { get; set; }

    // Wirtualna metoda Draw
    public abstract void Draw();
}

// Klasa Rectangle dziedzicząca z Shape
public class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine($"Drawing a rectangle at ({X}, {Y}) with height {Height} and width {Width}");
    }
}

// Klasa Triangle dziedzicząca z Shape
public class Triangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine($"Drawing a triangle at ({X}, {Y}) with height {Height} and width {Width}");
    }
}

// Klasa Circle dziedzicząca z Shape
public class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine($"Drawing a circle at ({X}, {Y}) with radius {Width / 2}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Tworzenie listy kształtów
        List<Shape> shapes = new List<Shape>();

        // Dodawanie obiektów do listy
        shapes.Add(new Rectangle { X = 10, Y = 20, Height = 30, Width = 40 });
        shapes.Add(new Triangle { X = 50, Y = 60, Height = 70, Width = 80 });
        shapes.Add(new Circle { X = 90, Y = 100, Width = 110 }); // Width użyty jako średnica

        // Wywołanie metody Draw dla każdego kształtu w liście
        foreach (var shape in shapes)
        {
            shape.Draw();
        }
    }
}