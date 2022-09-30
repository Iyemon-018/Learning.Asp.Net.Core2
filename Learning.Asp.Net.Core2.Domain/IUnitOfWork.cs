namespace Learning.Asp.Net.Core2.Domain;

using Repositories;

public interface IUnitOfWork
{
    IBookRepository BookRepository { get; }
}