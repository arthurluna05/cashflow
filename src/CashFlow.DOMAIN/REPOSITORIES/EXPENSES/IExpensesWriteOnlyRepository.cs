using CashFlow.DOMAIN.Entities;

namespace CashFlow.DOMAIN.REPOSITORIES.EXPENSES;

public interface IExpensesWriteOnlyRepository
{
    Task Add(Expense expense);
    /// <summary>
    /// This function returns TRUE if the deletion was successful
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<bool> Delete(long id);

}
