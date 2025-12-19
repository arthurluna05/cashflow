using AutoMapper;
using CashFlow.COMMUNICATION.RESPONSES;
using CashFlow.DOMAIN.REPOSITORIES;
using CashFlow.DOMAIN.REPOSITORIES.EXPENSES;
using CashFlow.EXCEPTION;
using CashFlow.EXCEPTION.ExceptionsBase;

namespace CashFlow.APPLICATION.USECASES.EXPENSES.DELETE;

public class DeleteExpenseUseCase : IDeleteExpenseUseCase
{
    private readonly IExpensesWriteOnlyRepository _repository;
    private readonly IUnitOfWork _unitOfWork;

    public DeleteExpenseUseCase(IExpensesWriteOnlyRepository repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }

    public async Task Execute(long id) 
    {
        var result = await _repository.Delete(id);

        if (result is false) 
        {
            throw new NotFoundException(ResourceErrorMessages.EXPENSE_NOT_FOUND);
        }

        await _unitOfWork.Commit();
    }
}
