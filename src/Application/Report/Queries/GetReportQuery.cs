using MediatR;

namespace Questionnaire.Application.Report.Queries;

public record GetReportQuery(Guid SurveyId): IRequest<string>;