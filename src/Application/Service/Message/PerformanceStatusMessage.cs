using Questionnaire.Application.Common.Interfaces;
using Questionnaire.Application.Service.Dto;
using Questionnaire.Domain.ValueObjects;

namespace Questionnaire.Application.Service.Message;

public class PerformanceStatusMessage : BaseMessage<OverviewDto>, IComplemented
{
    private readonly ILexicalization _lex;

    public PerformanceStatusMessage(OverviewDto data, ILexicalization lex) :
        base(data)
    {
        _lex = lex;
        Status = _lex.GetStatus(Data.AverageScore);
        Complement.Add(Data.Lecturer);
    }

    private string Status { get; }

    public IList<string> Complement { get; set; } = new List<string>();

    public void EmbedComplement(Option option)
    {
        if (option.Description == "second") Complement[0] = "beliau";
    }

    private string _template =
        "dalam penilaian ini, {Complement[0]} {Search(mendapat)} hasil yang {Status}.";

    public override string Lexicalization()
    {
        var sentence = _template.Replace("{Complement[0]}", Complement[0])
            .Replace("{Search(mendapat)}", _lex.Search("mendapat"))
            .Replace("{Status}", Status);
        return sentence;
    }
}