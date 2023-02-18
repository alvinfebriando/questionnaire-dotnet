using Questionnaire.Application.Common.Interfaces;
using Questionnaire.Application.Service.Dto;
using Questionnaire.Domain.ValueObjects;

namespace Questionnaire.Application.Service.Message;

public class DetailPointMessage : BaseMessage<PointDto>, IComplemented
{
    private readonly ILexicalization _lex;

    private readonly string _template =
        "{Complement[0]}berikut adalah rincian nilai yang {Complement[1]} ({Data.Answer.Section}):\n";

    public DetailPointMessage(PointDto data, ILexicalization lex) : base(data)
    {
        _lex = lex;
        Complement.Add("");
        Complement.Add("");
    }

    public IList<string> Complement { get; set; } = new List<string>();

    public void EmbedComplement(Option option)
    {
        if (option.Description == "max")
        {
            Complement[1] = _lex.Search("tertinggi");
        }
        else
        {
            Complement[0] = _lex.Search("sedangkan") + ", ";
            Complement[1] = _lex.Search("terendah");
        }
    }


    public override string Lexicalization()
    {
        var sentence = _template.Replace("{Complement[0]}", Complement[0])
            .Replace("{Complement[1]}", Complement[1])
            .Replace("{Data.Answer.Section}", Data.Answer.Section.ToString());

        var s = Data.Answer.Answer.Select(
                a =>
                    $"- {a.Question.Title}: {a.Score}")
            .ToList();
        return sentence + string.Join("\n", s);
    }
}