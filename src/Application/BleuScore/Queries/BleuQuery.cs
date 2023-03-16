using MediatR;
using Questionnaire.Domain.ValueObjects;

namespace Questionnaire.Application.BleuScore.Queries;

public record BleuQuery(
    string Place,
    DateOnly Date,
    string Subject,
    string Respondent,
    string Lecturer,
    int QuestionCount,
    int AspectCount,
    IList<AnswerScore> Answers) : IRequest<BleuScoreResult>;