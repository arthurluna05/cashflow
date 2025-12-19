
namespace CashFlow.EXCEPTION.ExceptionsBase;

public class NotFoundException : CashFlowException
{
    public NotFoundException(string message) : base(message)
    {

    }

    public override int StatusCode => throw new NotImplementedException();

    public override List<string> GetErrors()
    {
        return [Message];
    }
}
