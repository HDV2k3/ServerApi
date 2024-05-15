using System.ComponentModel.DataAnnotations;

namespace ServerApi.Models
{
	public class ProductDto
	{
        [Key]
        public Guid MaHH { get; set; }
        [Required]
        [MaxLength(100)]
        public required string TenHH { get; set; }
        public required string TenAlias { get; set; }
        public required string MoTaDonVi { get; set; }

        [Range(0, double.MaxValue)]
        public double? DonGia { get; set; }
        public required string Hinh { get; set; }
        public DateTime NgaySX { get; set; }
        public byte GiamGia { get; set; }
        public int SoLanXem { get; set; }
        public required string MoTa { get; set; }
        public required string ThietKe { get; set; }
        public required string DongCoCongNghe { get; set; }
        public required string TienIchAnToan { get; set; }
        public required int? MaNCC { get; set; }
        public required int? MaTSKT { get; set; }
        public int? MaLoai { get; set; }
        public required ICollection<InvoiceDetailDto> invoiceDetailDtos { get; set; }
        public ProductDto()
        {
            invoiceDetailDtos = new HashSet<InvoiceDetailDto>();
        }
        public required CategoryDto MaLoaiNavigation { get; set; }
        public required FactoryDto MaNccNavigation { get; set; }
        public required specificationsDto MaTSKTNavigation { get; set; }

    }
}
