namespace CashFlow.APPLICATION.USECASES.EXPENSES.REPORTS.PDF;

public interface IGenerateExpensesReportPdfUseCase
{
    Task<byte[]> Execute(DateOnly month);
}
