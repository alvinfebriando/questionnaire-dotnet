using Questionnaire.Application.Common.Interfaces;
using Questionnaire.Application.Service.Dto;

namespace Questionnaire.Application.Service.Message;

public class OpeningMessage : BaseMessage<OpeningDto>
{
    private readonly ILexicalization _lex;
    private readonly ITemplateProvider _templateProvider;
    private readonly Dictionary<string, string> _replacement;

    public OpeningMessage(
        OpeningDto data,
        ILexicalization lex,
        ITemplateProvider templateProvider) : base(data)
    {
        _lex = lex;
        _templateProvider = templateProvider;
    }

    public override string EntitySlotting()
    {
        var sentence = Replace(_templateProvider.Template["opening"], LoadReplacement());
        return sentence;
    }

    private Dictionary<string, string> LoadReplacement()
    {
        return new Dictionary<string, string>
        {
            { "{Date}", Data.Date.ToString() },
            { "{Subject}", Data.Subject },
            { "{Respondent}", Data.Respondent },
            { "{Place}", Data.Place },
        };
    }
}