using DATN_WebDT.Models;
using Microsoft.EntityFrameworkCore;

namespace DATN_WebDT.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }
        public DbSet<Kho> Khos { get; set; }
        public DbSet<ThuongHieu> ThuongHieus { get; set; }
        public DbSet<RAM> RAMs { get; set; }
        public DbSet<ROM> ROMs { get; set; }
        public DbSet<Pin> Pins { get; set; }
        public DbSet<CameraSau> CameraSaus { get; set; }
        public DbSet<CameraTruoc> CameraTruocs { get; set; }
        public DbSet<ManHinh> ManHinhs { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<KhuyenMai> KhuyenMais { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<SanPhamChiTiet> SanPhamCTs { get; set; }
        public DbSet<AnhSanPham> AnhSanPhams { get; set; }
        public DbSet<TonKho> TonKhos { get; set; }
        public DbSet<Imei> Imeis { get; set; }
        public DbSet<BaoHanh> BaoHanhs { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        public DbSet<GioHang> GioHangs { get; set; }
        public DbSet<GioHangChiTiet> GioHangChiTiets { get; set; }
        public DbSet<DonHang> DonHangs { get; set; }
        public DbSet<DonHangChiTiet> DonHangChiTiets { get; set; }
        public DbSet<ThanhToan> ThanhToans { get; set; }
        public DbSet<DiaChi> diachis { get; set; }
        public DbSet<TaiKhoan> taiKhoans { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // TaiKhoan 1-1 hoặc 1-n với KH/NV
            modelBuilder.Entity<TaiKhoan>()
            .HasOne(t => t.KhachHang)
            .WithOne(k => k.TaiKhoan)
             .HasForeignKey<TaiKhoan>(t => t.IdKhachHang)
              .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TaiKhoan>()
                .HasOne(t => t.NhanVien)
                .WithOne(n => n.TaiKhoan)
                .HasForeignKey<TaiKhoan>(t => t.IdNhanVien)
                .OnDelete(DeleteBehavior.Restrict);
            //ThgHieu->SanPham
            modelBuilder.Entity<SanPham>()
                .HasOne(s => s.ThuongHieu)
                .WithMany()
                .HasForeignKey(s => s.IdThuongHieu)
                .OnDelete(DeleteBehavior.Restrict);

            //SanPham -> SanPhamCT (1-n)
            modelBuilder.Entity<SanPhamChiTiet>()
           .HasOne(m => m.SanPham)
            .WithMany(s => s.ModelSanPhams)
           .HasForeignKey(m => m.IdSanPham)
           .OnDelete(DeleteBehavior.Restrict);
            // SanPhamCT ↔ các cấu hình chi tiết (1-1, vì mỗi model chỉ có 1 màn hình, 1 camera trước, v.v.)
            modelBuilder.Entity<SanPhamChiTiet>()
                .HasOne(m => m.ManHinh)
                .WithMany()
                .HasForeignKey(m => m.IdManHinh)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<SanPhamChiTiet>()
                .HasOne(m => m.CameraTruoc)
                .WithMany()
                .HasForeignKey(m => m.IdCameraTruoc)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<SanPhamChiTiet>()
                .HasOne(m => m.CameraSau)
                .WithMany()
                .HasForeignKey(m => m.IdCameraSau)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<SanPhamChiTiet>()
                .HasOne(m => m.Pin)
                .WithMany()
                .HasForeignKey(m => m.IdPin)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<SanPhamChiTiet>()
                .HasOne(m => m.RAM)
                .WithMany()
                .HasForeignKey(m => m.IdRAM)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<SanPhamChiTiet>()
                .HasOne(m => m.ROM)
                .WithMany()
                .HasForeignKey(m => m.IdROM)
                .OnDelete(DeleteBehavior.Restrict);

            // Ảnh sản phẩm ↔ ModelSanPham (1-n)
            modelBuilder.Entity<AnhSanPham>()
                .HasOne(a => a.SanPhamCT)
                .WithMany()
                .HasForeignKey(a => a.IdModelSanPham)
                .OnDelete(DeleteBehavior.Cascade);

            // Giỏ hàng ↔ Khách hàng (1-1 hoặc 1-n )
            modelBuilder.Entity<GioHang>()
                .HasOne(g => g.KhachHang)
                .WithMany()
                .HasForeignKey(g => g.IdKhachHang)
                .OnDelete(DeleteBehavior.Cascade);

            //  Chi tiết giỏ hàng ↔ Giỏ hàng & ModelSanPham 
            modelBuilder.Entity<GioHangChiTiet>()
                .HasKey(gc => gc.IdGioHangChiTiet); // PK riêng

            modelBuilder.Entity<GioHangChiTiet>()
            .HasOne(ct => ct.GioHang)
            .WithMany(g => g.GioHangChiTiets)
              .HasForeignKey(ct => ct.IdGioHang)
            .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<GioHangChiTiet>()
           .HasOne(ct => ct.SanPhamCT)
           .WithMany(m => m.GioHangChiTiets)
           .HasForeignKey(ct => ct.IdModelSanPham)
           .OnDelete(DeleteBehavior.Restrict);

            //  Đơn hàng ↔ Khách hàng (n-1, nullable nếu nhân viên tạo đơn)
            modelBuilder.Entity<DonHang>()
                .HasOne(d => d.KhachHang)
                .WithMany(k => k.DonHangs)
                .HasForeignKey(d => d.IdKhachHang)
                .OnDelete(DeleteBehavior.Restrict);

            //  Chi tiết đơn hàng ↔ Đơn hàng & ModelSanPham
            modelBuilder.Entity<DonHangChiTiet>()
                .HasOne(dt => dt.DonHang)
                .WithMany(d => d.DonHangChiTiets)
                .HasForeignKey(dt => dt.IdDonHang)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<DonHangChiTiet>()
                .HasOne(dt => dt.SanPhamCT)
                .WithMany()
                .HasForeignKey(dt => dt.IdModelSanPham)
                .OnDelete(DeleteBehavior.Restrict);

            //  Chi tiết hóa đơn ↔ Hóa đơn & ModelSanPham,Imei
            modelBuilder.Entity<HoaDonChiTiet>()
                .HasOne(hc => hc.HoaDon)
                .WithMany(h => h.HoaDonChiTiets)
                .HasForeignKey(hc => hc.IdHoaDon)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<HoaDonChiTiet>()
                .HasOne(hc => hc.SanPhamCT)
                .WithMany()
                .HasForeignKey(hc => hc.IdModelSanPham)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<HoaDonChiTiet>()
               .HasOne(h => h.Imei)
               .WithMany()
               .HasForeignKey(h => h.IdImei)
               .OnDelete(DeleteBehavior.Restrict);

            //  Thanh toán ↔ Hoa Don (1-n, một đơn có thể có nhiều giao dịch thanh toán)
            modelBuilder.Entity<ThanhToan>()
                .HasOne(t => t.HoaDon)
                .WithMany()
                .HasForeignKey(t => t.IdHoaDon)
                .OnDelete(DeleteBehavior.Cascade);

            //  Bảo hành ↔ IMEI & Khách hàng
            modelBuilder.Entity<BaoHanh>()
                .HasOne(b => b.Imei)
                .WithMany()
                .HasForeignKey(b => b.IdImei)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<BaoHanh>()
                .HasOne(b => b.KhachHang)
                .WithMany()
                .HasForeignKey(b => b.IdKhachHang)
                .OnDelete(DeleteBehavior.Restrict);

            //  IMEI ↔ SanPhamCT (1-n)
            modelBuilder.Entity<Imei>()
                .HasOne(i => i.SanPhamCT)
                .WithMany()
                .HasForeignKey(i => i.IdModelSanPham)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Imei>()
                .HasIndex(i => i.MaImei)
                .IsUnique(); // IMEI không được trùng

            // Tồn kho ↔ ModelSanPham & Kho (n-1 cho model, n-1 cho kho)
            modelBuilder.Entity<TonKho>()
                .HasOne(tk => tk.SanPhamCT)
                .WithMany()
                .HasForeignKey(tk => tk.IdModelSanPham)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<TonKho>()
                .HasOne(tk => tk.Kho)
                .WithMany(k => k.TonKhos)
                .HasForeignKey(tk => tk.IdKho)
                .OnDelete(DeleteBehavior.Restrict);

            //  Địa chỉ ↔ Khách hàng (1-n)
            modelBuilder.Entity<KhachHang>()
         .HasMany(k => k.Diachi)
         .WithOne(d => d.KhachHang)
         .HasForeignKey(d => d.IdKhachHang)
         .OnDelete(DeleteBehavior.Cascade);

            //  Khuyến mãi ↔ Đơn hàngct / Hóa đơn 
            modelBuilder.Entity<DonHangChiTiet>()
                .HasOne(d => d.KhuyenMai)
                .WithMany()
                .HasForeignKey(d => d.IdKhuyenMai)
                .OnDelete(DeleteBehavior.Restrict);
            ///////////////
            modelBuilder.Entity<HoaDon>()
                .HasOne(h => h.KhuyenMai)
                .WithMany()
                .HasForeignKey(h => h.IdKhuyenMai)
                .OnDelete(DeleteBehavior.Restrict);
            //Hoa Don->KhachHang & NhanVien
            modelBuilder.Entity<HoaDon>()
               .HasOne(h => h.KhachHang)
               .WithMany()
               .HasForeignKey(h => h.IdKhachHang)
               .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<HoaDon>()
                .HasOne(h => h.NhanVien)
                .WithMany()
                .HasForeignKey(h => h.IdNhanVien)
                .OnDelete(DeleteBehavior.Restrict);
            base.OnModelCreating(modelBuilder);
        }
    }

}
