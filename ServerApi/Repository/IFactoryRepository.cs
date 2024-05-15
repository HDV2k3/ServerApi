using ServerApi.Models;

namespace ServerApi.Repository
{
    public interface IFactoryRepository
    {
        Task<IEnumerable<FactoryDto>> GetFactoryDtoAsync();
        Task<FactoryDto> GetFactoryDtoByIdAsync(int id);
        Task AddFactoryDtoAsync(FactoryDto category);
        Task UpdateFactoryDtoAsync(FactoryDto category);
        Task DeleteFactoryDtoAsync(int id);
    }
}
