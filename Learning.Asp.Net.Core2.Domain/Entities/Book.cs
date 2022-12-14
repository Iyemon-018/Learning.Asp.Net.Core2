namespace Learning.Asp.Net.Core2.Domain.Entities;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

public sealed class Book
{
    public int Id { get; set; }

    [DisplayName("書名")]
    public string Title { get; set; }

    [DisplayName("価格")]
    [DataType(DataType.Currency)]
    public int Price { get; set; }

    [DisplayName("出版社")]
    public string Publisher { get; set; }

    [DisplayName("配布サンプル")]
    public bool Sample { get; set; }
}