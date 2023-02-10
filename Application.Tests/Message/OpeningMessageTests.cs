using Questionnaire.Application.Service.Dto;
using Questionnaire.Application.Service.Message;
using Xunit.Abstractions;

namespace Questionnaire.Application.Tests.Message;

public class OpeningMessageTests
{
    private readonly ITestOutputHelper _output;
    private readonly OpeningMessage _sut;

    public OpeningMessageTests(ITestOutputHelper output)
    {
        _output = output;
        var dto = new OpeningDto("usu", new DateOnly(2022, 12, 25), "topik",
            "mahasiswa");
        var lex = Lexicalization.Create();
        _sut = new OpeningMessage(dto, lex);
    }

    [Fact]
    public void Lexicalization_NoArgument_ReturnEmbeddedString()
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