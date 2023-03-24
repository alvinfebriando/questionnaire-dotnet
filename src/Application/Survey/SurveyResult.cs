using Questionnaire.Domain.Entities;

namespace Questionnaire.Application.Survey;

public record AllSurveyResult(IEnumerable<SurveyResult> Surveys);
public record SurveyResult(
    Guid Id,
    string Place,
    DateOnly Date,
    string Subject,
    string Respondent,
    string Lecturer,
    int QuestionCount,
    int AspectCount,
    ICollection<SurveyQuestion> SurveyQuestions);