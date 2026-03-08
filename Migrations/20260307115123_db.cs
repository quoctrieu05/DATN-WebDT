using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DATN_WebDT.Migrations
{
    /// <inheritdoc />
    public partial class db : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KhachHangs",
                columns: table => new
                {
                    IdKhachHang = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTenKhachHang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChiKhachHang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoDienThoaiKhachHang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailKhachHang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DefaultImageKhachHang = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHangs", x => x.IdKhachHang);
                });

            migrationBuilder.CreateTable(
                name: "Khos",
                columns: table => new
                {
                    IdKho = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenKho = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChiKho = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DienThoaiKho = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khos", x => x.IdKho);
                });

            migrationBuilder.CreateTable(
                name: "KhuyenMais",
                columns: table => new
                {
                    IdKhuyenMai = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaKM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoTaKhuyenMai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MucGiamGia = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ApDungVoiDonHang = table.Column<bool>(type: "bit", nullable: true),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuyenMais", x => x.IdKhuyenMai);
                });

            migrationBuilder.CreateTable(
                name: "NguyenLieus",
                columns: table => new
                {
                    IdNguyenLieu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenNguyenLieu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DonVi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GiaNhap = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SoLuongTon = table.Column<int>(type: "int", nullable: true),
                    NgayNhap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayHetHan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NhaCungCap = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguyenLieus", x => x.IdNguyenLieu);
                });

            migrationBuilder.CreateTable(
                name: "NhanViens",
                columns: table => new
                {
                    IdNhanVien = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTenNhanVien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChucVu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanViens", x => x.IdNhanVien);
                });

            migrationBuilder.CreateTable(
                name: "NhomDoUongs",
                columns: table => new
                {
                    IdNhom = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenNhom = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThaiNhom = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhomDoUongs", x => x.IdNhom);
                });

            migrationBuilder.CreateTable(
                name: "Toppings",
                columns: table => new
                {
                    IdTopping = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenTopping = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GiaTopping = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Toppings", x => x.IdTopping);
                });

            migrationBuilder.CreateTable(
                name: "diachis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdKhachHang = table.Column<int>(type: "int", nullable: true),
                    TenNguoiNhan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoDienThoaiNguoiNhan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThanhPho = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuanHuyen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhuongXa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChiChiTiet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_diachis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_diachis_KhachHangs_IdKhachHang",
                        column: x => x.IdKhachHang,
                        principalTable: "KhachHangs",
                        principalColumn: "IdKhachHang",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GioHangs",
                columns: table => new
                {
                    IdGioHang = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdKhachHang = table.Column<int>(type: "int", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GioHangs", x => x.IdGioHang);
                    table.ForeignKey(
                        name: "FK_GioHangs_KhachHangs_IdKhachHang",
                        column: x => x.IdKhachHang,
                        principalTable: "KhachHangs",
                        principalColumn: "IdKhachHang",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TonKhos",
                columns: table => new
                {
                    IdTonKho = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdKho = table.Column<int>(type: "int", nullable: true),
                    IdNguyenLieu = table.Column<int>(type: "int", nullable: true),
                    SoLuong = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TonKhos", x => x.IdTonKho);
                    table.ForeignKey(
                        name: "FK_TonKhos_Khos_IdKho",
                        column: x => x.IdKho,
                        principalTable: "Khos",
                        principalColumn: "IdKho",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TonKhos_NguyenLieus_IdNguyenLieu",
                        column: x => x.IdNguyenLieu,
                        principalTable: "NguyenLieus",
                        principalColumn: "IdNguyenLieu",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDons",
                columns: table => new
                {
                    IdHoaDon = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdKhuyenMai = table.Column<int>(type: "int", nullable: true),
                    IdKhachHang = table.Column<int>(type: "int", nullable: true),
                    IdNhanVien = table.Column<int>(type: "int", nullable: true),
                    TongTien = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NgayLapHoaDon = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThaiHoaDon = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDons", x => x.IdHoaDon);
                    table.ForeignKey(
                        name: "FK_HoaDons_KhachHangs_IdKhachHang",
                        column: x => x.IdKhachHang,
                        principalTable: "KhachHangs",
                        principalColumn: "IdKhachHang",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HoaDons_KhuyenMais_IdKhuyenMai",
                        column: x => x.IdKhuyenMai,
                        principalTable: "KhuyenMais",
                        principalColumn: "IdKhuyenMai",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HoaDons_NhanViens_IdNhanVien",
                        column: x => x.IdNhanVien,
                        principalTable: "NhanViens",
                        principalColumn: "IdNhanVien",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "taiKhoans",
                columns: table => new
                {
                    IdTaiKhoan = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenDangNhap = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MatKhauHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VaiTro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdKhachHang = table.Column<int>(type: "int", nullable: true),
                    IdNhanVien = table.Column<int>(type: "int", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_taiKhoans", x => x.IdTaiKhoan);
                    table.ForeignKey(
                        name: "FK_taiKhoans_KhachHangs_IdKhachHang",
                        column: x => x.IdKhachHang,
                        principalTable: "KhachHangs",
                        principalColumn: "IdKhachHang",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_taiKhoans_NhanViens_IdNhanVien",
                        column: x => x.IdNhanVien,
                        principalTable: "NhanViens",
                        principalColumn: "IdNhanVien",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SanPhams",
                columns: table => new
                {
                    IdSanPham = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenSanPham = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdNhomDoUong = table.Column<int>(type: "int", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GiaGoc = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GiaYeuThich = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    GiaGocVAT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThaiSP = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPhams", x => x.IdSanPham);
                    table.ForeignKey(
                        name: "FK_SanPhams_NhomDoUongs_IdNhomDoUong",
                        column: x => x.IdNhomDoUong,
                        principalTable: "NhomDoUongs",
                        principalColumn: "IdNhom",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DonHangs",
                columns: table => new
                {
                    IdDonHang = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdKhachHang = table.Column<int>(type: "int", nullable: true),
                    IdNhanVien = table.Column<int>(type: "int", nullable: true),
                    NhanVienIdNhanVien = table.Column<int>(type: "int", nullable: true),
                    NgayDat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThaiDonHang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChiGiaoHang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThaiHoaDon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhuongThucThanhToan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HoaDonIdHoaDon = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonHangs", x => x.IdDonHang);
                    table.ForeignKey(
                        name: "FK_DonHangs_HoaDons_HoaDonIdHoaDon",
                        column: x => x.HoaDonIdHoaDon,
                        principalTable: "HoaDons",
                        principalColumn: "IdHoaDon");
                    table.ForeignKey(
                        name: "FK_DonHangs_KhachHangs_IdKhachHang",
                        column: x => x.IdKhachHang,
                        principalTable: "KhachHangs",
                        principalColumn: "IdKhachHang",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DonHangs_NhanViens_NhanVienIdNhanVien",
                        column: x => x.NhanVienIdNhanVien,
                        principalTable: "NhanViens",
                        principalColumn: "IdNhanVien");
                });

            migrationBuilder.CreateTable(
                name: "ThanhToans",
                columns: table => new
                {
                    IdThanhToan = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdHoaDon = table.Column<int>(type: "int", nullable: false),
                    HinhThuc = table.Column<int>(type: "int", nullable: false),
                    SoTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NgayThanhToan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThaiThanhToan = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThanhToans", x => x.IdThanhToan);
                    table.ForeignKey(
                        name: "FK_ThanhToans_HoaDons_IdHoaDon",
                        column: x => x.IdHoaDon,
                        principalTable: "HoaDons",
                        principalColumn: "IdHoaDon",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SanPhamCTs",
                columns: table => new
                {
                    IdSanPhamChiTiet = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdSanPham = table.Column<int>(type: "int", nullable: false),
                    TenBienThe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SizeCoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoNgot = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Doda = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GiaModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPhamCTs", x => x.IdSanPhamChiTiet);
                    table.ForeignKey(
                        name: "FK_SanPhamCTs_SanPhams_IdSanPham",
                        column: x => x.IdSanPham,
                        principalTable: "SanPhams",
                        principalColumn: "IdSanPham",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AnhSanPhams",
                columns: table => new
                {
                    IdAnh = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdModelSanPham = table.Column<int>(type: "int", nullable: false),
                    DuongDan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SanPhamChiTietIdSanPhamChiTiet = table.Column<int>(type: "int", nullable: true),
                    SanPhamIdSanPham = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnhSanPhams", x => x.IdAnh);
                    table.ForeignKey(
                        name: "FK_AnhSanPhams_SanPhamCTs_IdModelSanPham",
                        column: x => x.IdModelSanPham,
                        principalTable: "SanPhamCTs",
                        principalColumn: "IdSanPhamChiTiet",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnhSanPhams_SanPhamCTs_SanPhamChiTietIdSanPhamChiTiet",
                        column: x => x.SanPhamChiTietIdSanPhamChiTiet,
                        principalTable: "SanPhamCTs",
                        principalColumn: "IdSanPhamChiTiet");
                    table.ForeignKey(
                        name: "FK_AnhSanPhams_SanPhams_SanPhamIdSanPham",
                        column: x => x.SanPhamIdSanPham,
                        principalTable: "SanPhams",
                        principalColumn: "IdSanPham");
                });

            migrationBuilder.CreateTable(
                name: "ChiTietCongThucs",
                columns: table => new
                {
                    IdSanPhamChiTiet = table.Column<int>(type: "int", nullable: false),
                    IdNguyenLieu = table.Column<int>(type: "int", nullable: false),
                    SoLuongCanDung = table.Column<decimal>(type: "decimal(18,3)", nullable: false),
                    DonVi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietCongThucs", x => new { x.IdSanPhamChiTiet, x.IdNguyenLieu });
                    table.ForeignKey(
                        name: "FK_ChiTietCongThucs_NguyenLieus_IdNguyenLieu",
                        column: x => x.IdNguyenLieu,
                        principalTable: "NguyenLieus",
                        principalColumn: "IdNguyenLieu",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietCongThucs_SanPhamCTs_IdSanPhamChiTiet",
                        column: x => x.IdSanPhamChiTiet,
                        principalTable: "SanPhamCTs",
                        principalColumn: "IdSanPhamChiTiet",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DonHangChiTiets",
                columns: table => new
                {
                    IdDonHangChiTiet = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdDonHang = table.Column<int>(type: "int", nullable: false),
                    IdModelSanPham = table.Column<int>(type: "int", nullable: false),
                    IdKhuyenMai = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    DonGia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ThanhTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SanPhamChiTietIdSanPhamChiTiet = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonHangChiTiets", x => x.IdDonHangChiTiet);
                    table.ForeignKey(
                        name: "FK_DonHangChiTiets_DonHangs_IdDonHang",
                        column: x => x.IdDonHang,
                        principalTable: "DonHangs",
                        principalColumn: "IdDonHang",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DonHangChiTiets_KhuyenMais_IdKhuyenMai",
                        column: x => x.IdKhuyenMai,
                        principalTable: "KhuyenMais",
                        principalColumn: "IdKhuyenMai",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DonHangChiTiets_SanPhamCTs_IdModelSanPham",
                        column: x => x.IdModelSanPham,
                        principalTable: "SanPhamCTs",
                        principalColumn: "IdSanPhamChiTiet",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DonHangChiTiets_SanPhamCTs_SanPhamChiTietIdSanPhamChiTiet",
                        column: x => x.SanPhamChiTietIdSanPhamChiTiet,
                        principalTable: "SanPhamCTs",
                        principalColumn: "IdSanPhamChiTiet");
                });

            migrationBuilder.CreateTable(
                name: "GioHangChiTiets",
                columns: table => new
                {
                    IdGioHangChiTiet = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdGioHang = table.Column<int>(type: "int", nullable: false),
                    IdModelSanPham = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GioHangChiTiets", x => x.IdGioHangChiTiet);
                    table.ForeignKey(
                        name: "FK_GioHangChiTiets_GioHangs_IdGioHang",
                        column: x => x.IdGioHang,
                        principalTable: "GioHangs",
                        principalColumn: "IdGioHang",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GioHangChiTiets_SanPhamCTs_IdModelSanPham",
                        column: x => x.IdModelSanPham,
                        principalTable: "SanPhamCTs",
                        principalColumn: "IdSanPhamChiTiet",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonChiTiets",
                columns: table => new
                {
                    IdHoaDonChiTiet = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdHoaDon = table.Column<int>(type: "int", nullable: false),
                    IdModelSanPham = table.Column<int>(type: "int", nullable: true),
                    SoLuong = table.Column<int>(type: "int", nullable: true),
                    DonGia = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ThanhTien = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonChiTiets", x => x.IdHoaDonChiTiet);
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiets_HoaDons_IdHoaDon",
                        column: x => x.IdHoaDon,
                        principalTable: "HoaDons",
                        principalColumn: "IdHoaDon",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiets_SanPhamCTs_IdModelSanPham",
                        column: x => x.IdModelSanPham,
                        principalTable: "SanPhamCTs",
                        principalColumn: "IdSanPhamChiTiet",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SanPhamChiTiet_Toppings",
                columns: table => new
                {
                    IdSanPhamChiTiet = table.Column<int>(type: "int", nullable: false),
                    IdTopping = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    GiaThem = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPhamChiTiet_Toppings", x => new { x.IdSanPhamChiTiet, x.IdTopping });
                    table.ForeignKey(
                        name: "FK_SanPhamChiTiet_Toppings_SanPhamCTs_IdSanPhamChiTiet",
                        column: x => x.IdSanPhamChiTiet,
                        principalTable: "SanPhamCTs",
                        principalColumn: "IdSanPhamChiTiet",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SanPhamChiTiet_Toppings_Toppings_IdTopping",
                        column: x => x.IdTopping,
                        principalTable: "Toppings",
                        principalColumn: "IdTopping",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnhSanPhams_IdModelSanPham",
                table: "AnhSanPhams",
                column: "IdModelSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_AnhSanPhams_SanPhamChiTietIdSanPhamChiTiet",
                table: "AnhSanPhams",
                column: "SanPhamChiTietIdSanPhamChiTiet");

            migrationBuilder.CreateIndex(
                name: "IX_AnhSanPhams_SanPhamIdSanPham",
                table: "AnhSanPhams",
                column: "SanPhamIdSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietCongThucs_IdNguyenLieu",
                table: "ChiTietCongThucs",
                column: "IdNguyenLieu");

            migrationBuilder.CreateIndex(
                name: "IX_diachis_IdKhachHang",
                table: "diachis",
                column: "IdKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_DonHangChiTiets_IdDonHang",
                table: "DonHangChiTiets",
                column: "IdDonHang");

            migrationBuilder.CreateIndex(
                name: "IX_DonHangChiTiets_IdKhuyenMai",
                table: "DonHangChiTiets",
                column: "IdKhuyenMai");

            migrationBuilder.CreateIndex(
                name: "IX_DonHangChiTiets_IdModelSanPham",
                table: "DonHangChiTiets",
                column: "IdModelSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_DonHangChiTiets_SanPhamChiTietIdSanPhamChiTiet",
                table: "DonHangChiTiets",
                column: "SanPhamChiTietIdSanPhamChiTiet");

            migrationBuilder.CreateIndex(
                name: "IX_DonHangs_HoaDonIdHoaDon",
                table: "DonHangs",
                column: "HoaDonIdHoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_DonHangs_IdKhachHang",
                table: "DonHangs",
                column: "IdKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_DonHangs_NhanVienIdNhanVien",
                table: "DonHangs",
                column: "NhanVienIdNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_GioHangChiTiets_IdGioHang",
                table: "GioHangChiTiets",
                column: "IdGioHang");

            migrationBuilder.CreateIndex(
                name: "IX_GioHangChiTiets_IdModelSanPham",
                table: "GioHangChiTiets",
                column: "IdModelSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_GioHangs_IdKhachHang",
                table: "GioHangs",
                column: "IdKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiets_IdHoaDon",
                table: "HoaDonChiTiets",
                column: "IdHoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiets_IdModelSanPham",
                table: "HoaDonChiTiets",
                column: "IdModelSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_IdKhachHang",
                table: "HoaDons",
                column: "IdKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_IdKhuyenMai",
                table: "HoaDons",
                column: "IdKhuyenMai");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_IdNhanVien",
                table: "HoaDons",
                column: "IdNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhamChiTiet_Toppings_IdTopping",
                table: "SanPhamChiTiet_Toppings",
                column: "IdTopping");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhamCTs_IdSanPham",
                table: "SanPhamCTs",
                column: "IdSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhams_IdNhomDoUong",
                table: "SanPhams",
                column: "IdNhomDoUong");

            migrationBuilder.CreateIndex(
                name: "IX_taiKhoans_IdKhachHang",
                table: "taiKhoans",
                column: "IdKhachHang",
                unique: true,
                filter: "[IdKhachHang] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_taiKhoans_IdNhanVien",
                table: "taiKhoans",
                column: "IdNhanVien",
                unique: true,
                filter: "[IdNhanVien] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ThanhToans_IdHoaDon",
                table: "ThanhToans",
                column: "IdHoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_TonKhos_IdKho",
                table: "TonKhos",
                column: "IdKho");

            migrationBuilder.CreateIndex(
                name: "IX_TonKhos_IdNguyenLieu",
                table: "TonKhos",
                column: "IdNguyenLieu");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnhSanPhams");

            migrationBuilder.DropTable(
                name: "ChiTietCongThucs");

            migrationBuilder.DropTable(
                name: "diachis");

            migrationBuilder.DropTable(
                name: "DonHangChiTiets");

            migrationBuilder.DropTable(
                name: "GioHangChiTiets");

            migrationBuilder.DropTable(
                name: "HoaDonChiTiets");

            migrationBuilder.DropTable(
                name: "SanPhamChiTiet_Toppings");

            migrationBuilder.DropTable(
                name: "taiKhoans");

            migrationBuilder.DropTable(
                name: "ThanhToans");

            migrationBuilder.DropTable(
                name: "TonKhos");

            migrationBuilder.DropTable(
                name: "DonHangs");

            migrationBuilder.DropTable(
                name: "GioHangs");

            migrationBuilder.DropTable(
                name: "SanPhamCTs");

            migrationBuilder.DropTable(
                name: "Toppings");

            migrationBuilder.DropTable(
                name: "Khos");

            migrationBuilder.DropTable(
                name: "NguyenLieus");

            migrationBuilder.DropTable(
                name: "HoaDons");

            migrationBuilder.DropTable(
                name: "SanPhams");

            migrationBuilder.DropTable(
                name: "KhachHangs");

            migrationBuilder.DropTable(
                name: "KhuyenMais");

            migrationBuilder.DropTable(
                name: "NhanViens");

            migrationBuilder.DropTable(
                name: "NhomDoUongs");
        }
    }
}
