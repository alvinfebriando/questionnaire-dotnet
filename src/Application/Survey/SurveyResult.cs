﻿using Questionnaire.Domain.Entities;

namespace Questionnaire.Application.Survey;

public record SurveyResult(
    string Place,
    DateOnly Date,
    string Subject,
    string Respondent,
    string Lecturer,
    int QuestionCount,
    int AspectCount,
    ICollection<SurveyQuestion> SurveyQuestions);