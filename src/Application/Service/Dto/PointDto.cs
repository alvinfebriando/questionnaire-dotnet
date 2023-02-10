using Questionnaire.Domain.ValueObjects;

namespace Questionnaire.Application.Service.Dto;

public record PointDto(string Lecturer, AveragedAnswer Answer);