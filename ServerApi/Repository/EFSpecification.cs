using Microsoft.EntityFrameworkCore;
using ServerApi.Models;

namespace ServerApi.Repository
{
    public class EFSpecification : ISpecifications
    {
        private readonly ApplicationDbContext _context;
        public EFSpecification(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task AddSpecificationAsync(specificationsDto specifications)
        {
            _context.specificationsDtos.Add(specifications);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteSpecificationAsync(int id)
        {
            var product = await _context.specificationsDtos.FindAsync(id);
            if (product != null)
            {
                _context.specificationsDtos.Remove(product);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<specificationsDto> GetSpecificationByIdAsync(int id)
        {
            return await _context.specificationsDtos.FindAsync(id);
        }

        public async Task<IEnumerable<specificationsDto>> GetspecificationsAsync()
        {
            return await _context.specificationsDtos.ToListAsync();
        }

        public async Task UpdateSpecificationAsync(specificationsDto specifications)
        {
            _context.Entry(specifications).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
