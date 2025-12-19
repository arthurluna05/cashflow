using AutoMapper;
using CashFlow.COMMUNICATION.REQUESTS;
using CashFlow.COMMUNICATION.RESPONSES;
using CashFlow.DOMAIN.Entities;
using CashFlow.DOMAIN.REPOSITORIES;
using CashFlow.DOMAIN.REPOSITORIES.EXPENSES;
using CashFlow.EXCEPTION.ExceptionsBase;

namespace CashFlow.APPLICATION.USECASES.EXPENSES.REGISTER;

public class RegisterExpenseUseCase : IRegisterExpenseUseCase
{

    private readonly IExpensesWriteOnlyRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public RegisterExpenseUseCase(IExpensesWriteOnlyRepository repository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    public async Task<ReponseRegisteredExpenseJson> Execute(RequestExpenseJson request)
    {
        Validate(request);

        /* var entity = new Expense // criando a tabela
         {
             Amount = request.Amount,
             Date = request.Date,
             Description = request.Description,
             Title = request.Title,
             PaymentType = (DOMAIN.ENUMS.PaymentType)request.PaymentType,
         }; -> Agora é função do AutoMapper
         */

        var entity = _mapper.Map<Expense>(request);

        await _repository.Add(entity);
        await _unitOfWork.Commit(); //Salvando no BD

       
        return _mapper.Map<ReponseRegisteredExpenseJson>(entity);
    }

    private void Validate(RequestExpenseJson request) 
    {
        var validator = new ExpenseValidator();

        var result = validator.Validate(request);

        if (result.IsValid == false) 
        {
            var errorMessages = result.Errors.Select(f => f.ErrorMessage).ToList();


            throw new ErrorOnValidationException(errorMessages);
            //throw new ErrorOnValidationException(errorMessages);
            
        
        }
    }

}