using System.Text.RegularExpressions;
using Questionnaire.Application.Common.Interfaces;
using Questionnaire.Application.Service.Dto;

namespace Questionnaire.Application.Service.Message;

public class OpeningMessage : BaseMessage<OpeningDto>
{
    private readonly ILexicalization _lex;
    private readonly ITemplateProvider _templateProvider;

    public OpeningMessage(OpeningDto data, ILexicalization lex, ITemplateProvider templateProvider) : base(data)
    {
        _lex = lex;
        _templateProvider = templateProvider;
    }

    public override string Lexicalization()
    {
        var sentence = _templateProvider.Template["opening"].Replace("{Date}", Data.Date.ToString())
            .Replace("{Subject}", Data.Subject)
            .Replace("{Respondent}", Data.Respondent)
            .Replace("{Place}", Data.Place);
        return sentence;
    }
}