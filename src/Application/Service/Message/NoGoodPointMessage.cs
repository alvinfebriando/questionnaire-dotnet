using Questionnaire.Application.Common.Interfaces;
using Questionnaire.Application.Service.Dto;
using Questionnaire.Domain.ValueObjects;

namespace Questionnaire.Application.Service.Message;

public class NoGoodPointMessage : BaseMessage<PointDto>, IComplemented
{
    private readonly ILexicalization _lex;
    private readonly ITemplateProvider _templateProvider;

    public NoGoodPointMessage(PointDto data, ILexicalization lex, ITemplateProvider templateProvider) : base(data)
    {
        _lex = lex;
        _templateProvider = templateProvider;
        Complement.Add("");
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
    

    public override string Lexicalization()
    {
        var sentence = _templateProvider.Template["no good"].Replace("{Complement[0]}", Complement[0])
            .Replace("{Lecturer}", Data.Lecturer)
            .Replace("{Search(nilai)}", _lex.Search("nilai"))
            .Replace("{Search(tertinggi)}", _lex.Search("tertinggi"))
            .Replace("{Answer.AverageScore}", Data.Answer.AverageScore.ToString())
            .Replace("{Answer.Section}", Data.Answer.Section.ToString());
        return sentence;
    }
}