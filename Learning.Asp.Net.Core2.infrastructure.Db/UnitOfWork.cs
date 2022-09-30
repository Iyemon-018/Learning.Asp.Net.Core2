namespace Learning.Asp.Net.Core2.infrastructure.Db;

using Domain;
using Domain.Repositories;
using Repositories;

internal sealed class UnitOfWork : IUnitOfWork
{
    private IBookRepository _bookRepository;
        
    public IBookRepository BookRepository => _bookRepository ??= new BookRepository();
}