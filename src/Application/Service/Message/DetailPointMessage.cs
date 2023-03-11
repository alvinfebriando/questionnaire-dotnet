using Humanizer;
using Questionnaire.Application.Common.Interfaces;
using Questionnaire.Application.Service.Dto;
using Questionnaire.Domain.ValueObjects;

namespace Questionnaire.Application.Service.Message;

public class DetailPointMessage : BaseMessage<PointDto>, IComplemented
{
    private readonly ILexicalization _lex;

    public DetailPointMessage(
        PointDto data,
        ILexicalization lex,
        ITemplateProvider templateProvider) : base(data)
    {
        _lex = lex;
        Template = templateProvider.Get("detail");
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


    public override string EntitySlotting()
    {
        var replacement = LoadReplacement();
        var sentence = Replace(replacement);
        var s = Data.Answer.Answer.Select(
                a => $"- {a.Question.Title}: {a.Score}")
            .ToList();
        return sentence + string.Join("\n", s);
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
            }
        };
    }
}