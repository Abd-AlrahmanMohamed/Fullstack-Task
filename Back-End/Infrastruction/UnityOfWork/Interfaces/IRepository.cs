namespace Infrastructure.Interfaces
{
    public interface IRepository<T> where T : class
    {
        ValueTask<T> GetByidAsync(int id);
        ValueTask<IEnumerable<T>> GetAllAsync();
        ValueTask<T> AddAsync(T entity);
        ValueTask<T> UpdateAsync(T entity);
        ValueTask<T> DeleteAsync(int id);
    }
}
