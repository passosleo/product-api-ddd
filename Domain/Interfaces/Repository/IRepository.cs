using Domain.Entities;

namespace Domain.Interfaces.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<T> InsertAsync(T item);
        Task<T> UpdateAsync(T item);
        Task<bool> DeleteAsync(Guid id);
        Task<T> SelectByIdAsync(Guid id);
        Task<IEnumerable<T>> SelectAllAsync();
        Task<bool> ExistAsync(Guid id);
    }
}
