using CashFlow.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;

//USANDO ENTITY FRAMEWORK COM O DATABASE CRIADO NO MYSQL PARA CONFIGURAR BD
namespace CashFlow.INFRASTRUCTURE.DataAccess;

internal class CashFlowDBContext : DbContext
{
    public CashFlowDBContext(DbContextOptions options) : base(options){ }

    public DbSet<Expense> Expenses { get; set; }// Expenses = tabela

}
