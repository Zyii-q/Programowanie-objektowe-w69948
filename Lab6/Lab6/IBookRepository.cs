using Interfaces;
namespace Lab6
{
    public interface IBookRepository
    {
        void Create(Book entity);
        Book Get(long id);
        List<Book> GetAll();
        void Update(Book entity);
        void Delete(long id);
        List<Book> GetBooksByAuthor(string author);
        List<Book> GetBooksByPublishYear(int year);
    }
}
