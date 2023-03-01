using System.Text.RegularExpressions;

namespace Questionnaire.Application.Service.Message;

public abstract class BaseMessage<T> where T : class
{
    public readonly T Data;

    protected BaseMessage(T data)
    {
        Data = data;
    }

    public abstract string EntitySlotting();

    public string Replace(string template, Dictionary<string, string> map)
    {
        var replaced = template;
        foreach (var key in map.Keys)
        {
            var pattern = $"{key}";
            replaced = Regex.Replace(replaced, pattern, map[key]);
        }

        return replaced;
    }
}