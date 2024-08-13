namespace GymTracker.Backend.Data.Repositories.Abstract;

public interface IBaseRepository<T>
{
    public IQueryable<T> GetAll();
    public Task<T?> GetByIdAsync(Guid id);
    public void Add(T entity);
    public void Remove(T entity);
    public void Update(T entity);
    public Task SaveChangesAsync();
}