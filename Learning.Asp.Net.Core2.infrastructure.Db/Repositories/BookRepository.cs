namespace Learning.Asp.Net.Core2.infrastructure.Db.Repositories;

using Domain.Entities;
using Domain.Repositories;

internal sealed class BookRepository : IBookRepository
{
    private readonly List<Book> _all
            = new()
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

    public IEnumerable<Book> GetAll()
    {
        return _all;
    }

    public async Task<IEnumerable<Book>> GetAllAsync()
    {
        return await Task.Run(GetAll);
    }

    public void Add(Book item)
    {
        _all.Add(item);
    }

    public void Update(Book item)
    {
        var target = _all.FirstOrDefault(book => book.Id == item.Id);
        if (target is null) return;

        target.Title     = item.Title;
        target.Price     = item.Price;
        target.Publisher = item.Publisher;
        target.Sample    = item.Sample;
    }
}