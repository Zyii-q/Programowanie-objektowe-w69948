using Lab6;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            var bookRepo = new BookRepository();
            var personRepo = new PersonRepository();

            
            var book = new Book { Title = "New Book", Author = "Author Name", PublishDate = DateTime.Now };
            bookRepo.Create(book);

           
            var person = new Person { FirstName = "John", LastName = "Doe", Age = 30 };
            personRepo.Create(person);

           
            personRepo.BorrowBook(1, book);

            
            var borrowedBooks = personRepo.GetBorrowedBook(1);
            Console.WriteLine($"Borrowed books for {person.FirstName} {person.LastName}:");
            foreach (var b in borrowedBooks)
            {
                Console.WriteLine($"- {b.Title} by {b.Author}");
            }
        }
    }
}
