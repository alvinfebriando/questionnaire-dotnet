using Questionnaire.Application.Common.Interfaces;
using Questionnaire.Application.Service.Dto;
using Questionnaire.Application.Service.Preprocessing;

namespace Questionnaire.Application.Service.Message;

public class NoAdviceMessage : BaseMessage<AdviceDto>
{
    private readonly ILexicalization _lex;

    public NoAdviceMessage(AdviceDto data, ILexicalization lex) : base(data)
    {
        _lex = lex;
    }

    private string _template =
        "performa {Data.Lecturer} sudah cukup baik, namun beliau dapat melakukan {advice} untuk mempertahankan nilai pada evaluasi mendatang";


    public override string Lexicalization()
    {
        var advice = Util.GetRandom(Data.Advice);
        var sentence = _template.Replace("{Data.Lecturer}", Data.Lecturer)
            .Replace("{advice}", advice);
        return sentence;
    }
}