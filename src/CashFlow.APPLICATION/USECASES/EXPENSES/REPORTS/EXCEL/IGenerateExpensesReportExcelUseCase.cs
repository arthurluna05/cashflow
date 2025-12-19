namespace CashFlow.APPLICATION.USECASES.EXPENSES.REPORTS.EXCEL;

public interface IGenerateExpensesReportExcelUseCase
{
    Task<byte[]> Execute(DateOnly month);
}
