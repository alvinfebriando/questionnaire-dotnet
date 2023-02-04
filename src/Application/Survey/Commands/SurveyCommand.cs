using MediatR;

namespace Questionnaire.Application.Survey.Commands;

public record SurveyCommand(string Place,
    DateOnly Date,
    string Subject,
    string Respondent,
    string Lecturer,
    double Score,
    int QuestionCount,
    int AspectCount,
    IList<double> Answers) : IRequest<IEnumerable<string>>;