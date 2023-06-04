using MediatR;

namespace Questionnaire.Application.SurveyManagement.Queries;

public record GetSurveyAnsweredByUserQuery(Guid UserId) : IRequest<IEnumerable<Guid>>;