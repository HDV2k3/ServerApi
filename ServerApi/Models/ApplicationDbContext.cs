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
		public DbSet<ProductDto> productDtos { get; set; }
        public DbSet<CategoryDto> categoryDtos { get; set; }
        public DbSet<UserDto> userDtos { get; set; }
        public DbSet<FactoryDto> factoryDtos { get; set; }
        public DbSet<InvoiceDto> invoiceDtos { get; set; }
        public DbSet<InvoiceDetailDto> invoiceDetailDtos{ get; set; }
        public DbSet<specificationsDto> specificationsDtos { get; set; }

    }
}
