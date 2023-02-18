using System.Text.RegularExpressions;
using Questionnaire.Application.Common.Interfaces;
using Questionnaire.Application.Service.Dto;

namespace Questionnaire.Application.Service.Message;

public class OpeningMessage : BaseMessage<OpeningDto>
{
    private readonly ILexicalization _lex;

    public OpeningMessage(OpeningDto data, ILexicalization lex) : base(data)
    {
        _lex = lex;
    }

    private string _template =
        "pada tanggal {Date}, telah dilakukan survey dengan topik {Subject} yang dijawab oleh {Respondent} di lingkungan {Place}.";

    public override string Lexicalization()
    {
        var sentence = _template;
        sentence = sentence.Replace("{Date}", Data.Date.ToString())
            .Replace("{Subject}", Data.Subject)
            .Replace("{Respondent}", Data.Respondent)
            .Replace("{Place}", Data.Place);
        return sentence;
    }
}