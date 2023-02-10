using Questionnaire.Application.Common.Interfaces;
using Questionnaire.Application.Dto;

namespace Questionnaire.Application.Message;

public class OpeningMessage : BaseMessage<OpeningDto>
{
    private readonly ILexicalization _lex;

    public OpeningMessage(OpeningDto data, ILexicalization lex) : base(data)
    {
        _lex = lex;
    }

    public override string Lexicalization()
    {
        var sentence =
            $"pada tanggal {Data.Date}, telah dilakukan survey dengan topik {Data.Subject} yang dijawab oleh {Data.Respondent} di lingkungan {Data.Place}.";
        return sentence;
    }
}