using Questionnaire.Application.Common.Interfaces;
using Questionnaire.Application.Service.Dto;

namespace Questionnaire.Application.Service.Message;

public class ClosingMessage : BaseMessage<CLosingDto>
{
    private readonly ILexicalization _lex;
    private readonly ITemplateProvider _templateProvider;
    public ClosingMessage(CLosingDto data, ILexicalization lex, ITemplateProvider templateProvider) : base(data)
    {
        _lex = lex;
        _templateProvider = templateProvider;
    }
    private Dictionary<string, string> LoadReplacement()
    {
        return new Dictionary<string, string>
        {
            { "{Subject}", Data.Subject }
        };
    }

    public override string EntitySlotting()
    {
        var replacement = LoadReplacement();
        Template = _templateProvider.Get("closing");
        var sentence = Replace(replacement);
        return sentence;
    }
}