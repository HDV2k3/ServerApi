using Microsoft.EntityFrameworkCore;
using ServerApi.Models;
using ServerApi.Repository;

namespace ServerApi.Repository
{
	public class ProductRepository : IProductRepository
	{
		private readonly ApplicationDbContext _context;
		public ProductRepository(ApplicationDbContext context)
		{
			_context = context;
		}
		public async Task<IEnumerable<ProductDto>> GetProductsAsync()
		{
			return await _context.productDtos.ToListAsync();
		}
		public async Task<ProductDto> GetProductByIdAsync(int id)
		{
			return await _context.productDtos.FindAsync(id);
		}
		public async Task AddProductAsync(ProductDto product)
		{
			_context.productDtos.Add(product);
			await _context.SaveChangesAsync();
		}
		public async Task UpdateProductAsync(ProductDto product)
		{
			_context.Entry(product).State = EntityState.Modified;
			await _context.SaveChangesAsync();
		}
		public async Task DeleteProductAsync(int id)
		{
			var product = await _context.productDtos.FindAsync(id);
			if (product != null)
			{
				_context.productDtos.Remove(product);
				await _context.SaveChangesAsync();
			}
		}

	}
	
}
