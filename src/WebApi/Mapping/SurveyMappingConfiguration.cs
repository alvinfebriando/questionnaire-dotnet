using Mapster;
using Questionnaire.Application.SurveyManagement;
using Questionnaire.WebApi.Dto;

namespace Questionnaire.WebApi.Mapping;

public class SurveyMappingConfiguration : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<SurveyResult, SurveyResponse>()
            .Map(
                dest => dest.Questions,
                src => src.SurveyQuestions.Select(
                    sq => new QuestionResponse(sq.QuestionId, sq.Question.Title)));
    }
}