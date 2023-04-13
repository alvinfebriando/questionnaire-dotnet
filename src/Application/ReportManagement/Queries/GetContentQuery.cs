using MediatR;
using Questionnaire.Domain.Entities;

namespace Questionnaire.Application.ReportManagement.Queries;

public record GetContentQuery(Guid SurveyId) : IRequest<Content>;