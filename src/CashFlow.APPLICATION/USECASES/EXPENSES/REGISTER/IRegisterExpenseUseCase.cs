using CashFlow.COMMUNICATION.REQUESTS;
using CashFlow.COMMUNICATION.RESPONSES;

namespace CashFlow.APPLICATION.USECASES.EXPENSES.REGISTER;

public interface IRegisterExpenseUseCase
{
    Task<ReponseRegisteredExpenseJson> Execute(RequestExpenseJson request);

}
