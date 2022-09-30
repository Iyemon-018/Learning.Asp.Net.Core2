namespace Learning.Asp.Net.Core2.infrastructure.Db.Repositories;

using Domain.Entities;
using Domain.Repositories;

internal sealed class BookRepository : IBookRepository
{
    public IEnumerable<Book> GetAll()
    {
        return new Book[]
               {
                   new()
                   {
                       Id = 1, Price = 1000, Publisher = "翔泳社", Title = "速習 ASP.NET Core 3", Sample = false
                   }
                 , new()
                   {
                       Id = 2, Price = 2420, Publisher = "リックテレコム", Title = "BERT入門", Sample = false
                   }
                 , new()
                   {
                       Id = 2, Price = 2640, Publisher = "オライリージャパン", Title = "リーダブルコード", Sample = false
                   }
               };
    }

    public async Task<IEnumerable<Book>> GetAllAsync()
    {
        return await Task.Run(GetAll);
    }
}