using Questionnaire.Application.Common.Interfaces;
using Questionnaire.Application.Service.Dto;
using Questionnaire.Domain.ValueObjects;

namespace Questionnaire.Application.Service.Message;

public class PerformanceStatusMessage : BaseMessage<OverviewDto>, IComplemented
{
    private readonly ILexicalization _lex;
    private readonly ITemplateProvider _templateProvider;

    public PerformanceStatusMessage(
        OverviewDto data,
        ILexicalization lex,
        ITemplateProvider templateProvider) :
        base(data)
    {
        _lex = lex;
        _templateProvider = templateProvider;
        Status = _lex.GetStatus(Data.AverageScore);
        Complement.Add(Data.Lecturer);
    }

    private string Status { get; }

    public IList<string> Complement { get; set; } = new List<string>();

    public void EmbedComplement(Option option)
    {
        if (option.Description == "second") Complement[0] = "beliau";
    }

    public override string EntitySlotting()
    {
        var sentence = _templateProvider.Template["performance"]
            .Replace("{Complement[0]}", Complement[0])
            .Replace("{Search(mendapat)}", _lex.Search("mendapat"))
            .Replace("{Status}", Status);
        return sentence;
    }
}