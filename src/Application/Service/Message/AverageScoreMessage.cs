using Questionnaire.Application.Common.Interfaces;
using Questionnaire.Application.Service.Dto;
using Questionnaire.Domain.ValueObjects;

namespace Questionnaire.Application.Service.Message;

public class AverageScoreMessage : BaseMessage<OverviewDto>, IComplemented
{
    private readonly ILexicalization _lex;

    public AverageScoreMessage(OverviewDto data, ILexicalization lex) :
        base(data)
    {
        _lex = lex;
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
    
    private string _template = "{Complement[0]}{Complement[1]} {_lex.Search(mendapat)} {_lex.Search(nilai)} total sebesar {Data.AverageScore} dari {Data.QuestionCount} pertanyaan yang dikelompokkan menjadi {Data.AspectCount} aspek.";

    public override string Lexicalization()
    {
        var sentence = _template.Replace("{Complement[0]}", Complement[0])
            .Replace("{Complement[1]}", Complement[1])
            .Replace("{_lex.Search(mendapat)}", _lex.Search("mendapat"))
            .Replace("{_lex.Search(nilai)}", _lex.Search("nilai"))
            .Replace("{Data.AverageScore}", Data.AverageScore.ToString())
            .Replace("{Data.QuestionCount}", Data.QuestionCount.ToString())
            .Replace("{Data.AspectCount}", Data.AspectCount.ToString());
        return sentence;
    }
}