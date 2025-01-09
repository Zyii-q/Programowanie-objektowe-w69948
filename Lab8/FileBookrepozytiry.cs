using System;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "books.json";
        var repository = new FileBookRepository(filePath);

        // Dodanie książki
        var newBook = new Book
        {
            Id = 1,
            Title = "C# in Depth",
            Author = "Jon Skeet",
            Price = 99.99m
        };
        repository.Save(newBook);

        // Odczyt książki
        var book = repository.Get(1);
        Console.WriteLine($"Odczytano książkę: {book.Title} autor: {book.Author}, cena: {book.Price}");

        // Pobranie wszystkich książek
        var books = repository.GetAll();
        Console.WriteLine("\nWszystkie książki:");
        foreach (var b in books)
        {
            Console.WriteLine($"{b.Title} autor: {b.Author}, cena: {b.Price}");
        }

        // Usunięcie książki
        repository.Delete(1);
        Console.WriteLine("\nPo usunięciu książki:");
        books = repository.GetAll();
        foreach (var b in books)
        {
            Console.WriteLine($"{b.Title} autor: {b.Author}, cena: {b.Price}");
        }
    }
}
