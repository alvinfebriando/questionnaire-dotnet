using System.Text.RegularExpressions;

namespace Questionnaire.Application.Service.Message;

public abstract class BaseMessage<T> where T : class
{
    public readonly T Data;
    public string Template { get; set; }
    protected BaseMessage(T data)
    {
        Data = data;
    }

    public abstract string EntitySlotting();

    public string Replace(Dictionary<string, string> map)
    {
        var replaced = Template;
        foreach (var key in map.Keys)
        {
            var pattern = $"{key}";
            replaced = Regex.Replace(replaced, pattern, map[key]);
        }

        return replaced;
    }
}