using Mapster;
using Questionnaire.Application.Survey;
using Questionnaire.Domain.Entities;
using Questionnaire.WebApi.Dto;

namespace Questionnaire.WebApi.Mapping;

public class SurveyMappingConfiguration : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<SurveyResult, SurveyResponse>()
            .Map(
                dest => dest.Questions,
                src => src.SurveyQuestions.Select(sq => sq.Question));
    }
}