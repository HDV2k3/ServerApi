using System.ComponentModel.DataAnnotations;

namespace ServerApi.Models
{
    public class InvoiceDetailDto
    {
        [Key]
        public Guid MaCT { get; set; }
        public Guid MaHD { get; set; }
        public Guid MaHH { get; set; }
        public double DonGia { get; set; }
        public int SoLuong { get; set; }
        public byte GiamGia { get; set; }
        public required ProductDto HangHoa { get; set; }
        public required InvoiceDto HoaDon { get; set; }
    }
}
