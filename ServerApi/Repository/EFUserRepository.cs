using Microsoft.EntityFrameworkCore;
using ServerApi.Models;

namespace ServerApi.Repository
{
    public class EFUserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;
        public EFUserRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task AddUserAsync(UserDto user)
        {
            _context.userDtos.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteUserAsync(int id)
        {
            var product = await _context.userDtos.FindAsync(id);
            if (product != null)
            {
                _context.userDtos.Remove(product);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<UserDto> GetUserByIdAsync(int id)
        {
            return await _context.userDtos.FindAsync(id);
        }

        public async Task<IEnumerable<UserDto>> GetUsersAsync()
        {
            return await _context.userDtos.ToListAsync();
        }

        public async Task UpdateUserAsync(UserDto user)
        {
            _context.Entry(user).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
     
      
      
       
      
    }
}
