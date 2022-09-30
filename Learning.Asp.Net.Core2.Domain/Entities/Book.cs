﻿namespace Learning.Asp.Net.Core2.Domain.Entities;

using System.ComponentModel;

public sealed class Book
{
    public int Id { get; set; }

    [DisplayName("書名")]
    public string Title { get; set; }

    [DisplayName("価格")]
    public int Price { get; set; }

    [DisplayName("出版社")]
    public string Publisher { get; set; }

    [DisplayName("配布サンプル")]
    public bool Sample { get; set; }
}