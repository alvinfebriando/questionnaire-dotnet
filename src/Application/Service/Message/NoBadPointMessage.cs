using Humanizer;
using Questionnaire.Application.Common.Interfaces;
using Questionnaire.Application.Service.Dto;
using Questionnaire.Domain.ValueObjects;

namespace Questionnaire.Application.Service.Message;

public class NoBadPointMessage : BaseMessage<PointDto>, IComplemented
{
    private readonly ILexicalization _lex;

    public NoBadPointMessage(
        PointDto data,
        ILexicalization lex,
        ITemplateProvider templateProvider) : base(data)
    {
        _lex = lex;
        Template = templateProvider.Template["no bad"];
        Complement.Add("");
        Complement.Add("");
    }

    public IList<string> Complement { get; set; } = new List<string>();

    public void EmbedComplement(Option option)
    {
        Complement[0] = option.Description switch
        {
            "good" => _lex.Search("serta") + ", ",
            "no good" => _lex.Search("meskipun demikian") + ", ",
            _ => Complement[0]
        };
        Complement[1] = option.Description switch
        {
            "no bad" => "juga ",
            _ => Complement[0]
        };
    }

    private Dictionary<string, string> LoadReplacement()
    {
        return new Dictionary<string, string>
        {
            { "{Complement-0}", Complement[0] },
            { "{Complement-1}", Complement[1] },
            { "{Search-aspek}", _lex.Search("aspek") },
            { "{Search-nilai}", _lex.Search("nilai") },
            { "{Search-terendah}", _lex.Search("terendah") },
            { "{Search-didapatkan}", _lex.Search("didapatkan") },
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