using MediatR;
using Questionnaire.Domain.ValueObjects;

namespace Questionnaire.Application.Report.Commands;

public record ReportCommand(
    string Place,
    DateOnly Date,
    string Subject,
    string Respondent,
    string Lecturer,
    int QuestionCount,
    int AspectCount,
    IList<AnswerScore> Answers) : IRequest<string>;