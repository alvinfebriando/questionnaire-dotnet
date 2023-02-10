using Questionnaire.Application.Common.Interfaces;
using Questionnaire.Application.Dto;
using Questionnaire.Domain.ValueObjects;

namespace Questionnaire.Application.Message;

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

    public override string Lexicalization()
    {
        var sentence =
            $"dalam penilaian ini, {Complement[0]} {_lex.Search("mendapat")} hasil yang {Status}.";
        return sentence;
    }
}