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

    public override string EntitySlotting()
    {
        var advice = Util.GetRandom(Data.Advice);
        var sentence = _templateProvider.Template["advice1"]
            .Replace("{Lecturer}", Data.Lecturer)
            .Replace("{Search(nilai)}", _lex.Search("nilai"))
            .Replace("{advice}", advice);
        return sentence;
    }

    public string EntitySlotting(IList<IList<string>> advices)
    {
        string sentence;
        var advice1 = Util.GetRandom(Data.Advice);
        var advice2 = Util.GetRandom(advices[0]);
        if (advices.Count == 1)
        {
            sentence = _templateProvider.Template["advice2"]
                .Replace("{Lecturer}", Data.Lecturer)
                .Replace("{Search(nilai)}", _lex.Search("nilai"))
                .Replace("{advice1}", advice1)
                .Replace("{advice2}", advice2);
        }
        else
        {
            var advice3 = Util.GetRandom(advices[1]);
            sentence = _templateProvider.Template["advice3"]
                .Replace("{Lecturer}", Data.Lecturer)
                .Replace("{Search(nilai)}", _lex.Search("nilai"))
                .Replace("{advice1}", advice1)
                .Replace("{advice2}", advice2)
                .Replace("{advice3}", advice3);
        }

        return sentence;
    }
}