﻿using MediatR;

namespace Questionnaire.Application.AnswerManagement.Commands;

public record AddAnswerCommand(IEnumerable<AnswerOfSurveyQuestion> Answers, Guid AnsweredByUserId) : IRequest;

public record AnswerOfSurveyQuestion(Guid SurveyId, Guid QuestionId, double Score);