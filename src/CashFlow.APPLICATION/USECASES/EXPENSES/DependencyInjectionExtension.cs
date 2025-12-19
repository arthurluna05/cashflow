using CashFlow.APPLICATION.AutoMapper;
using CashFlow.APPLICATION.USECASES.EXPENSES.DELETE;
using CashFlow.APPLICATION.USECASES.EXPENSES.GETALL;
using CashFlow.APPLICATION.USECASES.EXPENSES.GETBYID;
using CashFlow.APPLICATION.USECASES.EXPENSES.REGISTER;
using CashFlow.APPLICATION.USECASES.EXPENSES.REPORTS.EXCEL;
using CashFlow.APPLICATION.USECASES.EXPENSES.REPORTS.PDF;
using CashFlow.APPLICATION.USECASES.EXPENSES.UPDATE;
using Microsoft.Extensions.DependencyInjection;

public static class DependencyInjectionExtension
{
    public static void AddApplication(this IServiceCollection services) 
    {
        AddAutoMapper(services);
        AddUseCase(services);
    }

    private static void AddAutoMapper(IServiceCollection services) 
    {
        services.AddAutoMapper(typeof(AutoMapping));
    }

    private static void AddUseCase(IServiceCollection services)
    {
        services.AddScoped<IRegisterExpenseUseCase, RegisterExpenseUseCase>();
        services.AddScoped<IGetAllExpenseUseCase, GetAllExpenseUseCase>();
        services.AddScoped<IGetExpenseByIdUseCase, GetExpenseByIdUseCase>();
        services.AddScoped<IDeleteExpenseUseCase, DeleteExpenseUseCase>();
        services.AddScoped<IUpdateExpenseUseCase, UpdateExpenseUseCase>();
        services.AddScoped<IGenerateExpensesReportExcelUseCase, GenerateExpensesReportExcelUseCase>();
        services.AddScoped<IGenerateExpensesReportPdfUseCase, GenerateExpensesReportPdfUseCase>();
    }
}
