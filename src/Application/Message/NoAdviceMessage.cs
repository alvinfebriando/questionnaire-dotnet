using Questionnaire.Application.Dto;
using Questionnaire.Application.Lexicalization;

namespace Questionnaire.Application.Message;

public class NoAdviceMessage : BaseMessage<AdviceDto>
{
    private readonly ILexicalization _lex;

    public NoAdviceMessage(AdviceDto data, ILexicalization lex) : base(data)
    {
        _lex = lex;
    }

    public override string Lexicalization()
    {
        var advice = Util.GetRandom(Data.Advice);
        var sentence =
            $"performa {Data.Lecturer} sudah cukup baik, namun beliau dapat melakukan {advice} untuk mempertahankan nilai pada evaluasi mendatang";
        return sentence;
    }
}