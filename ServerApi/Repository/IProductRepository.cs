using ServerApi.Models;

namespace ServerApi.Repository
{
	public interface IProductRepository
	{
		Task<IEnumerable<ProductDto>> GetProductsAsync();
		Task<ProductDto> GetProductByIdAsync(int id);
		Task AddProductAsync(ProductDto product);
		Task UpdateProductAsync(ProductDto product);
		Task DeleteProductAsync(int id);
    }

}
