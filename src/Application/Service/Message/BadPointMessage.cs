using Humanizer;
using Questionnaire.Application.Common.Interfaces;
using Questionnaire.Application.Service.Dto;
using Questionnaire.Domain.ValueObjects;

namespace Questionnaire.Application.Service.Message;

public class BadPointMessage : BaseMessage<PointDto>, IMultiEntitySlottingMessage, IComplemented
{
    private readonly ILexicalization _lex;
    private readonly ITemplateProvider _templateProvider;

    public BadPointMessage(
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
            "good" => _lex.Search("namun") + ", ",
            "no good" => _lex.Search("serta") + ", ",
            _ => Complement[0]
        };
        Complement[1] = option.Description switch
        {
            "no good" => "juga ",
            _ => Complement[1]
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
                Template = _templateProvider.Get("bad2");
                sentence = Replace(replacement);
                break;
            case >= 3:
                var third = messages[2];
                replacement.Add(
                    "{third.Section}",
                    third.Section.ToString().Humanize(LetterCasing.LowerCase));
                replacement.Add("{third.AverageScore}", third.AverageScore.ToString());
                Template = _templateProvider.Get("bad3");
                sentence = Replace(replacement);
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
            { "{Lecturer}", Data.Lecturer },
            { "{Search-aspek}", _lex.Search("aspek") },
            {
                "{Answer.Section}",
                Data.Answer.Section.ToString().Humanize(LetterCasing.LowerCase)
            },
            { "{Search-nilai}", _lex.Search("nilai") },
            { "{Search-didapatkan}", _lex.Search("didapatkan") },
            { "{Answer.AverageScore}", Data.Answer.AverageScore.ToString() }
        };
    }

    public override string EntitySlotting()
    {
        var replacement = LoadReplacement();
        Template = _templateProvider.Get("bad1");
        var sentence = Replace(replacement);
        return sentence;
    }
}