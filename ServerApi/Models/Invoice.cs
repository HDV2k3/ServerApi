using System.ComponentModel.DataAnnotations;

namespace ServerApi.Models
{
    public enum TinhTrangDonDatHang
    {
        New = 0, Payment = 1, Complete = 2, Cancel = -1
    }
    public class InvoiceDto
    {
        [Key]
        public Guid MaHD { get; set; }
        public DateTime NgayDat { get; set; }
        public DateTime? NgayGiao { get; set; }
        public TinhTrangDonDatHang TinhTrangDonHang { get; set; }
        public required string DiaChi { get; set; }
        public required string CachThanhToan { get; set; }
        public required string CachVanChuyen { get; set; }
        public double PhiVanChuyen { get; set; }
        public int MaTrangThai { get; set; }
        public required string GhiChu { get; set; }
        public required UserDto User { get; set; }
        //public ICollection<InvoiceDetailDto> InvoiceDetailDto { get; set; } = new List<InvoiceDetailDto>();
        public ICollection<InvoiceDetailDto> InvoiceDetailDtos { get; set; } 

        public InvoiceDto()
        {
            InvoiceDetailDtos = new List<InvoiceDetailDto>();
        }
    }
}
