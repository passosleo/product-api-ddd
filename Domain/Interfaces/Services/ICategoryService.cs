using Domain.Entities;

namespace Domain.Interfaces.Services
{
    public interface ICategoryService
    {
        Task<CategoryEntity> Get(Guid id);
        Task<IEnumerable<CategoryEntity>> GetAll();
        Task<CategoryEntity> Post(CategoryEntity category);
        Task<CategoryEntity> Put(CategoryEntity category);
        Task<bool> Delete(Guid id);
    }
}
