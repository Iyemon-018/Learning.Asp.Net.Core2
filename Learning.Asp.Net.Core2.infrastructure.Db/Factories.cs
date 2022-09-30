namespace Learning.Asp.Net.Core2.infrastructure.Db;

using Domain;

public static class Factories
{
    public static IUnitOfWork UnitOfWork() => new UnitOfWork();
}