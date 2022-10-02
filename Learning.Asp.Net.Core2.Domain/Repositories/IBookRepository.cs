namespace Learning.Asp.Net.Core2.Domain.Repositories;

using Entities;

public interface IBookRepository
{
    IEnumerable<Book> GetAll();

    Task<IEnumerable<Book>> GetAllAsync();

    Task<Book> FindAsync(int id);

    void Add(Book item);

    void Update(Book item);

    void Remove(Book item);
}