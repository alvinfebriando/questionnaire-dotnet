using Questionnaire.Application.Common.Interfaces;
using Questionnaire.Application.Service.Dto;
using Questionnaire.Domain.ValueObjects;

namespace Questionnaire.Application.Service.Message;

public class NoGoodPointMessage : BaseMessage<PointDto>, IComplemented
{
    private readonly ILexicalization _lex;

    public NoGoodPointMessage(PointDto data, ILexicalization lex) : base(data)
    {
        _lex = lex;
        Complement.Add("");
    }

    public override string Lexicalization()
    {
        var sentence =
            $"{Complement[0]}{Data.Lecturer} belum mencapai hasil yang diinginkan, dari pertanyaan yang diajukan, {_lex.Search("nilai")} {_lex.Search("tertinggi")} hanya sebesar {Data.Answer.AverageScore} untuk pertanyaan {Data.Answer.Section}.";
        return sentence;
    }

    public IList<string> Complement { get; set; } = new List<string>();

    public void EmbedComplement(Option option)
    {
        Complement[0] = option.Description switch
        {
            "bad" => _lex.Search("serta") + ", ",
            "no bad" => _lex.Search("namun") + ", ",
            _ => Complement[0]
        };
    }
}