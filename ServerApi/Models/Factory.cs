using System.ComponentModel.DataAnnotations;

namespace ServerApi.Models
{
    public class FactoryDto
    {
        [Key]
        public required int MaNCC { get; set; }
        public required string TenCongTy { get; set; }
        public required string Logo { get; set; }
        public required string NguoiLienLac { get; set; }
        public required string Email { get; set; }
        public required string DienThoai { get; set; }
        public required string DiaChi { get; set; }
        public required string MoTa { get; set; }
    }
}
