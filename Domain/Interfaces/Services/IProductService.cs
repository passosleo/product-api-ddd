using Domain.Entities;

namespace Domain.Interfaces.Services
{
    public interface IProductService
    {
        Task<ProductEntity> GetById(Guid id);
        Task<IEnumerable<ProductEntity>> GetAll();
        Task<ProductEntity> Post(ProductEntity product);
        Task<ProductEntity> Put(ProductEntity product);
        Task<bool> Delete(Guid id);
    }
}
