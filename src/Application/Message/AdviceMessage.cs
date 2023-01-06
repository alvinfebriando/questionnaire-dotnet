using Questionnaire.Application.Dto;
using Questionnaire.Application.Lexicalization;
using Questionnaire.Domain.ValueObjects;

namespace Questionnaire.Application.Message;

public class AdviceMessage : BaseMessage<AdviceDto>
{
    private readonly ILexicalization _lex;

    public AdviceMessage(AdviceDto data, ILexicalization lex) : base(data)
    {
        _lex = lex;
    }

    public override string Lexicalization()
    {
        var advice = Util.GetRandom(Data.Advice);
        var sentence =
            $"{Data.Lecturer} dapat melakukan cara ini untuk meningkatkan {_lex.Search("nilai")} evaluasi, yaitu {advice}.";
        return sentence;
    }

    public string Lexicalization(IList<IList<string>> advices)
    {
        var sentence = "";
        var advice1 = Util.GetRandom(Data.Advice);
        var advice2 = Util.GetRandom(advices[0]);
        if (advices.Count == 1)
        {
            sentence =
                $"{Data.Lecturer} dapat melakukan cara-cara ini untuk meningkatkan {_lex.Search("nilai")} hasil evaluasi yaitu, {advice1} dan {advice2}";
        }
        else
        {
            var advice3 = Util.GetRandom(advices[1]);
            sentence =
                $"{Data.Lecturer} dapat melakukan cara-cara ini untuk meningkatkan {_lex.Search("nilai")} hasil evaluasi yaitu, {advice1}, {advice2}, dan {advice3}";
        }

        return sentence;
    }
}