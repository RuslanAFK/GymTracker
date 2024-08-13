using GymTracker.Backend.Data.Repositories.Abstract;

namespace GymTracker.Backend.Data.Repositories.Concrete;

public abstract class BaseRepository<T>(TrackerDbContext context) : IBaseRepository<T> where T : class
{
    public IQueryable<T> GetAll()
    {
        return context.Set<T>();
    }

    public async Task<T?> GetByIdAsync(Guid id)
    {
        return await context.Set<T>().FindAsync(id);
    }

    public void Add(T entity)
    {
        context.Set<T>().Add(entity);
    }

    public void Remove(T entity)
    {
        context.Set<T>().Remove(entity);
    }

    public void Update(T entity)
    {
        context.Set<T>().Update(entity);
    }

    public Task SaveChangesAsync()
    {
        return context.SaveChangesAsync();
    }
}