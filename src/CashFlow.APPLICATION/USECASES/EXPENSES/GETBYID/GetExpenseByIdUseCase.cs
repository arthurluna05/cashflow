using AutoMapper;
using CashFlow.COMMUNICATION.RESPONSES;
using CashFlow.DOMAIN.REPOSITORIES.EXPENSES;
using CashFlow.EXCEPTION;
using CashFlow.EXCEPTION.ExceptionsBase;

namespace CashFlow.APPLICATION.USECASES.EXPENSES.GETBYID;

public class GetExpenseByIdUseCase : IGetExpenseByIdUseCase
{
    private readonly IExpensesReadOnlyRepository _repository;
    private readonly IMapper _mapper;

    public GetExpenseByIdUseCase(IExpensesReadOnlyRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<ResponseExpenseJson> Execute(long id)
    {
        var result = await _repository.GetById(id);

        if(result is null) 
        {
            throw new NotFoundException(ResourceErrorMessages.EXPENSE_NOT_FOUND);
        }

        return _mapper.Map<ResponseExpenseJson>(result);
    }
}
