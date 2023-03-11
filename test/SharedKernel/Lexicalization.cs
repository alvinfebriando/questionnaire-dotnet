using Moq;
using Questionnaire.Application.Common.Interfaces;

namespace SharedKernel;

public static class Lexicalization
{
    private static readonly Dictionary<string, string> Lex =
        new()
        {
            { "mendapat", "mendapat" },
            { "menerima", "mendapat" },
            { "didapatkan", "didapatkan" },
            { "diterima", "didapatkan" },
            { "nilai", "nilai" },
            { "skor", "nilai" },
            { "tertinggi", "tertinggi" },
            { "paling tinggi", "tertinggi" },
            { "terendah", "terendah" },
            { "paling rendah", "terendah" },
            { "meskipun demikian", "meskipun demikian" },
            { "walaupun demikian", "meskipun demikian" },
            { "namun", "namun" },
            { "tetapi", "namun" },
            { "serta", "serta" },
            { "kemudian", "serta" },
            { "lalu", "serta" },
            { "untuk", "untuk" },
            { "pada", "untuk" },
            { "sedangkan", "sedangkan" },
            { "aspek", "aspek" },
            { "bagian", "aspek" }
        };

    public static ILexicalization Create()
    {
        var lex = new Mock<ILexicalization>();
        foreach (var key in Lex.Keys)
        {
            lex.Setup(l => l.Search(key)).Returns(Lex[key]);
        }

        lex.Setup(l => l.GetStatus(It.IsAny<double>())).Returns("status");
        return lex.Object;
    }
}