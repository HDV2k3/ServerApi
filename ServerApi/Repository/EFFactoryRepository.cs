using Microsoft.EntityFrameworkCore;
using ServerApi.Models;

namespace ServerApi.Repository
{
    public class EFFactoryRepository : IFactoryRepository
    {
        private readonly ApplicationDbContext _context;
        public EFFactoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task AddFactoryDtoAsync(FactoryDto factory)
        {
            _context.factoryDtos.Add(factory);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteFactoryDtoAsync(int id)
        {
            var product = await _context.factoryDtos.FindAsync(id);
            if (product != null)
            {
                _context.factoryDtos.Remove(product);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<FactoryDto>> GetFactoryDtoAsync()
        {
            return await _context.factoryDtos.ToListAsync();
        }

        public async Task<FactoryDto> GetFactoryDtoByIdAsync(int id)
        {
            return await _context.factoryDtos.FindAsync(id);
        }

        public async Task UpdateFactoryDtoAsync(FactoryDto category)
        {
            _context.Entry(category).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
