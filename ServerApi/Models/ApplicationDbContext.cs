using Microsoft.EntityFrameworkCore;
using ServerApi.Models;

namespace ServerApi.Models
{
	public class ApplicationDbContext : DbContext

	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext>
options) : base(options)
		{
		}
		public DbSet<Product> Products { get; set; }
	}
}
