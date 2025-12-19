using CashFlow.DOMAIN.REPOSITORIES;
using CashFlow.DOMAIN.REPOSITORIES.EXPENSES;
using CashFlow.INFRASTRUCTURE.DataAccess;
using CashFlow.INFRASTRUCTURE.DataAccess.REPOSITORIES;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CashFlow.INFRASTRUCTURE;

public static class DependencyInjectionExtension
{
    public static void AddInfraestructure(this IServiceCollection services, IConfiguration configuration) 
    {
        AddDbContext(services, configuration);
        AddRepositories(services);

    }

    private static void AddRepositories(IServiceCollection services)
    {
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<IExpensesReadOnlyRepository, ExpensesRepository>();
        services.AddScoped<IExpensesWriteOnlyRepository, ExpensesRepository>();
        services.AddScoped<IExpensesUpdateOnlyRepository, ExpensesRepository>();
    }
    private static void AddDbContext(IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("Connection");

        var version = new Version(8, 0, 44);
        var serverVersion = new MySqlServerVersion(version);

        services.AddDbContext<CashFlowDBContext>(config => config.UseMySql(connectionString, serverVersion)); ;
    }

}
