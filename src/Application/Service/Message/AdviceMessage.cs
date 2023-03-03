using Questionnaire.Application.Common.Interfaces;
using Questionnaire.Application.Service.Dto;
using Questionnaire.Application.Service.Preprocessing;

namespace Questionnaire.Application.Service.Message;

public class AdviceMessage : BaseMessage<AdviceDto>
{
    private readonly ILexicalization _lex;
    private readonly ITemplateProvider _templateProvider;

    public AdviceMessage(
        AdviceDto data,
        ILexicalization lex,
        ITemplateProvider templateProvider) : base(data)
    {
        _lex = lex;
        _templateProvider = templateProvider;
    }

    private Dictionary<string, string> LoadReplacement()
    {
        return new Dictionary<string, string>
        {
            { "{Lecturer}", Data.Lecturer }, { "{Search-nilai}", _lex.Search("nilai") }
        };
    }

    public override string EntitySlotting()
    {
        var advice = Util.GetRandom(Data.Advice);
        var replacement = LoadReplacement();
        replacement.Add("{advice}", advice);
        var sentence = Replace(_templateProvider.Template["advice1"], replacement);
        return sentence;
    }

    public string EntitySlotting(IList<IList<string>> advices)
    {
        string sentence;
        var advice1 = Util.GetRandom(Data.Advice);
        var advice2 = Util.GetRandom(advices[0]);
        var replacement = LoadReplacement();
        replacement.Add("{advice1}", advice1);
        replacement.Add("{advice2}", advice2);
        if (advices.Count == 1)
        {
            sentence = Replace(_templateProvider.Template["advice2"], replacement);
        }
        else
        {
            var advice3 = Util.GetRandom(advices[1]);
            replacement.Add("{advice3}", advice3);
            sentence = Replace(_templateProvider.Template["advice3"], replacement);
        }

        return sentence;
    }
}