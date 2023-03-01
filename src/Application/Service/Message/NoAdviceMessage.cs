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

    private Dictionary<string, string> LoadReplacement()
    {
        return new Dictionary<string, string> { { "{Lecturer}", Data.Lecturer } };
    }

    public override string EntitySlotting()
    {
        var advice = Util.GetRandom(Data.Advice);
        var replacement = LoadReplacement();
        replacement.Add("{advice}", advice);
        var sentence = Replace(_templateProvider.Template["no advice"], replacement);
        return sentence;
    }
}