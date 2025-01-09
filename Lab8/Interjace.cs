public interface IRepository<T>
{
    void Save(T item);
    T Get(int id);
    IEnumerable<T> GetAll();
    void Delete(int id);
}