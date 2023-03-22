﻿namespace Questionnaire.WebApi.Dto;

public record AddAnswerRequest(IList<AnswerOfSurveyQuestion> Answers);

public record AnswerOfSurveyQuestion(Guid SurveyId, Guid QuestionId, double Score);