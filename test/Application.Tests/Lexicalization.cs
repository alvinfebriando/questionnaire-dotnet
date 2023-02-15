using Moq;
using Questionnaire.Application.Common.Interfaces;

namespace Questionnaire.Application.Tests;

public static class Lexicalization
{
    public static ILexicalization Create()
    {
        var lex = new Mock<ILexicalization>();
        lex.Setup(l => l.Search("nilai")).Returns("nilai");
        lex.Setup(l => l.Search("meskipun demikian")).Returns("meskipun demikian");
        lex.Setup(l => l.Search("namun")).Returns("namun");
        lex.Setup(l => l.Search("tertinggi")).Returns("tertinggi");
        lex.Setup(l => l.Search("terendah")).Returns("terendah");
        lex.Setup(l => l.Search("sedangkan")).Returns("sedangkan");
        lex.Setup(l => l.Search("serta")).Returns("serta");
        return lex.Object;
    }
}