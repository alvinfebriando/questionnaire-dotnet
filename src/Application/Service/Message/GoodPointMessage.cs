using Questionnaire.Application.Common.Interfaces;
using Questionnaire.Application.Service.Dto;
using Questionnaire.Domain.ValueObjects;

namespace Questionnaire.Application.Service.Message;

public class GoodPointMessage : BaseMessage<PointDto>, IMultiLexicalizationMessage, IComplemented
{
    private readonly ILexicalization _lex;
    private readonly ITemplateProvider _templateProvider;

    public GoodPointMessage(PointDto data, ILexicalization lex, ITemplateProvider templateProvider) : base(data)
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
            "bad" => _lex.Search("meskipun demikian") + ", ",
            "no bad" => _lex.Search("serta") + ", ",
            _ => Complement[0]
        };
    }

    public string Lexicalization(IList<AveragedAnswer> messages)
    {
        var sentence = "";
        var second = messages[1];
        switch (messages.Count)
        {
            case 2:
                sentence = _templateProvider.Template["good2"].Replace("{Complement[0]}", Complement[0])
                    .Replace("{Search(aspek)}", _lex.Search("aspek"))
                    .Replace("{Answer.Section}", Data.Answer.Section.ToString())
                    .Replace("{second.Section}", second.Section.ToString())
                    .Replace("{Lecturer}", Data.Lecturer)
                    .Replace("{Search(nilai)}", _lex.Search("nilai"))
                    .Replace("{Search(didapatkan)}", _lex.Search("didapatkan"))
                    .Replace("{Answer.AverageScore}", Data.Answer.AverageScore.ToString())
                    .Replace("{second.AverageScore}", second.AverageScore.ToString());
                break;
            case >= 3:
                var third = messages[2];
                sentence = _templateProvider.Template["good3"].Replace("{Complement[0]}", Complement[0])
                    .Replace("{Search(aspek)}", _lex.Search("aspek"))
                    .Replace("{Answer.Section}", Data.Answer.Section.ToString())
                    .Replace("{second.Section}", second.Section.ToString())
                    .Replace("{third.Section}", third.Section.ToString())
                    .Replace("{Lecturer}", Data.Lecturer)
                    .Replace("{Search(nilai)}", _lex.Search("nilai"))
                    .Replace("{Search(didapatkan)}", _lex.Search("didapatkan"))
                    .Replace("{Answer.AverageScore}", Data.Answer.AverageScore.ToString())
                    .Replace("{second.AverageScore}", second.AverageScore.ToString())
                    .Replace("{third.AverageScore}", third.AverageScore.ToString());
                break;
        }

        return sentence;
    }

    public override string Lexicalization()
    {
        var sentence = _templateProvider.Template["good1"].Replace("{Complement[0]}", Complement[0])
            .Replace("{Search(aspek)}", _lex.Search("aspek"))
            .Replace("{Answer.Section}", Data.Answer.Section.ToString())
            .Replace("{Lecturer}", Data.Lecturer)
            .Replace("{Search(nilai)}", _lex.Search("nilai"))
            .Replace("{Search(didapatkan)}", _lex.Search("didapatkan"))
            .Replace("{Answer.AverageScore}", Data.Answer.AverageScore.ToString());
        return sentence;
    }
}