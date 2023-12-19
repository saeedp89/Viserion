namespace Viserion.Domain;

public interface IRepository<T>
{
    IUnitOfWork UnitOfWork { get; }
}