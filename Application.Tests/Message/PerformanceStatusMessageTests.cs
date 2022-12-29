using Moq;
using Questionnaire.Application;
using Questionnaire.Application.Dto;
using Questionnaire.Application.Message;
using Xunit.Abstractions;

namespace Application.Tests.Message;

public class PerformanceStatusMessageTests
{
    private readonly ITestOutputHelper _output;
    private readonly PerformanceStatusMessage _sut;

    public PerformanceStatusMessageTests(ITestOutputHelper output)
    {
        _output = output;
        var overviewDto = new OverviewDto("pak alvin",4.2);
        var lex = new Mock<ILexicalization>();
        _sut = new PerformanceStatusMessage(overviewDto,lex.Object);
    }

    [Fact]
    public void Lexicalization()
    {
        
    }

    [Fact]
    public void EmbedComplement()
    {
        
    }
}