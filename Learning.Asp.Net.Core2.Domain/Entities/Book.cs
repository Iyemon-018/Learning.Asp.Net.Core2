namespace Learning.Asp.Net.Core2.Domain.Entities;

public sealed class Book
{
    public int Id { get; set; }

    public string Title { get; set; }

    public int Price { get; set; }

    public string Publisher { get; set; }

    public bool Sample { get; set; }
}