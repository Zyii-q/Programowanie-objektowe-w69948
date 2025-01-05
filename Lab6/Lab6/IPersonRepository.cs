using Interfaces;
using System;

namespace Lab6
{
    public interface IPersonRepository
    {
        void Create(Person input);
        Person Get(int id);
        List<Person> GetAll();
        void Update(Person input);
        void Delete(int id);
        void BorrowBook(int id, Book book);
        List<Book> GetBorrowedBook(int id);
    }
}
