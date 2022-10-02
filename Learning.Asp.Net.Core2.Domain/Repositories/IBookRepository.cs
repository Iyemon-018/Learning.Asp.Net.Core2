namespace Learning.Asp.Net.Core2.Domain.Repositories;

using Entities;

public interface IBookRepository
{
    IEnumerable<Book> GetAll();

    Task<IEnumerable<Book>> GetAllAsync();

    void Add(Book item);

    void Update(Book item);
}