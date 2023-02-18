using Questionnaire.Application.Common.Interfaces;
using Questionnaire.Application.Service.Dto;
using Questionnaire.Application.Service.Preprocessing;

namespace Questionnaire.Application.Service.Message;

public class AdviceMessage : BaseMessage<AdviceDto>
{
    private readonly ILexicalization _lex;

    public AdviceMessage(AdviceDto data, ILexicalization lex) : base(data)
    {
        _lex = lex;
    }

    private string _template1 =
        "{Data.Lecturer} dapat melakukan cara ini untuk meningkatkan {_lex.Search(nilai)} evaluasi, yaitu {advice}.";

    private string _template2 =
        "{Data.Lecturer} dapat melakukan cara-cara ini untuk meningkatkan {_lex.Search(nilai)} hasil evaluasi yaitu, {advice1} dan {advice2}";

    private string _template3 =
        "{Data.Lecturer} dapat melakukan cara-cara ini untuk meningkatkan {_lex.Search(nilai)} hasil evaluasi yaitu, {advice1}, {advice2}, dan {advice3}";


    public override string Lexicalization()
    {
        var advice = Util.GetRandom(Data.Advice);
        var sentence = _template1.Replace("{Data.Lecturer}", Data.Lecturer)
            .Replace("{_lex.Search(nilai)}", _lex.Search("nilai"))
            .Replace("{advice}", advice);
        return sentence;
    }

    public string Lexicalization(IList<IList<string>> advices)
    {
        var sentence = "";
        var advice1 = Util.GetRandom(Data.Advice);
        var advice2 = Util.GetRandom(advices[0]);
        if (advices.Count == 1)
        {
            sentence = _template2.Replace("{Data.Lecturer}", Data.Lecturer)
                .Replace("{_lex.Search(nilai)}", _lex.Search("nilai"))
                .Replace("{advice1}", advice1)
                .Replace("{advice2}", advice2);
        }
        else
        {
            var advice3 = Util.GetRandom(advices[1]);
            sentence = _template3.Replace("{Data.Lecturer}", Data.Lecturer)
                .Replace("{_lex.Search(nilai)}", _lex.Search("nilai"))
                .Replace("{advice1}", advice1)
                .Replace("{advice2}", advice2)
                .Replace("{advice3}", advice3);
        }

        return sentence;
    }
}