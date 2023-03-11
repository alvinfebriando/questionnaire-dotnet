using Questionnaire.Application.Common.Interfaces;
using Questionnaire.Application.Service.Dto;

namespace Questionnaire.Application.Service.Message;

public class OpeningMessage : BaseMessage<OpeningDto>
{
    private readonly ILexicalization _lex;

    public OpeningMessage(
        OpeningDto data,
        ILexicalization lex,
        ITemplateProvider templateProvider) : base(data)
    {
        _lex = lex;
        Template = templateProvider.Get("opening");
    }

    public override string EntitySlotting()
    {
        var sentence = Replace(LoadReplacement());
        return sentence;
    }

    private Dictionary<string, string> LoadReplacement()
    {
        return new Dictionary<string, string>
        {
            { "{Date}", Data.Date.ToString() },
            { "{Subject}", Data.Subject },
            { "{Respondent}", Data.Respondent },
            { "{Place}", Data.Place }
        };
    }
}