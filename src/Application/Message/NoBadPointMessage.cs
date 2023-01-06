﻿using Questionnaire.Application.Dto;
using Questionnaire.Application.Lexicalization;
using Questionnaire.Domain.ValueObjects;

namespace Questionnaire.Application.Message;

public class NoBadPointMessage : BaseMessage<PointDto>, IComplemented
{
    private readonly ILexicalization _lex;

    public NoBadPointMessage(PointDto data, ILexicalization lex) : base(data)
    {
        _lex = lex;
        Complement.Add("");
    }

    public override string Lexicalization()
    {
        var sentence =
            $"{Complement[0]}tidak ada bagian yang dinilai di bawah standar, dengan {_lex.Search("nilai")} {_lex.Search("terendah")} yang {_lex.Search("didapatkan")} sebesar {Data.Answer.AverageScore} untuk pertanyaan {Data.Answer.Section}.";
        return sentence;
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
}