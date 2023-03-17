namespace Questionnaire.Application.Common.Interfaces;

public interface IUnitOfWork
{
    public IQuestionRepository QuestionRepository { get; set; }
    public ISurveyRepository SurveyRepository { get; set; }
    public Task SaveChangesAsync();
}