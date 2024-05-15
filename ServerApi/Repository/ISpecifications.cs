using ServerApi.Models;

namespace ServerApi.Repository
{
    public interface ISpecifications
    {
        Task<IEnumerable<specificationsDto>> GetspecificationsAsync();
        Task<specificationsDto> GetSpecificationByIdAsync(int id);
        Task AddSpecificationAsync(specificationsDto specifications);
        Task UpdateSpecificationAsync(specificationsDto specifications);
        Task DeleteSpecificationAsync(int id);
    }
}
