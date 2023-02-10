using Questionnaire.Application.Common.Interfaces;
using Questionnaire.Application.Service.Dto;
using Questionnaire.Domain.ValueObjects;

namespace Questionnaire.Application.Service.Message;

public class DetailPointMessage : BaseMessage<PointDto>, IComplemented
{
    private readonly ILexicalization _lex;

    public DetailPointMessage(PointDto data, ILexicalization lex) : base(data)
    {
        _lex = lex;
        Complement.Add("");
        Complement.Add("");
    }

    public override string Lexicalization()
    {
        var sentence =
            $"{Complement[0]}berikut adalah rincian nilai yang {Complement[1]} ({Data.Answer.Section}):\n";
        var s = Data.Answer.Answer.Select(a =>
            $"- {a.Question.Title}: {a.Score}").ToList();
        return sentence + string.Join("\n", s);
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
}