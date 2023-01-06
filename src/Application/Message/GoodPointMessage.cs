using Questionnaire.Application.Dto;
using Questionnaire.Application.Lexicalization;
using Questionnaire.Domain.Entities;
using Questionnaire.Domain.ValueObjects;

namespace Questionnaire.Application.Message;

public class GoodPointMessage : BaseMessage<PointDto>, IMultiLexicalizationMessage, IComplemented
{
    private readonly ILexicalization _lex;

    public GoodPointMessage(PointDto data, ILexicalization lex) : base(data)
    {
        _lex = lex;
        Complement.Add("");
    }

    public override string Lexicalization()
    {
        var sentence =
            $"{Complement[0]}untuk bagian {Data.Answer.Section}, {Data.Lecturer} sudah menjalankannya dengan baik, dengan {_lex.Search("nilai")} yang {_lex.Search("didapatkan")} adalah {Data.Answer.AverageScore}.";
        return sentence;
    }

    public string Lexicalization(IList<AveragedAnswer> messages)
    {
        var sentence = "";
        var second = messages[1];
        switch (messages.Count)
        {
            case 2:
                sentence =
                    $"{Complement[0]}untuk bagian {Data.Answer.Section} dan {second.Section}, {Data.Lecturer} sudah menjalankannya dengan baik, dengan {_lex.Search("nilai")} yang {_lex.Search("didapatkan")} masing-masing adalah {Data.Answer.AverageScore} dan {second.AverageScore}";
                break;
            case >= 3:
                var third = messages[2];
                sentence =
                    $"{Complement[0]}untuk bagian {Data.Answer.Section}, {second.Section}, dan {third.Section}, {Data.Lecturer} sudah menjalankannya dengan baik, dengan {_lex.Search("nilai")} yang {_lex.Search("didapatkan")} masing-masing adalah {Data.Answer.AverageScore}, {second.AverageScore}, {third.AverageScore}";
                break;
        }

        return sentence;
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
}