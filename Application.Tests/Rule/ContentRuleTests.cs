using Questionnaire.Application.Rule;
using Questionnaire.Domain.Entities;
using Xunit.Abstractions;

namespace Questionnaire.Application.Tests.Rule
{
    public class ContentRuleTests
    {
        private readonly ITestOutputHelper _output;
        private readonly ContentRule _sut;

        public ContentRuleTests(ITestOutputHelper output)
        {
            _output = output;
            _sut = new ContentRule();
        }

        [Fact]
        public void Rule()
        {
            // Arrange
            var answer1 = new Answer(2.1,
                new Question("title1", QuestionSection.KedisiplinanWaktu, "advice1"));
            var answer2 = new Answer(1.3,
                new Question("title2", QuestionSection.KedisiplinanWaktu, "advice2"));
            var answer3 = new Answer(3.5,
                new Question("title3", QuestionSection.TransparansiNilai, "advice3"));
            var answer4 = new Answer(2.0,
                new Question("title4", QuestionSection.TransparansiNilai, "advice1"));
            var answer5 = new Answer(4.1,
                new Question("title5", QuestionSection.PenggunaanElearning, "advice1"));


            var answers = new List<Answer> { answer1, answer2, answer3, answer4, answer5 };
            const double expected = 1.7;
            const double expected2 = 4.1;
            const double expected3 = 1;
            const double expected4 = 1.3;
            // Act
            var p = _sut.Rule(answers);
            // Assert
            Assert.Equal(expected, p.Min.AverageScore);
            Assert.Equal(expected2, p.Max.AverageScore);
            Assert.Equal(expected3, p.Good.Count);
            Assert.Equal(expected3, p.Bad.Count);
            Assert.Equal(expected4,
                p.Min.Answer
                    .OrderBy(a => a.Score)
                    .Select(a => a.Score)
                    .ToList().First());
            _output.WriteLine(p.ToString());
        }
    }
}