using Questionnaire.Application.Common.Interfaces;
using Questionnaire.Application.Service.Dto;
using Questionnaire.Domain.ValueObjects;

namespace Questionnaire.Application.Service.Message;

public class NoBadPointMessage : BaseMessage<PointDto>, IComplemented
{
    private readonly ILexicalization _lex;
    private readonly ITemplateProvider _templateProvider;

    public NoBadPointMessage(
        PointDto data,
        ILexicalization lex,
        ITemplateProvider templateProvider) : base(data)
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
            "good" => _lex.Search("serta") + ", ",
            "no good" => _lex.Search("meskipun demikian") + ", ",
            _ => Complement[0]
        };
    }


    public override string EntitySlotting()
    {
        var sentence = _templateProvider.Template["no bad"]
            .Replace("{Complement[0]}", Complement[0])
            .Replace("{Search(aspek)}", _lex.Search("aspek"))
            .Replace("{Search(nilai)}", _lex.Search("nilai"))
            .Replace("{Search(terendah)}", _lex.Search("terendah"))
            .Replace("{Search(didapatkan)}", _lex.Search("didapatkan"))
            .Replace("{Answer.AverageScore}", Data.Answer.AverageScore.ToString())
            .Replace("{Answer.Section}", Data.Answer.Section.ToString());
        return sentence;
    }
}