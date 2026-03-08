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
        public DbSet<NhomDoUong> NhomDoUongs { get; set; }
        public DbSet<Topping> Toppings { get; set; }
        public DbSet<NguyenLieu> NguyenLieus { get; set; }
        public DbSet<SanPhamChiTiet_Topping> SanPhamChiTiet_Toppings { get; set; }
        public DbSet<ChiTietCongThuc> ChiTietCongThucs { get; set; }
        

        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<KhuyenMai> KhuyenMais { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<SanPhamChiTiet> SanPhamCTs { get; set; }
        public DbSet<AnhSanPham> AnhSanPhams { get; set; }
        public DbSet<TonKho> TonKhos { get; set; }
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
         //NhomDoUong 1 - n SanPham
         modelBuilder.Entity<SanPham>()
        .HasOne(s => s.NhomDoUong)
        .WithMany(n => n.SanPhams)  // Thêm collection này vào NhomDoUong
        .HasForeignKey(s => s.IdNhomDoUong)
        .OnDelete(DeleteBehavior.Restrict);

            //SanPham -> SanPhamCT (1-n)
            modelBuilder.Entity<SanPhamChiTiet>()
           .HasOne(m => m.SanPham)
            .WithMany(s => s.ModelSanPhams)
           .HasForeignKey(m => m.IdSanPham)
           .OnDelete(DeleteBehavior.Restrict);
            //SanPhamCT-TOPPing(N-N)
            modelBuilder.Entity<SanPhamChiTiet_Topping>()
                .HasKey(st => new { st.IdSanPhamChiTiet, st.IdTopping });

             modelBuilder.Entity<SanPhamChiTiet_Topping>()
                .HasOne(st => st.SanPhamChiTiet)
                .WithMany(s => s.SanPhamChiTiet_Toppings)
                .HasForeignKey(st => st.IdSanPhamChiTiet);

            modelBuilder.Entity<SanPhamChiTiet_Topping>()
                .HasOne(st => st.Topping)
                .WithMany(t => t.SanPhamChiTiet_Toppings)
                .HasForeignKey(st => st.IdTopping);
            // Ảnh sản phẩm ↔ ModelSanPham (1-n)
            modelBuilder.Entity<AnhSanPham>()
               .HasOne(a => a.SanPhamCT)
               .WithMany()
               .HasForeignKey(a => a.IdModelSanPham)  // Đồng bộ tên nếu đổi key
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

            //  Chi tiết hóa đơn ↔ Hóa đơn & ModelSanPham
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

  

            //  Thanh toán ↔ Hoa Don (1-n, một đơn có thể có nhiều giao dịch thanh toán)
            modelBuilder.Entity<ThanhToan>()
                .HasOne(t => t.HoaDon)
                .WithMany()
                .HasForeignKey(t => t.IdHoaDon)
                .OnDelete(DeleteBehavior.Cascade);



            // Tồn kho ↔ ModelSanPham & Kho (n-1 cho model, n-1 cho kho)
            modelBuilder.Entity<TonKho>()
                .HasOne(tk => tk.NguyenLieu)
                .WithMany(n => n.TonKhos)
                .HasForeignKey(tk => tk.IdNguyenLieu)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<TonKho>()
                .HasOne(tk => tk.Kho)
                .WithMany(k => k.TonKhos)
                .HasForeignKey(tk => tk.IdKho)
                .OnDelete(DeleteBehavior.Restrict);
            //Chitietcongthuc(N-N)
            modelBuilder.Entity<ChiTietCongThuc>()
        .HasKey(cc => new { cc.IdSanPhamChiTiet, cc.IdNguyenLieu });

            modelBuilder.Entity<ChiTietCongThuc>()
                .HasOne(cc => cc.SanPhamChiTiet)
                .WithMany(s => s.CTCTs) 
                .HasForeignKey(cc => cc.IdSanPhamChiTiet)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ChiTietCongThuc>()
                .HasOne(cc => cc.NguyenLieu)
                .WithMany(n => n.CTCTs) 
                .HasForeignKey(cc => cc.IdNguyenLieu)
                .OnDelete(DeleteBehavior.Cascade);

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
