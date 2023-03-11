using Humanizer;
using Questionnaire.Application.Common.Interfaces;
using Questionnaire.Application.Service.Dto;
using Questionnaire.Domain.ValueObjects;

namespace Questionnaire.Application.Service.Message;

public class NoGoodPointMessage : BaseMessage<PointDto>, IComplemented
{
    private readonly ILexicalization _lex;

    public NoGoodPointMessage(
        PointDto data,
        ILexicalization lex,
        ITemplateProvider templateProvider) : base(data)
    {
        _lex = lex;
        Template = templateProvider.Get("no good");
        Complement.Add("");
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
        Complement[1] = option.Description switch
        {
            "bad" => "juga ",
            _ => Complement[1]
        };
    }

    private Dictionary<string, string> LoadReplacement()
    {
        return new Dictionary<string, string>
        {
            { "{Complement-0}", Complement[0] },
            { "{Complement-1}", Complement[1] },
            { "{Lecturer}", Data.Lecturer },
            { "{Search-nilai}", _lex.Search("nilai") },
            { "{Search-tertinggi}", _lex.Search("tertinggi") },
            { "{Answer.AverageScore}", Data.Answer.AverageScore.ToString() },
            {
                "{Answer.Section}",
                Data.Answer.Section.ToString().Humanize(LetterCasing.LowerCase)
            }
        };
    }


    public override string EntitySlotting()
    {
        var replacement = LoadReplacement();
        var sentence = Replace(replacement);
        return sentence;
    }
}