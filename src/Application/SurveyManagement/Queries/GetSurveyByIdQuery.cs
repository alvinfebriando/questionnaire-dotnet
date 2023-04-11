using MediatR;

namespace Questionnaire.Application.SurveyManagement.Queries;

public record GetSurveyByIdQuery(Guid Id) : IRequest<SurveyResult>;