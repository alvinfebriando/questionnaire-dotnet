using Microsoft.EntityFrameworkCore;
using Questionnaire.Application.Common.Interfaces;

namespace Questionnaire.Infrastructure.Persistence.Postgres;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly ApplicationDbContext _dbContext;
    private readonly DbSet<T> _dbSet;

    public GenericRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
        _dbSet = _dbContext.Set<T>();
    }

    public async Task<IEnumerable<T>> All()
    {
        return await _dbSet.ToListAsync();
    }

    public async Task<T> GetById(Guid id)
    {
        return await _dbSet.FindAsync(id);
    }

    public async Task Add(T entity)
    {
        _dbSet.Add(entity);
        await _dbContext.SaveChangesAsync();
    }

    public async Task Delete(Guid id)
    {
        var e = await GetById(id);
        _dbSet.Remove(e);
        await _dbContext.SaveChangesAsync();
    }

    public async Task Update(T entity)
    {
        _dbSet.Update(entity);
        await _dbContext.SaveChangesAsync();
    }
}