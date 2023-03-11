using Moq;
using Questionnaire.Application.Common.Interfaces;

namespace Questionnaire.Application.Tests;

public static class TemplateProvider
{
    public static ITemplateProvider Create()
    {
        var templateProvider = new Mock<ITemplateProvider>();
        
        return templateProvider.Object;
    }
}