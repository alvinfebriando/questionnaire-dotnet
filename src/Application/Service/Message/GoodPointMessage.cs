using Humanizer;
using Questionnaire.Application.Common.Interfaces;
using Questionnaire.Application.Service.Dto;
using Questionnaire.Domain.ValueObjects;

namespace Questionnaire.Application.Service.Message;

public class GoodPointMessage : BaseMessage<PointDto>, IMultiEntitySlottingMessage, IComplemented
{
    private readonly ILexicalization _lex;
    private readonly ITemplateProvider _templateProvider;

    public GoodPointMessage(
        PointDto data,
        ILexicalization lex,
        ITemplateProvider templateProvider) : base(data)
    {
        _lex = lex;
        _templateProvider = templateProvider;
        Complement.Add("");
        Complement.Add("");
    }

    public IList<string> Complement { get; set; } = new List<string>();

    public void EmbedComplement(Option option)
    {
        Complement[0] = option.Description switch
        {
            "bad" => _lex.Search("meskipun demikian") + ", ",
            "no bad" => _lex.Search("serta") + ", ",
            _ => Complement[0]
        };
        Complement[1] = option.Description switch
        {
            "no bad" => "juga ",
            _ => Complement[0]
        };
    }

    public string EntitySlotting(IList<AveragedAnswer> messages)
    {
        var sentence = "";
        var second = messages[1];
        var replacement = LoadReplacement();
        replacement.Add(
            "{second.Section}",
            second.Section.ToString().Humanize(LetterCasing.LowerCase));
        replacement.Add("{second.AverageScore}", second.AverageScore.ToString());
        switch (messages.Count)
        {
            case 2:
                sentence = Replace(_templateProvider.Template["good2"], replacement);
                break;
            case >= 3:
                var third = messages[2];
                replacement.Add(
                    "{third.Section}",
                    third.Section.ToString().Humanize(LetterCasing.LowerCase));
                replacement.Add("{third.AverageScore}", third.AverageScore.ToString());
                sentence = Replace(_templateProvider.Template["good3"], replacement);
                break;
        }

        return sentence;
    }

    private Dictionary<string, string> LoadReplacement()
    {
        return new Dictionary<string, string>
        {
            { "{Complement-0}", Complement[0] },
            { "{Complement-1}", Complement[1] },
            { "{Search-aspek}", _lex.Search("aspek") },
            {
                "{Answer.Section}",
                Data.Answer.Section.ToString().Humanize(LetterCasing.LowerCase)
            },
            { "{Lecturer}", Data.Lecturer },
            { "{Search-nilai}", _lex.Search("nilai") },
            { "{Search-didapatkan}", _lex.Search("didapatkan") },
            { "{Answer.AverageScore}", Data.Answer.AverageScore.ToString() }
        };
    }

    public override string EntitySlotting()
    {
        var replacement = LoadReplacement();
        var sentence = Replace(_templateProvider.Template["good1"], replacement);
        return sentence;
    }
}