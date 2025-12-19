using CashFlow.DOMAIN.Entities;

namespace CashFlow.DOMAIN.REPOSITORIES.EXPENSES;

public interface IExpensesReadOnlyRepository
{
    Task<List<Expense>> GetAll();

    Task<Expense?> GetById(long id);
    Task<List<Expense>> FilterByMonth(DateOnly date);
}
