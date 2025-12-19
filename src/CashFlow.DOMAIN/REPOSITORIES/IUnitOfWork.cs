namespace CashFlow.DOMAIN.REPOSITORIES;

public interface IUnitOfWork
{
    Task Commit();
}
