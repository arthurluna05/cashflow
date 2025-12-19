using CashFlow.COMMUNICATION.REQUESTS;
using CashFlow.COMMUNICATION.RESPONSES;

namespace CashFlow.APPLICATION.USECASES.EXPENSES.UPDATE;

public interface IUpdateExpenseUseCase
{
    Task Execute(long id, RequestExpenseJson request);

}
