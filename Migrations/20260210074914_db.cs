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
                name: "CameraSaus",
                columns: table => new
                {
                    IdCameraSau = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoPhanGiaiCameraSau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoLuongOngKinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuayVideoCameraSau = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MoTaCameraSau = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CameraSaus", x => x.IdCameraSau);
                });

            migrationBuilder.CreateTable(
                name: "CameraTruocs",
                columns: table => new
                {
                    IdCameraTruoc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoPhanGiaiCameraTruoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TinhNangCameraTruoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuayVideoCameraTruoc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CameraTruocs", x => x.IdCameraTruoc);
                });

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
                name: "ManHinhs",
                columns: table => new
                {
                    IdManHinh = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CongNgheManHinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KichThuocManHinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoPhanGiai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TinhNangManHinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MoTaManHinh = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManHinhs", x => x.IdManHinh);
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
                name: "Pins",
                columns: table => new
                {
                    IdPin = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoaiPin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DungLuongPin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CongNgheSac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MoTaPin = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pins", x => x.IdPin);
                });

            migrationBuilder.CreateTable(
                name: "RAMs",
                columns: table => new
                {
                    IdRAM = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DungLuongRAM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoTaRAM = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RAMs", x => x.IdRAM);
                });

            migrationBuilder.CreateTable(
                name: "ROMs",
                columns: table => new
                {
                    IdROM = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DungLuongROM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoTaROM = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ROMs", x => x.IdROM);
                });

            migrationBuilder.CreateTable(
                name: "ThuongHieus",
                columns: table => new
                {
                    IdThuongHieu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenThuongHieu = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThaiThuongHieu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThuongHieus", x => x.IdThuongHieu);
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
                    IdThuongHieu = table.Column<int>(type: "int", nullable: false),
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
                        name: "FK_SanPhams_ThuongHieus_IdThuongHieu",
                        column: x => x.IdThuongHieu,
                        principalTable: "ThuongHieus",
                        principalColumn: "IdThuongHieu",
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
                    IdModelSanPham = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdSanPham = table.Column<int>(type: "int", nullable: false),
                    IdManHinh = table.Column<int>(type: "int", nullable: true),
                    IdCameraTruoc = table.Column<int>(type: "int", nullable: true),
                    IdCameraSau = table.Column<int>(type: "int", nullable: true),
                    IdPin = table.Column<int>(type: "int", nullable: true),
                    IdRAM = table.Column<int>(type: "int", nullable: true),
                    IdROM = table.Column<int>(type: "int", nullable: true),
                    MauSac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GiaModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPhamCTs", x => x.IdModelSanPham);
                    table.ForeignKey(
                        name: "FK_SanPhamCTs_CameraSaus_IdCameraSau",
                        column: x => x.IdCameraSau,
                        principalTable: "CameraSaus",
                        principalColumn: "IdCameraSau",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SanPhamCTs_CameraTruocs_IdCameraTruoc",
                        column: x => x.IdCameraTruoc,
                        principalTable: "CameraTruocs",
                        principalColumn: "IdCameraTruoc",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SanPhamCTs_ManHinhs_IdManHinh",
                        column: x => x.IdManHinh,
                        principalTable: "ManHinhs",
                        principalColumn: "IdManHinh",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SanPhamCTs_Pins_IdPin",
                        column: x => x.IdPin,
                        principalTable: "Pins",
                        principalColumn: "IdPin",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SanPhamCTs_RAMs_IdRAM",
                        column: x => x.IdRAM,
                        principalTable: "RAMs",
                        principalColumn: "IdRAM",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SanPhamCTs_ROMs_IdROM",
                        column: x => x.IdROM,
                        principalTable: "ROMs",
                        principalColumn: "IdROM",
                        onDelete: ReferentialAction.Restrict);
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
                    SanPhamChiTietIdModelSanPham = table.Column<int>(type: "int", nullable: true),
                    SanPhamIdSanPham = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnhSanPhams", x => x.IdAnh);
                    table.ForeignKey(
                        name: "FK_AnhSanPhams_SanPhamCTs_IdModelSanPham",
                        column: x => x.IdModelSanPham,
                        principalTable: "SanPhamCTs",
                        principalColumn: "IdModelSanPham",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnhSanPhams_SanPhamCTs_SanPhamChiTietIdModelSanPham",
                        column: x => x.SanPhamChiTietIdModelSanPham,
                        principalTable: "SanPhamCTs",
                        principalColumn: "IdModelSanPham");
                    table.ForeignKey(
                        name: "FK_AnhSanPhams_SanPhams_SanPhamIdSanPham",
                        column: x => x.SanPhamIdSanPham,
                        principalTable: "SanPhams",
                        principalColumn: "IdSanPham");
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
                    SanPhamChiTietIdModelSanPham = table.Column<int>(type: "int", nullable: true)
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
                        principalColumn: "IdModelSanPham",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DonHangChiTiets_SanPhamCTs_SanPhamChiTietIdModelSanPham",
                        column: x => x.SanPhamChiTietIdModelSanPham,
                        principalTable: "SanPhamCTs",
                        principalColumn: "IdModelSanPham");
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
                        principalColumn: "IdModelSanPham",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TonKhos",
                columns: table => new
                {
                    IdTonKho = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdKho = table.Column<int>(type: "int", nullable: true),
                    IdModelSanPham = table.Column<int>(type: "int", nullable: true),
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
                        name: "FK_TonKhos_SanPhamCTs_IdModelSanPham",
                        column: x => x.IdModelSanPham,
                        principalTable: "SanPhamCTs",
                        principalColumn: "IdModelSanPham",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BaoHanhs",
                columns: table => new
                {
                    IdBaoHanh = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdImei = table.Column<int>(type: "int", nullable: false),
                    IdKhachHang = table.Column<int>(type: "int", nullable: false),
                    NgayNhan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayTra = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MoTaLoi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XuLyPhatSinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChiPhiPhatSinh = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaoHanhs", x => x.IdBaoHanh);
                    table.ForeignKey(
                        name: "FK_BaoHanhs_KhachHangs_IdKhachHang",
                        column: x => x.IdKhachHang,
                        principalTable: "KhachHangs",
                        principalColumn: "IdKhachHang",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Imeis",
                columns: table => new
                {
                    IdImei = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaImei = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    IdModelSanPham = table.Column<int>(type: "int", nullable: false),
                    BaoHanhIdBaoHanh = table.Column<int>(type: "int", nullable: true),
                    SanPhamChiTietIdModelSanPham = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imeis", x => x.IdImei);
                    table.ForeignKey(
                        name: "FK_Imeis_BaoHanhs_BaoHanhIdBaoHanh",
                        column: x => x.BaoHanhIdBaoHanh,
                        principalTable: "BaoHanhs",
                        principalColumn: "IdBaoHanh");
                    table.ForeignKey(
                        name: "FK_Imeis_SanPhamCTs_IdModelSanPham",
                        column: x => x.IdModelSanPham,
                        principalTable: "SanPhamCTs",
                        principalColumn: "IdModelSanPham",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Imeis_SanPhamCTs_SanPhamChiTietIdModelSanPham",
                        column: x => x.SanPhamChiTietIdModelSanPham,
                        principalTable: "SanPhamCTs",
                        principalColumn: "IdModelSanPham");
                });

            migrationBuilder.CreateTable(
                name: "HoaDonChiTiets",
                columns: table => new
                {
                    IdHoaDonChiTiet = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdHoaDon = table.Column<int>(type: "int", nullable: false),
                    IdModelSanPham = table.Column<int>(type: "int", nullable: true),
                    IdImei = table.Column<int>(type: "int", nullable: true),
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
                        name: "FK_HoaDonChiTiets_Imeis_IdImei",
                        column: x => x.IdImei,
                        principalTable: "Imeis",
                        principalColumn: "IdImei",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiets_SanPhamCTs_IdModelSanPham",
                        column: x => x.IdModelSanPham,
                        principalTable: "SanPhamCTs",
                        principalColumn: "IdModelSanPham",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnhSanPhams_IdModelSanPham",
                table: "AnhSanPhams",
                column: "IdModelSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_AnhSanPhams_SanPhamChiTietIdModelSanPham",
                table: "AnhSanPhams",
                column: "SanPhamChiTietIdModelSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_AnhSanPhams_SanPhamIdSanPham",
                table: "AnhSanPhams",
                column: "SanPhamIdSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_BaoHanhs_IdImei",
                table: "BaoHanhs",
                column: "IdImei");

            migrationBuilder.CreateIndex(
                name: "IX_BaoHanhs_IdKhachHang",
                table: "BaoHanhs",
                column: "IdKhachHang");

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
                name: "IX_DonHangChiTiets_SanPhamChiTietIdModelSanPham",
                table: "DonHangChiTiets",
                column: "SanPhamChiTietIdModelSanPham");

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
                name: "IX_HoaDonChiTiets_IdImei",
                table: "HoaDonChiTiets",
                column: "IdImei");

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
                name: "IX_Imeis_BaoHanhIdBaoHanh",
                table: "Imeis",
                column: "BaoHanhIdBaoHanh");

            migrationBuilder.CreateIndex(
                name: "IX_Imeis_IdModelSanPham",
                table: "Imeis",
                column: "IdModelSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_Imeis_MaImei",
                table: "Imeis",
                column: "MaImei",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Imeis_SanPhamChiTietIdModelSanPham",
                table: "Imeis",
                column: "SanPhamChiTietIdModelSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhamCTs_IdCameraSau",
                table: "SanPhamCTs",
                column: "IdCameraSau");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhamCTs_IdCameraTruoc",
                table: "SanPhamCTs",
                column: "IdCameraTruoc");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhamCTs_IdManHinh",
                table: "SanPhamCTs",
                column: "IdManHinh");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhamCTs_IdPin",
                table: "SanPhamCTs",
                column: "IdPin");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhamCTs_IdRAM",
                table: "SanPhamCTs",
                column: "IdRAM");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhamCTs_IdROM",
                table: "SanPhamCTs",
                column: "IdROM");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhamCTs_IdSanPham",
                table: "SanPhamCTs",
                column: "IdSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhams_IdThuongHieu",
                table: "SanPhams",
                column: "IdThuongHieu");

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
                name: "IX_TonKhos_IdModelSanPham",
                table: "TonKhos",
                column: "IdModelSanPham");

            migrationBuilder.AddForeignKey(
                name: "FK_BaoHanhs_Imeis_IdImei",
                table: "BaoHanhs",
                column: "IdImei",
                principalTable: "Imeis",
                principalColumn: "IdImei",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Imeis_SanPhamCTs_IdModelSanPham",
                table: "Imeis");

            migrationBuilder.DropForeignKey(
                name: "FK_Imeis_SanPhamCTs_SanPhamChiTietIdModelSanPham",
                table: "Imeis");

            migrationBuilder.DropForeignKey(
                name: "FK_BaoHanhs_Imeis_IdImei",
                table: "BaoHanhs");

            migrationBuilder.DropTable(
                name: "AnhSanPhams");

            migrationBuilder.DropTable(
                name: "diachis");

            migrationBuilder.DropTable(
                name: "DonHangChiTiets");

            migrationBuilder.DropTable(
                name: "GioHangChiTiets");

            migrationBuilder.DropTable(
                name: "HoaDonChiTiets");

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
                name: "Khos");

            migrationBuilder.DropTable(
                name: "HoaDons");

            migrationBuilder.DropTable(
                name: "KhuyenMais");

            migrationBuilder.DropTable(
                name: "NhanViens");

            migrationBuilder.DropTable(
                name: "SanPhamCTs");

            migrationBuilder.DropTable(
                name: "CameraSaus");

            migrationBuilder.DropTable(
                name: "CameraTruocs");

            migrationBuilder.DropTable(
                name: "ManHinhs");

            migrationBuilder.DropTable(
                name: "Pins");

            migrationBuilder.DropTable(
                name: "RAMs");

            migrationBuilder.DropTable(
                name: "ROMs");

            migrationBuilder.DropTable(
                name: "SanPhams");

            migrationBuilder.DropTable(
                name: "ThuongHieus");

            migrationBuilder.DropTable(
                name: "Imeis");

            migrationBuilder.DropTable(
                name: "BaoHanhs");

            migrationBuilder.DropTable(
                name: "KhachHangs");
        }
    }
}
