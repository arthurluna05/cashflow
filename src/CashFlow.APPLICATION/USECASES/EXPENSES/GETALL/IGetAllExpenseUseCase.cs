using CashFlow.COMMUNICATION.REQUESTS;
using CashFlow.COMMUNICATION.RESPONSES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashFlow.APPLICATION.USECASES.EXPENSES.GETALL;

public interface IGetAllExpenseUseCase
{
    Task<ResponseExpensesJson> Execute();
}
