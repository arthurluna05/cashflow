using CashFlow.COMMUNICATION.RESPONSES;

namespace CashFlow.APPLICATION.USECASES.EXPENSES.DELETE;

public interface IDeleteExpenseUseCase
{
    Task Execute(long id);

}
