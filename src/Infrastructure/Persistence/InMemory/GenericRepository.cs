using Questionnaire.Application.Common.Interfaces;
using Questionnaire.Domain.Entities;

namespace Questionnaire.Infrastructure.Persistence.InMemory;

public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
{
    protected IList<T> Db { get; set; }

    public async Task<IEnumerable<T>> All()
    {
        return Db.ToList();
    }

    public async Task<T> GetById(Guid id)
    {
        return Db.First(d=>d.Id==id);
    }

    public async Task Add(T entity)
    {
        Db.Add(entity);
    }

    public async Task Delete(Guid id)
    {
        var t = await GetById(id);
        Db.Remove(t);
    }

    public async Task Update(T entity)
    {
        var index = Db.IndexOf(Db.First(d => d.Id == entity.Id));
        if (index != -1)
        {
            Db[index] = entity;
        }
    }
}