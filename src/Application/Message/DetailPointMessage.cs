using Questionnaire.Application.Dto;
using Questionnaire.Application.Lexicalization;
using Questionnaire.Domain.ValueObjects;

namespace Questionnaire.Application.Message;

public class DetailPointMessage : BaseMessage<PointDto>, IComplemented
{
    private readonly ILexicalization _lex;

    public DetailPointMessage(PointDto data, ILexicalization lex) : base(data)
    {
        _lex = lex;
        Complement.Add("");
    }

    public override string Lexicalization()
    {
        var sentence =
            $"berikut adalah rincian nilai yang {Complement[0]} ({Data.Answer.Section}):\n";
        var s = Data.Answer.Answer.Select((a, index) =>
            $"{index}. {a.Question.Title}: {a.Score}").ToList();
        return sentence + string.Join("\n", s) + "\n";
    }

    public IList<string> Complement { get; set; } = new List<string>();

    public void EmbedComplement(Option option)
    {
        Complement[0] = option.Description switch
        {
            "max" => _lex.Search("tertinggi"),
            "min" => _lex.Search("terendah"),
            _ => Complement[0]
        };
    }
}