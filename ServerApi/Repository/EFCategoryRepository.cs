using Microsoft.EntityFrameworkCore;
using ServerApi.Models;
using ServerApi.Repository;

namespace ServerApi.Repository
{
    public class EFCategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _context;
        public EFCategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task AddCategoryAsync(CategoryDto category)
        {
            _context.categoryDtos.Add(category);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCategoryAsync(int id)
        {
            var product = await _context.categoryDtos.FindAsync(id);
            if (product != null)
            {
                _context.categoryDtos.Remove(product);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<CategoryDto>> GetCategoriesAsync()
        {
            return await _context.categoryDtos.ToListAsync();
        }

        public async Task<CategoryDto> GetCategoryByIdAsync(int id)
        {
            return await _context.categoryDtos.FindAsync(id);
        }

        public async Task UpdateCategoryAsync(CategoryDto category)
        {
            _context.Entry(category).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
