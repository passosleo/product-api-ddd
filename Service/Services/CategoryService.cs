using Domain.Entities;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Services;

namespace Service.Services
{
    public class CategoryService : ICategoryService
    {
        private IRepository<CategoryEntity> _repository;

        public CategoryService(IRepository<CategoryEntity> repository)
        {
            _repository = repository;
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<CategoryEntity> Get(Guid id)
        {
            return await _repository.SelectAsync(id);
        }

        public async Task<IEnumerable<CategoryEntity>> GetAll()
        {
            return await _repository.SelectAsync();
        }

        public async Task<CategoryEntity> Post(CategoryEntity category)
        {
            category.Title = category.Title.ToUpper();

            return await _repository.InsertAsync(category);
        }

        public async Task<CategoryEntity> Put(CategoryEntity category)
        {
            category.Title = category.Title.ToUpper();

            return await _repository.UpdateAsync(category);
        }
    }
}
