using AutoMapper;
using CashFlow.APPLICATION.USECASES.EXPENSES.REGISTER;
using CashFlow.COMMUNICATION.REQUESTS;
using CashFlow.DOMAIN.REPOSITORIES;
using CashFlow.DOMAIN.REPOSITORIES.EXPENSES;
using CashFlow.EXCEPTION;
using CashFlow.EXCEPTION.ExceptionsBase;
using Microsoft.Extensions.Options;

namespace CashFlow.APPLICATION.USECASES.EXPENSES.UPDATE;

public class UpdateExpenseUseCase : IUpdateExpenseUseCase
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IExpensesUpdateOnlyRepository _repository;

    public UpdateExpenseUseCase(IMapper mapper, IUnitOfWork unitOfWork, IExpensesUpdateOnlyRepository repository)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
        _repository = repository;
    }

    public async Task Execute(long id, RequestExpenseJson request) 
    {
        Validate(request);

        var expense = await _repository.GetById(id);

        if (expense is null) 
        {
            throw new NotFoundException(ResourceErrorMessages.EXPENSE_NOT_FOUND);
        }

        _mapper.Map(request, expense);

        _repository.Update(expense);

        await _unitOfWork.Commit();
    
    }

    private void Validate(RequestExpenseJson request)
    {
        var validator = new ExpenseValidator();

        var result = validator.Validate(request);

        if (result.IsValid == false) 
        {
            var errorMessages = result.Errors.Select(f => f.ErrorMessage).ToList();

            throw new ErrorOnValidationException(errorMessages);
        }
    
    }

}
