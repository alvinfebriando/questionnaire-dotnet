using Mapster;
using Questionnaire.Application.Auth;
using Questionnaire.WebApi.Dto;

namespace Questionnaire.WebApi.Common.Mapping;

public class AuthMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<AuthResult, AuthResponse>()
            .Map(dest => dest, src => src.User);
    }
}