using System.ComponentModel.DataAnnotations;

namespace ServerApi.Models
{
    public class CategoryDto
    {
        [Key]
        public int MaLoai { get; set; }
        public required string TenLoai { get; set; }
        public required string TenLoaiAlias { get; set; }
        public required string MoTa { get; set; }
        public required string Hinh { get; set; }
        public required ICollection<ProductDto> HangHoas { get; set; }
    }
}
