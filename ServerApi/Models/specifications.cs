using System.ComponentModel.DataAnnotations;

namespace ServerApi.Models
{
    public class specificationsDto
    {
        [Key]
        public int MaTSKT { get; set; }
        public required string KhoiLuongBanThan { get; set; }
        public required string DaiRongCao { get; set; }
        public required string KhoangCachTrucXe { get; set; }
        public required string DoCaoYen { get; set; }
        public required string KhoangSangGamXe { get; set; }
        public required string DungTichBinhXang { get; set; }
        public required string KichThuocLopTruocSau { get; set; }
        public required string PhuocTruoc { get; set; }
        public required string PhuocSau { get; set; }
        public required string LoaiDongCo { get; set; }
        public required string CongSuatToiDa { get; set; }
        public required string DungTichNhotMay { get; set; }
        public required string MucTieuThuNhienLieu { get; set; }
        public required string LoaiTruyenDong { get; set; }
        public required string HeThongKhoiDong { get; set; }
        public required string MomentCucDai { get; set; }
        public required string DungTichXYLanh { get; set; }
        public required string DuongKinhHanhTrinhPiston { get; set; }
        public required string TySoNen { get; set; }
    }
}
