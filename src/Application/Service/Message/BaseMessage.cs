namespace Questionnaire.Application.Service.Message;

public abstract class BaseMessage<T> where T : class
{
    public readonly T Data;

    protected BaseMessage(T data)
    {
        Data = data;
    }

    public abstract string Lexicalization();
}