using ServerApi.Models;

namespace ServerApi.Repository
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<CategoryDto>> GetCategoriesAsync();
        Task<CategoryDto> GetCategoryByIdAsync(int id);
        Task AddCategoryAsync(CategoryDto category);
        Task UpdateCategoryAsync(CategoryDto category);
        Task DeleteCategoryAsync(int id);
    }
}
