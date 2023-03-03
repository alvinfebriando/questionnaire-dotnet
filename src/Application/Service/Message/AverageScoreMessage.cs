using Questionnaire.Application.Common.Interfaces;
using Questionnaire.Application.Service.Dto;
using Questionnaire.Domain.ValueObjects;

namespace Questionnaire.Application.Service.Message;

public class AverageScoreMessage : BaseMessage<OverviewDto>, IComplemented
{
    private readonly ILexicalization _lex;
    private readonly ITemplateProvider _templateProvider;

    public AverageScoreMessage(
        OverviewDto data,
        ILexicalization lex,
        ITemplateProvider templateProvider) :
        base(data)
    {
        _lex = lex;
        _templateProvider = templateProvider;
        Complement.Add("");
        Complement.Add(Data.Lecturer);
    }

    public IList<string> Complement { get; set; } = new List<string>();

    public void EmbedComplement(Option option)
    {
        switch (option.Description)
        {
            case "first":
                Complement[0] = "berdasarkan jawaban kuesioner, ";
                break;
            case "second":
                Complement[1] = "beliau";
                break;
        }
    }

    private Dictionary<string, string> LoadReplacement()
    {
        return new Dictionary<string, string>
        {
            { "{Complement-0}", Complement[0] },
            { "{Complement-1}", Complement[1] },
            { "{Search-mendapat}", _lex.Search("mendapat") },
            { "{Search-nilai}", _lex.Search("nilai") },
            { "{AverageScore}", Data.AverageScore.ToString() },
            { "{QuestionCount}", Data.QuestionCount.ToString() },
            { "{AspectCount}", Data.AspectCount.ToString() }
        };
    }

    public override string EntitySlotting()
    {
        var sentence = Replace(_templateProvider.Template["average"], LoadReplacement());
        return sentence;
    }
}