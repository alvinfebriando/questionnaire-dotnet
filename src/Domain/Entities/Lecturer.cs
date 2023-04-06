using Questionnaire.Domain.ValueObjects;

namespace Questionnaire.Domain.Entities;

public class Lecturer : BaseEntity
{
    public string Name { get; set; }
    public LecturerTitle Title { get; set; }
}