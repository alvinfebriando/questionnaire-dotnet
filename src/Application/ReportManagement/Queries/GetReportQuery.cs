using MediatR;

namespace Questionnaire.Application.ReportManagement.Queries;

public record GetReportQuery(Guid SurveyId): IRequest<ReportResult>;