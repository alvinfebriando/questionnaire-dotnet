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


    public override string Lexicalization()
    {
        var sentence = _templateProvider.Template["average"]
            .Replace("{Complement[0]}", Complement[0])
            .Replace("{Complement[1]}", Complement[1])
            .Replace("{Search(mendapat)}", _lex.Search("mendapat"))
            .Replace("{Search(nilai)}", _lex.Search("nilai"))
            .Replace("{AverageScore}", Data.AverageScore.ToString())
            .Replace("{QuestionCount}", Data.QuestionCount.ToString())
            .Replace("{AspectCount}", Data.AspectCount.ToString());
        return sentence;
    }
}