using Questionnaire.Domain.Entities;
using Questionnaire.Domain.ValueObjects;

namespace Questionnaire.Application.Dto;

public record PointDto(string Lecturer, AveragedAnswer Answer);