using Questionnaire.Application.Common.Interfaces;
using Questionnaire.Application.Service.Dto;
using Questionnaire.Application.Service.Preprocessing;

namespace Questionnaire.Application.Service.Message;

public class NoAdviceMessage : BaseMessage<AdviceDto>
{
    private readonly ILexicalization _lex;
    private readonly ITemplateProvider _templateProvider;

    public NoAdviceMessage(
        AdviceDto data,
        ILexicalization lex,
        ITemplateProvider templateProvider) : base(data)
    {
        _lex = lex;
        _templateProvider = templateProvider;
    }


    public override string Lexicalization()
    {
        var advice = Util.GetRandom(Data.Advice);
        var sentence = _templateProvider.Template["no advice"]
            .Replace("{Lecturer}", Data.Lecturer)
            .Replace("{advice}", advice);
        return sentence;
    }
}