using AutoMapper;
using CashFlow.COMMUNICATION.REQUESTS;
using CashFlow.COMMUNICATION.RESPONSES;
using CashFlow.DOMAIN.Entities;

namespace CashFlow.APPLICATION.AutoMapper;

public class AutoMapping : Profile
{
	public AutoMapping()
	{
		RequestToEntity();
		EntityToResponse();
    }

	private void RequestToEntity()
	{
		CreateMap<RequestExpenseJson, Expense>(); // -> Atribuindo os valores das requests na Entidade
	}

	private void EntityToResponse()
	{
		CreateMap<Expense, ReponseRegisteredExpenseJson>(); // -> Atribuindo os valores das Entidades nas Respostas
		CreateMap<Expense, ResponseShortExpenseJson>(); // -> Atribuindo os valores das Entidades nas Respostas
		CreateMap<Expense, ResponseExpenseJson>(); // -> Atribuindo os valores das Entidades nas Respostas
    }

}
