using Mapster;
using Questionnaire.Application.Survey;
using Questionnaire.WebApi.Dto;

namespace Questionnaire.WebApi.Mapping;

public class SurveyMappingConfiguration : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<SurveyResult, SurveyResponse>()
            .BeforeMapping(Console.WriteLine)
            .Map(
                dest => dest.Questions,
                src => src.SurveyQuestions.Select(sq => sq.Question))
            .AfterMapping(Console.WriteLine);
    }
}