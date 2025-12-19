using CashFlow.DOMAIN.Entities;

namespace CashFlow.DOMAIN.REPOSITORIES.EXPENSES;

public interface IExpensesUpdateOnlyRepository
{
    Task<Expense?> GetById(long id);
    void Update(Expense expense);
}
