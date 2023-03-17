using Microsoft.EntityFrameworkCore;
using Questionnaire.Application.Common.Interfaces;

namespace Questionnaire.Infrastructure.Persistence.Postgres;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    protected readonly ApplicationDbContext DbContext;
    protected readonly DbSet<T> DbSet;

    public GenericRepository(ApplicationDbContext dbContext)
    {
        DbContext = dbContext;
        DbSet = DbContext.Set<T>();
    }

    public virtual async Task<IEnumerable<T>> All()
    {
        return await DbSet.ToListAsync();
    }

    public virtual async Task<T> GetById(Guid id)
    {
        return await DbSet.FindAsync(id);
    }

    public virtual async Task Add(T entity)
    {
        DbSet.Add(entity);
        await DbContext.SaveChangesAsync();
    }

    public virtual async Task Delete(Guid id)
    {
        var e = await GetById(id);
        DbSet.Remove(e);
        await DbContext.SaveChangesAsync();
    }

    public virtual async Task Update(T entity)
    {
        DbSet.Update(entity);
        await DbContext.SaveChangesAsync();
    }
}