using Moq;
using Questionnaire.Application;
using Questionnaire.Application.Dto;
using Questionnaire.Application.Message;
using Xunit.Abstractions;

namespace Application.Tests.Message;

public class OpeningMessageTests
{
    private readonly ITestOutputHelper _output;
    private readonly OpeningMessage _sut;

    public OpeningMessageTests(ITestOutputHelper output)
    {
        _output = output;
        var dto = new OpeningDto("usu", new DateOnly(2022, 12, 25), "topik",
            "mahasiswa");
        var lex = new Mock<ILexicalization>();
        _sut = new OpeningMessage(dto, lex.Object);
    }

    [Fact]
    public void Lexicalization_NoArgument_ReturnEmbededString()
    {
        // Arrange
        var expected = _sut.Data.Place;
        // Act 
        var s = _sut.Lexicalization();
        // Assert
        Assert.Contains(expected, s);
        _output.WriteLine(s);
    }
}