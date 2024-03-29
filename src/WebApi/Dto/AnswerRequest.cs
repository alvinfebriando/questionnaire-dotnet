﻿namespace Questionnaire.WebApi.Dto;

public record AddAnswerRequest(IList<AnswerOfSurveyQuestion> Answers, Guid AnsweredByUserId);

public record AnswerOfSurveyQuestion(Guid SurveyId, Guid QuestionId, double Score);

public record SimulateAnswerRequest(int N, IList<AnswerOfSurveyQuestion> Answers);