namespace CashFlow.COMMUNICATION.RESPONSES;

public class ResponseErrorJson //CLASSE PARA TRANSFORMAR ERROS EM JSON
{
    public List <string> ErrorMessages { get; set; }

    public ResponseErrorJson(string errorMessage) // CONSTRUTOR PARA A MENSAGEM SER OBRIGATORIA OU SO UTILZIAR REQUIRED
    {
        ErrorMessages = [errorMessage];
    }

    public ResponseErrorJson(List<string> errorMessages) // CONSTRUTOR PARA A MENSAGEM SER OBRIGATORIA OU SO UTILZIAR REQUIRED
    {
        ErrorMessages = errorMessages;
    }
}
