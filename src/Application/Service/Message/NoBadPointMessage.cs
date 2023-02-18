using Questionnaire.Application.Common.Interfaces;
using Questionnaire.Application.Service.Dto;
using Questionnaire.Domain.ValueObjects;

namespace Questionnaire.Application.Service.Message;

public class NoBadPointMessage : BaseMessage<PointDto>, IComplemented
{
    private readonly ILexicalization _lex;

    public NoBadPointMessage(PointDto data, ILexicalization lex) : base(data)
    {
        _lex = lex;
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
    }

    private string _template =
        "{Complement[0]}tidak ada {_lex.Search(aspek)} yang dinilai di bawah standar, dengan {_lex.Search(nilai)} {_lex.Search(terendah)} yang {_lex.Search(didapatkan)} sebesar {Data.Answer.AverageScore} untuk pertanyaan {Data.Answer.Section}.";


    public override string Lexicalization()
    {
        var sentence = _template.Replace("{Complement[0]}", Complement[0])
            .Replace("{_lex.Search(aspek)}", _lex.Search("aspek"))
            .Replace("{_lex.Search(nilai)}", _lex.Search("nilai"))
            .Replace("{_lex.Search(terendah)}", _lex.Search("terendah"))
            .Replace("{_lex.Search(didapatkan)}", _lex.Search("didapatkan"))
            .Replace("{Data.Answer.AverageScore}", Data.Answer.AverageScore.ToString())
            .Replace("{Data.Answer.Section}", Data.Answer.Section.ToString());
        return sentence;
    }
}