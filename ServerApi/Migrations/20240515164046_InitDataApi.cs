using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServerApi.Migrations
{
    /// <inheritdoc />
    public partial class InitDataApi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categoryDtos",
                columns: table => new
                {
                    MaLoai = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenLoaiAlias = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hinh = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categoryDtos", x => x.MaLoai);
                });

            migrationBuilder.CreateTable(
                name: "factoryDtos",
                columns: table => new
                {
                    MaNCC = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenCongTy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NguoiLienLac = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DienThoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_factoryDtos", x => x.MaNCC);
                });

            migrationBuilder.CreateTable(
                name: "specificationsDtos",
                columns: table => new
                {
                    MaTSKT = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KhoiLuongBanThan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DaiRongCao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KhoangCachTrucXe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoCaoYen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KhoangSangGamXe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DungTichBinhXang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KichThuocLopTruocSau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhuocTruoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhuocSau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoaiDongCo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CongSuatToiDa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DungTichNhotMay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MucTieuThuNhienLieu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoaiTruyenDong = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HeThongKhoiDong = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MomentCucDai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DungTichXYLanh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DuongKinhHanhTrinhPiston = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TySoNen = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_specificationsDtos", x => x.MaTSKT);
                });

            migrationBuilder.CreateTable(
                name: "userDtos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userDtos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "productDtos",
                columns: table => new
                {
                    MaHH = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenHH = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenAlias = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaLoai = table.Column<int>(type: "int", nullable: false),
                    MoTaDonVi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DonGia = table.Column<double>(type: "float", nullable: true),
                    Hinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgaySX = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GiamGia = table.Column<double>(type: "float", nullable: false),
                    SoLanXem = table.Column<int>(type: "int", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThietKe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DongCoCongNghe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TienIchAnToan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaNCC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaTSKT = table.Column<int>(type: "int", nullable: false),
                    MaLoaiNavigationMaLoai = table.Column<int>(type: "int", nullable: false),
                    MaNccNavigationMaNCC = table.Column<int>(type: "int", nullable: false),
                    MaTSKTNavigationMaTSKT = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productDtos", x => x.MaHH);
                    table.ForeignKey(
                        name: "FK_productDtos_categoryDtos_MaLoaiNavigationMaLoai",
                        column: x => x.MaLoaiNavigationMaLoai,
                        principalTable: "categoryDtos",
                        principalColumn: "MaLoai",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_productDtos_factoryDtos_MaNccNavigationMaNCC",
                        column: x => x.MaNccNavigationMaNCC,
                        principalTable: "factoryDtos",
                        principalColumn: "MaNCC",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_productDtos_specificationsDtos_MaTSKTNavigationMaTSKT",
                        column: x => x.MaTSKTNavigationMaTSKT,
                        principalTable: "specificationsDtos",
                        principalColumn: "MaTSKT",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "invoiceDtos",
                columns: table => new
                {
                    MaHD = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NgayDat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayGiao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CachThanhToan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CachVanChuyen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhiVanChuyen = table.Column<double>(type: "float", nullable: false),
                    MaTrangThai = table.Column<int>(type: "int", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_invoiceDtos", x => x.MaHD);
                    table.ForeignKey(
                        name: "FK_invoiceDtos_userDtos_UserId",
                        column: x => x.UserId,
                        principalTable: "userDtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "invoiceDetailDtos",
                columns: table => new
                {
                    MaCT = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaHD = table.Column<int>(type: "int", nullable: false),
                    MaHH = table.Column<int>(type: "int", nullable: false),
                    DonGia = table.Column<double>(type: "float", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    GiamGia = table.Column<double>(type: "float", nullable: false),
                    HangHoaMaHH = table.Column<int>(type: "int", nullable: false),
                    HoaDonMaHD = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_invoiceDetailDtos", x => x.MaCT);
                    table.ForeignKey(
                        name: "FK_invoiceDetailDtos_invoiceDtos_HoaDonMaHD",
                        column: x => x.HoaDonMaHD,
                        principalTable: "invoiceDtos",
                        principalColumn: "MaHD",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_invoiceDetailDtos_productDtos_HangHoaMaHH",
                        column: x => x.HangHoaMaHH,
                        principalTable: "productDtos",
                        principalColumn: "MaHH",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_invoiceDetailDtos_HangHoaMaHH",
                table: "invoiceDetailDtos",
                column: "HangHoaMaHH");

            migrationBuilder.CreateIndex(
                name: "IX_invoiceDetailDtos_HoaDonMaHD",
                table: "invoiceDetailDtos",
                column: "HoaDonMaHD");

            migrationBuilder.CreateIndex(
                name: "IX_invoiceDtos_UserId",
                table: "invoiceDtos",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_productDtos_MaLoaiNavigationMaLoai",
                table: "productDtos",
                column: "MaLoaiNavigationMaLoai");

            migrationBuilder.CreateIndex(
                name: "IX_productDtos_MaNccNavigationMaNCC",
                table: "productDtos",
                column: "MaNccNavigationMaNCC");

            migrationBuilder.CreateIndex(
                name: "IX_productDtos_MaTSKTNavigationMaTSKT",
                table: "productDtos",
                column: "MaTSKTNavigationMaTSKT");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "invoiceDetailDtos");

            migrationBuilder.DropTable(
                name: "invoiceDtos");

            migrationBuilder.DropTable(
                name: "productDtos");

            migrationBuilder.DropTable(
                name: "userDtos");

            migrationBuilder.DropTable(
                name: "categoryDtos");

            migrationBuilder.DropTable(
                name: "factoryDtos");

            migrationBuilder.DropTable(
                name: "specificationsDtos");
        }
    }
}
