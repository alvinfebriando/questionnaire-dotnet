using MediatR;

namespace Questionnaire.Application.SurveyManagement.Queries;

public record GetSurveyQuery() : IRequest<AllSurveyResult>;
