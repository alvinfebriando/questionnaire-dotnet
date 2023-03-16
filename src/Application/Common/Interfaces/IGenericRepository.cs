namespace Questionnaire.Application.Common.Interfaces;

public interface IGenericRepository<T> where T : class
{
    public Task<IEnumerable<T>> All();
    public Task<T> GetById(Guid id);
    public Task Add(T entity);
    public Task Delete(Guid id);
    public Task Update(T entity);
}