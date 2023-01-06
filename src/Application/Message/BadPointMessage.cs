using Questionnaire.Application.Dto;
using Questionnaire.Application.Lexicalization;
using Questionnaire.Domain.ValueObjects;

namespace Questionnaire.Application.Message;

public class BadPointMessage : BaseMessage<PointDto>, IMultiLexicalizationMessage, IComplemented
{
    private readonly ILexicalization _lex;

    public BadPointMessage(PointDto data, ILexicalization lex) : base(data)
    {
        _lex = lex;
        Complement.Add("");
    }

    public override string Lexicalization()
    {
        var sentence =
            $"{Complement[0]}{Data.Lecturer} kurang sukses dalam bagian {Data.Answer.Section}, dengan {_lex.Search("nilai")} {_lex.Search("didapatkan")} sebesar {Data.Answer.AverageScore}";
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
                    $"{Complement[0]}{Data.Lecturer} kurang sukses dalam bagian {Data.Answer.Section} dan {second.Section}, dengan {_lex.Search("nilai")} yang {_lex.Search("didapatkan")} masing-masingnya adalah {Data.Answer.AverageScore} dan {second.AverageScore}";
                break;
            case >= 3:
                var third = messages[2];
                sentence =
                    $"{Complement[0]}{Data.Lecturer} kurang sukses dalam menjalankan bagian {Data.Answer.Section}, {second.Section}, dan {third.Section}, dengan {_lex.Search("nilai")} yang {_lex.Search("didapatkan")} masing-masingnya adalah {Data.Answer.AverageScore}, {second.AverageScore}, {third.AverageScore}";
                break;
        }

        return sentence;
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
    }
}